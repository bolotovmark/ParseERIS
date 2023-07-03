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
            buttonStop.Text = "Стоп";
            labelCount.Text = "";
            labelFindCount.Text = "0";
            buttonQuit.Hide();
        }

        private void buttonBackStage_Click(object sender, EventArgs e)
        {
            string message = "Вы хотите прекратить работу парсера - это приведет к сбросу уже собранных данных." +
                " Остановите парсинг и сохраните книгу, если хотите сохранить уже обработанные данные. \n Вы уверены, что хотите продолжить?";
            string caption = "Предупреждение";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(this, message, caption, buttons, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                //Eapi.stopCheck = true;
                s_cts.Cancel();
                Thread.Sleep(1000);
                if (Eapi.xlApp != null) { Eapi.xlApp.Quit(); }
                this.Close();
            }
        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
            buttonStop.Show();
            Eapi.ProgressUpdated += Eapi_ProgressUpdated;
            Eapi.ProgressSet += Eapi_ProgressSetValue;
            Eapi.IncrementingLabelFindCount += Eapi_IncrementingLabelFindCount;
            s_cts = new CancellationTokenSource();
            await Eapi.Start(s_cts);
        }

        private async void buttonStop_Click(object sender, EventArgs e)
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
                buttonStop.Text = "Стоп";
            }

        }

        private async void buttonQuit_Click(object sender, EventArgs e)
        {
            Eapi.stopCheck = true;
            Thread.Sleep(1000);
            Eapi.xlApp.Save();
            await Eapi.Hide(!false);
            //Eapi.xlApp.Quit();
            this.Close();
        }

        private void FormFinishStage_FormClosing(object sender, FormClosingEventArgs e)
        {
            s_cts.Cancel();
            Thread.Sleep(1000);
            if (Eapi.xlApp != null) { Eapi.xlApp.Quit(); }
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
    }
}
