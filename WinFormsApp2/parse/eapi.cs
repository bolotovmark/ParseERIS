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
        class GetResponse
        {
            private HttpClient httpClient;

            public GetResponse(HttpClient httpClient)
            {
                this.httpClient = httpClient;
            }

            public async Task <Stream> Request(string url, CancellationTokenSource token)
            {
                Stream stream = null;
                try
                {
                    HttpResponseMessage response;
                    do
                    {
                        System.Threading.Thread.Sleep(500);
                        response = await httpClient.GetAsync(url, token.Token);
                        if (!response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("С вашего IP было больше двух запросов в секунду", "Предупреждение",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning,
                                MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
                            MessageBox.Show(url);

                        }
                    }
                    while (!response.IsSuccessStatusCode);

                    response.EnsureSuccessStatusCode();
                    stream = await response.Content.ReadAsStreamAsync();
                }
                catch (TaskCanceledException) {
                    
                }
                

                return stream;
            }
        }

        public event Action<int> ProgressUpdated;
        public event Action<int> ProgressSet;
        public event Action ProgressValue;
        public event System.Action IncrementingLabelFindCount;

        public Dictionary<string, string> rowValues = new Dictionary<string, string>();
        public int Count { get; set; }
        string urlTerms { get; set; }
        public SearchTerms Keywords { get; set; }
        public bool etaMI { get; set; }
        public bool stopCheck = false;

        public HttpClient httpClient;
        public ExcelClass xlApp;

        public eapi(string urlTerms, SearchTerms keywords)
        {
            httpClient = new HttpClient();
            this.urlTerms = urlTerms;
            this.Keywords = keywords;
        }

        public eapi(string urlTerms) {
            httpClient = new HttpClient();
            this.urlTerms = urlTerms;
        }

        public async Task CheckCount(CancellationTokenSource token)
        {
            await Task.Run(async() => {

                try
                {
                    ProgressSet?.Invoke(Keywords.SumTypesSI.Count);
                    var client = new GetResponse(httpClient);
                    Count = 0;

                    foreach (string temp in Keywords.SumTypesSI)
                    {
                        string url = "https://fgis.gost.ru/fundmetrology/eapi/vri"
                            + urlTerms + temp;

                        using (var jsonDoc = JsonDocument.Parse(await client.Request(url, token)))
                        {
                            var ResultElement = jsonDoc.RootElement.GetProperty("result");
                            var count = ResultElement.GetProperty("count");

                            Count += count.GetInt32();
                        }
                        ProgressValue?.Invoke();
                    }
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
                    await CheckCount(token);

                    ProgressSet?.Invoke(Count);
                    xlApp = new ExcelClass();

                    if (xlApp == null)
                    {
                        MessageBox.Show("Excel is not properly installed!!");
                        return;
                    }

                    int i = 2;
                    var iter = 1;

                    if (httpClient == null)
                    {
                        httpClient = new HttpClient();
                    }

                    await Hide(!true);

                    foreach (string temp in Keywords.SumTypesSI)
                    {
                        string url = "https://fgis.gost.ru/fundmetrology/eapi/vri"
                            + urlTerms + temp;

                        var client = new GetResponse(httpClient);
                        int endId = 0;
                        int startId = 0;

                        using (var jsonDoc = JsonDocument.Parse(await client.Request(url, token)))
                        {
                            var ResultElement = jsonDoc.RootElement.GetProperty("result");
                            endId = ResultElement.GetProperty("count").GetInt32();
                        }

                        url += "&rows=100&start=";

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
                    xlApp.Save();
                }
                catch (TaskCanceledException) { }
                catch (System.ArgumentNullException) {}
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
                        var check = await Loop(item.Value);
                        if (!check)
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
    }
}
