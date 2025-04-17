//using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;
using System.Text.Json;
using System.Threading;

namespace WinFormsApp2.parse
{
    public class eapi
    {
        public event Action<int> ProgressUpdated;
        public event Action<int> ProgressSet;
        public event Action ProgressValue;
        public event Action IncrementingLabelFindCount;
        public event Action<int> GetCount;
        public event Action<string> SetStatus;

        public URLAtributesGenerate urls { get; set; }
        public SearchTerms Keywords { get; set; }


        public Dictionary<string, string> rowValues = new Dictionary<string, string>();
        public int Count { get; set; }
        string dateTerms { get; set; }
        public bool etaMI { get; set; }
        public bool stopCheck = false;

        public HttpClient httpClient;
        public ExcelClass xlApp;

        public eapi(string dateTerms, URLAtributesGenerate urls, SearchTerms keywords)
        {
            httpClient = new HttpClient();
            this.dateTerms = dateTerms;
            this.urls = urls;
            this.Keywords = keywords;
        }

        public eapi(string dateTerms, URLAtributesGenerate urls) {
            httpClient = new HttpClient();
            this.dateTerms = dateTerms;
            this.urls = urls;
        }

        public void GetResponseSetStatus(string status)
        {
            SetStatus?.Invoke(status);
        }

        public async Task CheckCount(CancellationTokenSource token)
        {
            await Task.Run(async() => {

                try
                {
                    ProgressSet?.Invoke(urls.listURLAtributes.Count);
                    var client = new GetResponse(httpClient);
                    Count = 0;

                    foreach (string temp in urls.listURLAtributes)
                    {
                        string url = "https://fgis.gost.ru/fundmetrology/eapi/vri"
                            + dateTerms + temp;

                        using (var jsonDoc = JsonDocument.Parse(await client.Request(url, token)))
                        {
                            var ResultElement = jsonDoc.RootElement.GetProperty("result");
                            var count = ResultElement.GetProperty("count");

                            Count += count.GetInt32();
                        }
                        ProgressValue?.Invoke();
                    }
                    GetCount?.Invoke(Count);

                }
                catch(TaskCanceledException) { }

            });
            
        }

