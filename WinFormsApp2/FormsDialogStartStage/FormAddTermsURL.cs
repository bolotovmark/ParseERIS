using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using WinFormsApp2.parse;
using static WinFormsApp2.FormStartStage2;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class FormAddTermsURL : Form
    {
        List<string> booleanTerms = new List<string>()
        {
            "applicability"
        };

        List<string> dateTerms = new List<string>() {
            "valid_date"
        };
        public TermsUrl info;

        public FormAddTermsURL(TermsUrl temp)
        {
            InitializeComponent();

            info = temp;
            labelSearchTerm.Text = temp.title;
            //labelSection.Text = section;
            labelTypeFormat.Text = "Строка";
            if (booleanTerms.Contains(temp.name)) { labelTypeFormat.Text = "Логический (true / false)"; }
            if (dateTerms.Contains(temp.name)) { labelTypeFormat.Text = "Дата (2003-04-18 / yyyy-mm-dd)"; }

            buttonNextTerm.DialogResult = DialogResult.OK;

            // Добавление строк в TextBox
            foreach (string line in temp.words)
            {
                textBoxTerms.AppendText(line + Environment.NewLine);
            }

            if (temp.formatQuery)
            {
                checkBoxAnd.Checked = true;
            }
            else
            {
                checkBoxOR.Checked = true;
            }
            //toolTipCheckBox.SetToolTip(checkBox, "Пункт отмечен: Искомый атрибут не может быть пустым\n" +
            //    "Пункт не отмечен: Искомый атрибут может быть пустым");
            //toolTipAdd.SetToolTip(buttonAddTerms, "Добавление ключевого слова в список искомых");
            //toolTipRemove.SetToolTip(buttonRemoveTerms, "Выделите из списка слово, которое хотите удалить");
            //toolTipClear.SetToolTip(buttonClearTerms, "Очищает список");
        }

        public TermsUrl ShowDialog(string emptyValue)
        {
            using (FormAddTermsURL dialog = this)
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    info.words = GetListWords();

                    return info;
                }
                else
                {
                    return null;
                }
            }
        }

        private void checkBoxAnd_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.CheckBox checkBox = (System.Windows.Forms.CheckBox)sender;
            if (checkBox.Checked)
            {
                checkBoxOR.Checked = false;
                info.formatQuery = true;
            }
            else
            {
                checkBoxOR.Checked = true;
                info.formatQuery = false;
            }
        }

        private void checkBoxOR_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.CheckBox checkBox = (System.Windows.Forms.CheckBox)sender;
            if (checkBox.Checked)
            {
                checkBoxAnd.Checked = false;
                info.formatQuery = false;
            }
            else
            {
                checkBoxAnd.Checked = true;
                info.formatQuery = true;
            }
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

        //private void buttonAddTerms_Click(object sender, EventArgs e)
        //{
        //    new FormInsert(ref listBoxTerms).ShowDialog(this);
        //}
        ////Remove
        //private void buttonRemoveTerms_Click(object sender, EventArgs e)
        //{
        //    listBoxTerms.Items.Remove(listBoxTerms.SelectedItem);
        //}
        //Clear
    }
}

