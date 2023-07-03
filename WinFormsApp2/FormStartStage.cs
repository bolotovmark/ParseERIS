using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.parse;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class FormStartStage : Form
    {
        public eapi Eapi;

        public FormStartStage()
        {
            InitializeComponent();
            labelCount.Text = string.Empty;
            toolTipAdd.SetToolTip(buttonAddTypesSI, "Добавление ключевого слова в список искомых");
            toolTipRemove.SetToolTip(buttonRemoveTypesSI, "Выделите из списка слово, которое хотите удалить");
            toolTipClear.SetToolTip(buttonClearTypesSI, "Очищает список");
            toolTipFindCount.SetToolTip(buttonCheck, "Показывает кол-во записей из которых будет производиться отбор");
        }

        public string SumSearchTerms()
        {
            var yearA = dateTimePickerA.Value.Date.ToString("yyyy-MM-dd");
            var yearB = dateTimePickerB.Value.Date.ToString("yyyy-MM-dd");
            var totalSearchTerms = "?";

            totalSearchTerms += "verification_date_start=" + yearA;
            totalSearchTerms += "&verification_date_end=" + yearB;

            return totalSearchTerms;
        }

        public List<string> GetTypesSI()
        {
            var output = new List<string>();

            foreach (string terms in listBoxMitTitle.Items)
            {
                output.Add(terms);
            }
            return output;
        }

        private async void buttonCheck_Click(object sender, EventArgs e)
        {
            if (GetTypesSI().Count > 0)
            {
                progressBarCount.Value = 75;

                Eapi = new eapi(SumSearchTerms(), new SearchTerms(GetTypesSI()));
                await Eapi.CheckCount(new CancellationTokenSource());

                labelCount.Text = Eapi.Count.ToString();
                progressBarCount.Value = 100;
                progressBarCount.Value = 0;
            }
            else
            {
                MessageBox.Show("Укажите хотя бы одно наименование типа СИ", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //listBoxMitTitle
        //Add
        private void buttonAddTypesSI_Click(object sender, EventArgs e)
        {
            new FormInsert(ref listBoxMitTitle).ShowDialog(this);
        }
        //Remove
        private void buttonRemoveTypesSI_Click(object sender, EventArgs e)
        {
            listBoxMitTitle.Items.Remove(listBoxMitTitle.SelectedItem);
        }
        //Clear
        private void buttonClearTypesSI_Click(object sender, EventArgs e)
        {
            listBoxMitTitle.Items.Clear();
        }

        private void buttonNextStage_Click(object sender, EventArgs e)
        {
            if (GetTypesSI().Count > 0)
            {
                this.Hide();
                new Form1(GetTypesSI(), SumSearchTerms()).ShowDialog(this);
                this.Show();
            }
            else
            {
                MessageBox.Show("Укажите хотя бы одно наименование типа СИ", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
