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

namespace WinFormsApp2
{
    public partial class FormDialogAddSearchTerms : Form
    {
        List<string> booleanTerms = new List<string>()
        {
            "briefIndicator"
        };

        List<string> dateTerms = new List<string>() {
            "vrfDate",
            "validDate"
        };

        public FormDialogAddSearchTerms(string title, string section, string name)
        {
            InitializeComponent();

            labelSearchTerm.Text = title;
            labelSection.Text = section;
            labelTypeFormat.Text = "Строка";
            if (booleanTerms.Contains(name)) { labelTypeFormat.Text = "Логический (true / false)"; }
            if (dateTerms.Contains(name)) { labelTypeFormat.Text = "Дата (18.04.2003)"; }

            buttonNextTerm.DialogResult = DialogResult.OK;
            toolTipCheckBox.SetToolTip(checkBox, "Пункт отмечен: Искомый атрибут не может быть пустым\n" +
                "Пункт не отмечен: Искомый атрибут может быть пустым");
            toolTipAdd.SetToolTip(buttonAddTerms, "Добавление ключевого слова в список искомых");
            toolTipRemove.SetToolTip(buttonRemoveTerms, "Выделите из списка слово, которое хотите удалить");
            toolTipClear.SetToolTip(buttonClearTerms, "Очищает список");
        }

        public Keyword GetFieldKeyword(ref ListBox listBoxTemp, ref CheckBox checkBox, string tag)
        {
            Keyword keyword = new Keyword();

            foreach (string terms in listBoxTemp.Items)
            {
                keyword.words.Add(terms);
            }

            keyword.mandatory = checkBox.Checked;
            keyword.tag = tag;

            return keyword;
        }


        private void buttonAddTerms_Click(object sender, EventArgs e)
        {
            new FormInsert(ref listBoxTerms).ShowDialog(this);
        }
        //Remove
        private void buttonRemoveTerms_Click(object sender, EventArgs e)
        {
            listBoxTerms.Items.Remove(listBoxTerms.SelectedItem);
        }
        //Clear
        private void buttonClearTerms_Click(object sender, EventArgs e)
        {
            listBoxTerms.Items.Clear();
        }

        public Keyword ShowDialog(string tag)
        {

            using (FormDialogAddSearchTerms dialog = this)
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    return GetFieldKeyword(ref listBoxTerms, ref checkBox, tag);
                }
                else
                {
                    return null;
                }
            }
        }

        private void buttonBuffer_Click(object sender, EventArgs e)
        {
            // Получение содержимого буфера обмена
            string clipboardText = Clipboard.GetText();

            // Разделение текста на строки
            string[] lines = clipboardText.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            // Добавление строк в Listbox
            listBoxTerms.Items.AddRange(lines);
        }
    }
}
