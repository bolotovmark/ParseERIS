using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.parse;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class FormFinishStage : Form
    {
        public eapi Eapi;
        public CancellationTokenSource s_cts = new CancellationTokenSource();
        public FormFinishStage(eapi Eapi)
        {
            InitializeComponent();
            this.Eapi = Eapi;

            buttonStop.Enabled = false;
            buttonQuit.Enabled = false;
            buttonStop.Text = "Пауза";
            labelCount.Text = "";
            labelFindCount.Text = "0";
            labelStatus.Text = "Готов к работе";
            buttonStart.Hide();

        }

        private void buttonBackStage_Click(object sender, EventArgs e)
        {
            //string message = "Вы хотите прекратить работу парсера - это приведет к сбросу уже собранных данных." +
            //    " Остановите парсинг и сохраните книгу, если хотите сохранить уже обработанные данные. \n Вы уверены, что хотите продолжить?";
            //string caption = "Предупреждение";
            //MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            //DialogResult result;

            //result = MessageBox.Show(this, message, caption, buttons, MessageBoxIcon.Warning);

            //if (result == DialogResult.Yes)
            //{
            //    //Eapi.stopCheck = true;
            //    s_cts.Cancel();
            //    Thread.Sleep(1000);
            //    if (Eapi.xlApp != null) { Eapi.xlApp.Quit(); }
            //    this.Close();
            //}
            this.Close();
        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
            buttonQuit.Enabled = true;
            buttonStop.Show();

            Eapi.ProgressUpdated += Eapi_ProgressUpdated;
            Eapi.ProgressSet += Eapi_ProgressSetValue;
            Eapi.IncrementingLabelFindCount += Eapi_IncrementingLabelFindCount;
            Eapi.SetStatus += Eapi_SetStatus;

            s_cts = new CancellationTokenSource();
            await Eapi.Start(s_cts);
            //if (Eapi.xlApp != null) { Eapi.xlApp.Quit(); }
            buttonQuit.Enabled = false;
            buttonStop.Enabled = false;
            labelStatus.Text = "Парсер завершил работу. Собранные данные сохранены.";

        }

        private async void buttonStop_Click(object sender, EventArgs e)
        {
            if (Eapi.xlApp != null)
            {
                if (!Eapi.stopCheck)
                {
                    Eapi.stopCheck = true;
                    await Eapi.Hide(!false);
                    buttonStop.Text = "Продолжить";
                }
                else
                {
                    Eapi.stopCheck = false;
                    await Eapi.Hide(!true);
                    buttonStop.Text = "Пауза";
                }
            }
        }

        private async void buttonQuit_Click(object sender, EventArgs e)
        {
            //s_cts.Cancel();
            //Thread.Sleep(1000);
            //if (Eapi.xlApp != null) { Eapi.xlApp.Quit(); }
            this.Close();
        }

        private void FormFinishStage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Eapi.xlApp.xlApp != null)
            {
                string message = "Вы хотите прекратить работу парсера - это приведет к сбросу уже собранных данных." +
                "Перед выходом, остановите парсинг и сохраните книгу. \nВы уверены, что хотите продолжить?";
                string caption = "Предупреждение";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult res;

                res = MessageBox.Show(this, message, caption, buttons, MessageBoxIcon.Warning);

                if (res == DialogResult.Yes)
                {
                    //Eapi.stopCheck = true;
                    s_cts.Cancel();
                    Thread.Sleep(1000);
                    if (Eapi.xlApp != null) { Eapi.xlApp.Quit(); }
                }
                e.Cancel = !(res == DialogResult.Yes);
            }
        }

        private void Eapi_IncrementingLabelFindCount()
        {
            if (labelFindCount.InvokeRequired)
            {
                labelFindCount.Invoke(new System.Action(() =>
                labelFindCount.Text = (int.Parse(labelFindCount.Text) + 1).ToString()));
            }
            else
            {
                labelFindCount.Text = (int.Parse(labelFindCount.Text) + 1).ToString();
            }
        }

        private void Eapi_ProgressSetValue(int count)
        {
            if (progressBar1.InvokeRequired)
            {
                progressBar1.Invoke(new System.Action(() => progressBar1.Maximum = count));
            }
            else
            {
                progressBar1.Maximum = count;
            }
        }

        public void Eapi_ProgressUpdated(int progress)
        {
            if (progress <= progressBar1.Maximum)
            {

                if (progressBar1.InvokeRequired)
                {
                    progressBar1.Invoke(new System.Action(() => progressBar1.Value = progress));
                    labelCount.Invoke(new System.Action(() => labelCount.Text = $"{progress} из {progressBar1.Maximum}"));
                }
                else
                {
                    progressBar1.Value = progress;
                    labelCount.Text = $"{progress} из {progressBar1.Maximum}";
                }
            }
        }

        public void Eapi_SetStatus(string text)
        {
            if (labelStatus.InvokeRequired)
            {
                labelStatus.Invoke(new System.Action(() => { labelStatus.Text = text; }));
            }
            else
            {
                labelStatus.Text = text;
            }
        }

        private void FormFinishStage_Load(object sender, EventArgs e)
        {
            buttonStart_Click(sender, e);
        }
    }
}
