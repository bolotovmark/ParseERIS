using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.parse;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class FormStartStage2 : Form
    {
        Dictionary<string, TermsUrl> terms = new Dictionary<string, TermsUrl>();

        public eapi Eapi;

        public FormStartStage2()
        {
            InitializeComponent();
            treeViewTermsURL.CheckBoxes = true;
            labelSave.Hide();
            labelCount.Text = string.Empty;

            toolTip1.SetToolTip(buttonCount, "Высчитать кол-во записей из которых будет производиться отбор");
            toolTip1.SetToolTip(checkBoxAnd, "Отбираются только те записи, где присутсвуют все указанные искомые слова");
            //toolTip1.SetToolTip(checkBoxOR, "Отбираются только те записи, где присутсувует хотя бы одно из указанных искомых слов");
            toolTip1.SetToolTip(checkBoxTerm, "Форма для заполнения атрибута логического типа (Да/Нет)");
            toolTip1.SetToolTip(buttonSave, "Сохранить поисковые настройки атрибута");
            toolTip2.SetToolTip(checkBoxOR, "Отбираются только те записи, где присутсувует хотя бы одно из указанных искомых слов." +
                "\nПри использовании данного парметра возможны повторения записей");

        }

        private void ShowInfo(TermsUrl infoTerm)
        {
            textBoxTerms.Clear();
            checkBoxAnd.Checked = false;
            checkBoxOR.Checked = false;

            labelDatePicker.Enabled = false;
            dateTimePickerTerm.Enabled = false;
            checkBoxTerm.Enabled = false;
            checkBoxOR.Enabled = false;
            checkBoxAnd.Enabled = false;
            labelWords.Enabled = false;
            textBoxTerms.Enabled = false;


            labelSearchTerm.Text = infoTerm.title;

            if (infoTerm.tag == "boolean")
            {
                labelTypeFormat.Text = "Логический (Да / Нет)";
                checkBoxTerm.Enabled = true;
                if (infoTerm.words.Count > 0)
                {
                    checkBoxTerm.Checked = bool.Parse(infoTerm.words[0]);
                }
            }
            if (infoTerm.tag == "date")
            {
                labelTypeFormat.Text = "Дата";
                labelDatePicker.Enabled = true;
                dateTimePickerTerm.Enabled = true;
                if (infoTerm.words.Count > 0)
                {
                    DateTime date = DateTime.ParseExact(infoTerm.words[0], "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    dateTimePickerTerm.Value = date;
                }
            }
            if (infoTerm.tag == "string")
            {
                labelTypeFormat.Text = "Строка";
                checkBoxOR.Enabled = true;
                checkBoxAnd.Enabled = true;
                labelWords.Enabled = true;
                textBoxTerms.Enabled = true;

                foreach (string line in infoTerm.words)
                {
                    textBoxTerms.AppendText(line + Environment.NewLine);
                }

                if (infoTerm.formatQuery)
                {
                    checkBoxAnd.Checked = true;
                }
                else
                {
                    checkBoxOR.Checked = true;
                }
            }
        }

        private void treeViewTermsURL_AfterSelect(object sender, TreeViewEventArgs e)
        {

            if (e.Node.IsSelected)
            {
                if (terms.ContainsKey(e.Node.Name))
                {
                    ShowInfo(terms[e.Node.Name]);
                }
                else
                {
                    ShowInfo(new TermsUrl(e.Node.Text, e.Node.Name, e.Node.Tag.ToString()));
                }
                labelSave.Hide();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            TreeNode node = treeViewTermsURL.SelectedNode;
            string key = node.Name;
            string tag = node.Tag.ToString();

            var newItem = new TermsUrl(node.Text, node.Name, node.Tag.ToString());
            newItem.words.Clear();

            if (tag == "string")
            {
                newItem.words = GetListWords();
                newItem.formatQuery = checkBoxAnd.Checked;
            }
            if (tag == "date")
            {
                newItem.words.Add(dateTimePickerTerm.Value.Date.ToString("yyyy-MM-dd"));
                newItem.formatQuery = true;
            }
            if (tag == "boolean")
            {
                newItem.words.Add(checkBoxTerm.Checked.ToString());
                newItem.formatQuery = true;
            }


            if (terms.ContainsKey(key))
            {
                terms[key] = newItem;
            }
            else
            {
                terms.Add(key, newItem);
            }
            labelSave.Hide();
        }

        public List<string> GetListWords()
        {
            List<string> words = new List<string>();
            string[] lines = textBoxTerms.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string terms in lines)
            {
                words.Add(terms);
            }

            return words;
        }

        private void treeViewTermsURL_AfterCheck(object sender, TreeViewEventArgs e)
        {
            //if (e.Node.Checked)
            //{
            //    //string selectedNodeText = e.Node.Text;
            //    //MessageBox.Show(selectedNodeText);
            //}

            //if (!e.Node.Checked)
            //{
            //    string selectedNodeText = e.Node.Text;
            //    MessageBox.Show(selectedNodeText);
            //}
        }

        public string GetDateTerms()
        {
            var yearA = dateTimePickerA.Value.Date.ToString("yyyy-MM-dd");
            var yearB = dateTimePickerB.Value.Date.ToString("yyyy-MM-dd");
            var totalSearchTerms = "?";

            totalSearchTerms += "verification_date_start=" + yearA;
            totalSearchTerms += "&verification_date_end=" + yearB;

            return totalSearchTerms;
        }

        private List<TermsUrl>? GetTerms()
        {
            var checkedTerms = new List<TermsUrl>();

            foreach (TreeNode node in treeViewTermsURL.Nodes)
            {

                if (node.Checked)
                {
                    var name = node.Name;
                    if (terms.ContainsKey(name))
                    {
                        if (terms[name].words.Count > 0)
                        {
                            checkedTerms.Add(terms[name]);
                        }
                        else
                        {
                            return null;
                        }

                    }
                    else
                    {
                        return null;
                    }
                }
            }

            return checkedTerms;
        }

        private void buttonNextStage_Click(object sender, EventArgs e)
        {
            var temp = GetTerms();
            if (temp == null)
            {
                MessageBox.Show("Отмеченный вами атрибут не заполнен. " +
                    "Вернитесь на предыдущий шаг и проверьте корректность заполненных данных.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var atributesUrl = new URLAtributesGenerate(temp);

            this.Hide();
            new Form1(GetDateTerms(), atributesUrl).ShowDialog(this);
            this.Show();

            //listBox1.Items.Clear();
            //foreach (var row in atributesUrl.listURLAtributes)
            //{
            //    listBox1.Items.Add(row);
            //}


            //var enumerator = GetWords().GetEnumerator();
            //termsURL.Clear();
            //GetUrl(enumerator, "");

            //if (termsURL.Count > 0)
            //{
            //    this.Hide();
            //    new Form1(termsURL, GetDateTerms()).ShowDialog(this);
            //    this.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Укажите хотя бы одно наименование типа СИ", "Ошибка",
            //                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void checkBoxAnd_CheckedChanged(object sender, EventArgs e)
        {
            labelSave.Show();
            System.Windows.Forms.CheckBox checkBox = (System.Windows.Forms.CheckBox)sender;
            if (checkBox.Checked)
            {
                checkBoxOR.Checked = false;
            }
            else
            {
                checkBoxOR.Checked = true;
            }
        }

        private void checkBoxOR_CheckedChanged(object sender, EventArgs e)
        {
            labelSave.Show();
            System.Windows.Forms.CheckBox checkBox = (System.Windows.Forms.CheckBox)sender;
            if (checkBox.Checked)
            {
                checkBoxAnd.Checked = false;
            }
            else
            {
                checkBoxAnd.Checked = true;
            }
        }

        private void textBoxTerms_TextChanged(object sender, EventArgs e)
        {
            labelSave.Show();
        }

        private void checkBoxTerm_CheckedChanged(object sender, EventArgs e)
        {
            labelSave.Show();
        }

        private void dateTimePickerTerm_ValueChanged(object sender, EventArgs e)
        {
            labelSave.Show();
        }

        private async void buttonCount_Click(object sender, EventArgs e)
        {

            var temp = GetTerms();
            if (temp == null)
            {
                MessageBox.Show("Отмеченный вами атрибут не заполнен. " +
                    "Вернитесь на предыдущий шаг и проверьте корректность заполненных данных.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var atributesUrl = new URLAtributesGenerate(temp);
            Eapi = new eapi(GetDateTerms(), atributesUrl);

            Eapi.ProgressSet += Eapi_ProgressBarCountMaximux;
            Eapi.ProgressValue += Eapi_IncrementingValueProgress;
            Eapi.GetCount += Eapi_GetCount;
            await Eapi.CheckCount(new CancellationTokenSource());
            progressBarCount.Value = 0;
        }

        private void Eapi_ProgressBarCountMaximux(int count)
        {
            if (progressBarCount.InvokeRequired)
            {
                progressBarCount.Invoke(new System.Action(() => progressBarCount.Maximum = count));
            }
            else
            {
                progressBarCount.Maximum = count;
            }
        }

        private void Eapi_IncrementingValueProgress()
        {
            if (progressBarCount.InvokeRequired)
            {
                progressBarCount.Invoke(new System.Action(() =>
                ++progressBarCount.Value));
            }
            else
            {
                ++progressBarCount.Value;
            }
        }

        private void Eapi_GetCount(int count)
        {
            if (labelCount.InvokeRequired)
            {
                labelCount.Invoke(new System.Action(() => labelCount.Text = count.ToString()));
            }
            else
            {
                labelCount.Text = count.ToString();
            }
        }
    }
}