        public async Task Start(CancellationTokenSource token)
        {
            await Task.Run(async () =>
            {
                try
                {
                    SetStatus?.Invoke("Подсчитывание общего кол-ва записей");
                    await CheckCount(token);

                    ProgressSet?.Invoke(Count);
                    SetStatus?.Invoke("Создание книжки Excel");
                    xlApp = new ExcelClass();

                    if (xlApp == null)
                    {
                        MessageBox.Show("Excel не обнаружен!");
                        SetStatus?.Invoke("Ошибка");
                        return;
                    }

                    int i = 2;
                    var iter = 1;

                    SetStatus?.Invoke("Создание HttpClient");
                    if (httpClient == null)
                    {
                        httpClient = new HttpClient();
                    }

                    await Hide(!true);

                    foreach (string temp in urls.listURLAtributes)
                    {
                        string url = "https://fgis.gost.ru/fundmetrology/eapi/vri"
                            + dateTerms + temp;
                        SetStatus?.Invoke("Получение пулла карточек");
                        var client = new GetResponse(httpClient);
                        client.SetStatus += GetResponseSetStatus;
                        int endId = 0;
                        int startId = 0;

                        using (var jsonDoc = JsonDocument.Parse(await client.Request(url, token)))
                        {
                            var ResultElement = jsonDoc.RootElement.GetProperty("result");
                            endId = ResultElement.GetProperty("count").GetInt32();
                        }

                        url += "&rows=100&start=";
                        SetStatus?.Invoke("Отбор");
                        while (startId < endId)
                        {
                            using (var jsonDoc = JsonDocument.Parse(await client.Request(url + startId.ToString(), token)))
                            {
                                var ResultElement = jsonDoc.RootElement.GetProperty("result");
                                var items = ResultElement.GetProperty("items");

                                var enumerate = items.EnumerateArray();

                                while (true)
                                {
                                    if (!stopCheck)
                                    {
                                        if (enumerate.MoveNext())
                                        {
                                            var tempVrId = enumerate.Current.GetProperty("vri_id");

                                            using (var root = JsonDocument.Parse(await client.Request("https://fgis.gost.ru/fundmetrology/eapi/vri/" + tempVrId.ToString(), token)))
                                            {
                                                xlApp.Counter(i + 1, (iter.ToString() + " из " + Count.ToString()));
                                                var row = root.RootElement.GetProperty("result");

                                                etaMI = false;
                                                rowValues.Clear();
                                                await Loop(row);

                                                if (Keywords.CheckRow(ref rowValues, etaMI))
                                                {
                                                    ++i;
                                                    IncrementingLabelFindCount?.Invoke();
                                                    xlApp.SetRow(etaMI, ref rowValues, i, tempVrId.ToString());
                                                }
                                                ++startId;
                                                ++iter;
                                                ProgressUpdated?.Invoke(iter);
                                            }
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Thread.Sleep(1000);
                                    }
                                }
                            }
                        }
                    }
                    xlApp.Hide(!false);
                    SetStatus?.Invoke("Сохранение книжки Excel");
                    xlApp.Save();
                }
                catch (TaskCanceledException) { SetStatus?.Invoke("Операция отменена"); }
                catch (System.ArgumentNullException) { SetStatus?.Invoke("Ошибка"); }
            });
        }

        public async Task<bool> Loop(JsonElement element) =>
            await Task.Run(async () =>
            {
                try
                {
                    foreach (var item in element.EnumerateObject())
                    {
                        if (item.Name == "etaMI")
                        {
                            etaMI = true;
                        }

                        if (item.Value.ToString()[0] == '[')
                        {
                            using var doc = JsonDocument.Parse(item.Value.ToString());
                            JsonElement roott = doc.RootElement;

                            var users = roott.EnumerateArray();
                            string outputText = "";
                            while (users.MoveNext())
                            {
                                var user = users.Current;
                                System.Console.WriteLine(user);

                                var props = user.EnumerateObject();
                               
                                
                                outputText += (string.Join(", ", props.Select(x => x.Value).Where(value => !value.ToString().Contains("http"))));

                                outputText += "; ";

                            }
                            //MessageBox.Show(outputText);
                            rowValues.Add(item.Name, outputText);
                        }

                        var check = await Loop(item.Value);
                        if (!check && item.Value.ToString()[0] != '[')
                        {

                            rowValues.Add(item.Name, item.Value.ToString());
                            //MessageBox.Show($"{item.Name}: {item.Value}");
                        }

                    }
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            });

        public async Task Hide(bool tick)
        {
            await Task.Run(() => {
                xlApp?.Hide(tick);
            });
        }

        class GetResponse
        {
            private HttpClient httpClient;
            public event Action<string> SetStatus;

            public GetResponse(HttpClient httpClient)
            {
                this.httpClient = httpClient;
                this.httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0");
            }

            public async Task<Stream> Request(string url, CancellationTokenSource token)
            {
                Stream stream = null;
                try
                {
                    HttpResponseMessage response;
                    int countErrorResponse = 0;
                    do
                    {
                        System.Threading.Thread.Sleep(500);
                        response = await httpClient.GetAsync(url, token.Token);

                        
                        if (!response.IsSuccessStatusCode)
                        {
                            SetStatus?.Invoke("Неудачный запрос. Повторение №" + countErrorResponse + " Код ошибки: " + response.StatusCode.ToString());
                            ++countErrorResponse;
                            if (countErrorResponse > 50)
                            {
                                System.Threading.Thread.Sleep(2000);
                            }
                                    
                            //MessageBox.Show(response.StatusCode.ToString());
                            //MessageBox.Show("С вашего IP было больше двух запросов в секунду", "Предупреждение",
                            //    MessageBoxButtons.OK, MessageBoxIcon.Warning,
                            //    MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
                            //MessageBox.Show(url);

                        }
                        
                    }
                    while (!response.IsSuccessStatusCode);

                    SetStatus?.Invoke("Отбор");
                
                    response.EnsureSuccessStatusCode();
                    stream = await response.Content.ReadAsStreamAsync();
                }
                catch (TaskCanceledException){ }
                catch (System.Net.Http.HttpRequestException) { }
                return stream;
            }
        }
    }
}
