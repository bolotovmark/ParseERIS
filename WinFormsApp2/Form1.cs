using Microsoft.VisualBasic.Devices;
using System;
using System.Data;
using System.Globalization;
using System.Net.Http.Json;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using WinFormsApp2.parse;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static WinFormsApp2.parse.AtributesSearchTerms;


namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public eapi Eapi;
        public Dictionary<KeyParent, Keyword> checkedTerms = new Dictionary<KeyParent, Keyword>() { };
        public Dictionary<KeyParent, Keyword> outputTerms = new Dictionary<KeyParent, Keyword>() { };
        //
        public string dateTerms;
        public URLAtributesGenerate urls;
        //

        public Form1(string dateTerms, URLAtributesGenerate urls)
        {
            InitializeComponent();

            this.dateTerms = dateTerms;
            this.urls = urls;
            //openFileDialog1.Filter = "Excel Files (*.xlsx)|*.xlsx";
            treeView1.CheckBoxes = true;
            labelDatePicker.Enabled = false;
            dateTimePickerTerm.Enabled = false;
            checkBoxTerm.Enabled = false;
            checkBoxOR.Enabled = false;
            checkBoxAnd.Enabled = false;
            labelWords.Enabled = false;
            checkBoxMandatory.Enabled = false;
            textBoxTerms.Enabled = false;
            labelSection.Text = string.Empty;
            labelSearchTerm.Text = string.Empty;
            labelTypeFormat.Text = string.Empty;
            labelSave.Hide();

            toolTip1.SetToolTip(checkBoxAnd, "Отбираются только те записи, где присутсвуют все указанные искомые слова");
            toolTip1.SetToolTip(checkBoxOR, "Отбираются только те записи, где присутсувует хотя бы одно из указанных искомых слов");
            toolTip1.SetToolTip(checkBoxTerm, "Форма для заполнения атрибута логического типа (Да/Нет)");
            toolTip1.SetToolTip(buttonSave, "Сохранить поисковые настройки атрибута");
            toolTip1.SetToolTip(checkBoxMandatory, "Отбираются только те записи, которые содержат хоть какую-то информацию в выбранном атрибуте (не пустые)");
        }

        private void ShowInfo(KeyParent keyparent)
        {
            textBoxTerms.Clear();

            checkBoxAnd.Checked = false;
            checkBoxOR.Checked = false;
            checkBoxMandatory.Checked = false;

            labelDatePicker.Enabled = false;
            dateTimePickerTerm.Enabled = false;
            checkBoxTerm.Enabled = false;
            checkBoxOR.Enabled = false;
            checkBoxAnd.Enabled = false;
            labelWords.Enabled = false;
            checkBoxMandatory.Enabled = false;
            textBoxTerms.Enabled = false;
            labelSave.Hide();


            var keyword = checkedTerms[keyparent];

            labelSearchTerm.Text = keyword.title;
            labelSection.Text = keyparent.parentText;

            if (keyword.tag == "boolean")
            {
                labelTypeFormat.Text = "Логический (Да / Нет)";
                checkBoxTerm.Enabled = true;
                if (keyword.words.Count > 0)
                {
                    checkBoxTerm.Checked = bool.Parse(keyword.words[0]);
                }
            }
            if (keyword.tag == "date")
            {
                labelTypeFormat.Text = "Дата";
                labelDatePicker.Enabled = true;
                dateTimePickerTerm.Enabled = true;
                if (keyword.words.Count > 0)
                {
                    DateTime date = DateTime.ParseExact(keyword.words[0], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    dateTimePickerTerm.Value = date;
                }
            }
            if (keyword.tag == "string")
            {
                labelTypeFormat.Text = "Строка";
                checkBoxOR.Enabled = true;
                checkBoxAnd.Enabled = true;
                labelWords.Enabled = true;
                textBoxTerms.Enabled = true;
                checkBoxMandatory.Enabled = true;

                foreach (string line in keyword.words)
                {
                    textBoxTerms.AppendText(line + Environment.NewLine);
                }

                if (keyword.mandatory)
                {
                    checkBoxMandatory.Checked = true;
                }
                else
                {
                    checkBoxMandatory.Checked = false;
                }

                if (keyword.formatQuery)
                {
                    checkBoxAnd.Checked = true;
                }
                else
                {
                    checkBoxOR.Checked = true;
                }
            }
        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.IsSelected && e.Node.Parent != null)
            {
                var key = e.Node.Name;
                var parent = e.Node.Parent;

                //MessageBox.Show(parent.Text);
                var keyParent = new KeyParent(key, parent.Name, parent.Text);

                if (checkedTerms.ContainsKey(keyParent))
                {
                    ShowInfo(keyParent);
                }
                else
                {
                    checkedTerms.Add(keyParent, new Keyword(e.Node.Text, e.Node.Name, e.Node.Tag.ToString()));
                    ShowInfo(keyParent);
                }
                labelSave.Hide();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            TreeNode node = treeView1.SelectedNode;
            if (node.Parent == null) { return; }
            string key = node.Name;
            string text = node.Text;
            string tag = node.Tag.ToString();



            var newItem = new Keyword(text, key, tag);
            newItem.words.Clear();

            newItem.mandatory = checkBoxMandatory.Checked;

            if (tag == "string")
            {
                newItem.words = GetListWords();
                newItem.formatQuery = checkBoxAnd.Checked;
            }
            if (tag == "date")
            {
                newItem.words.Add(dateTimePickerTerm.Value.Date.ToString("dd.MM.yyyy"));
                newItem.formatQuery = true;
            }
            if (tag == "boolean")
            {
                newItem.words.Add(checkBoxTerm.Checked.ToString());
                newItem.formatQuery = true;
            }

            var termsKey = new KeyParent(key, node.Parent.Name, node.Parent.Text);

            if (checkedTerms.ContainsKey(termsKey))
            {
                checkedTerms[termsKey] = newItem;
            }
            else
            {
                checkedTerms.Add(termsKey, newItem);
            }

            labelSave.Hide();
        }


        private Dictionary<KeyParent, Keyword> ReloadCheckedTerms()
        {
            outputTerms = new Dictionary<KeyParent, Keyword>();

            foreach (TreeNode node in treeView1.Nodes)
            {
                CheckedNode(node);
            }

            return outputTerms;
        }

        private void CheckedNode(TreeNode node)
        {
            if (node.Checked && node.Parent != null)
            {
                var key = node.Name;
                var parentKey = node.Parent.Name;
                var parentText = node.Parent.Text;
                var data = new KeyParent(key, parentKey, parentText);

                if (checkedTerms.ContainsKey(data))
                {
                    outputTerms.Add(data, checkedTerms[data]);
                }


            }

            if (node.Nodes != null)
            {
                foreach (TreeNode n in node.Nodes)
                {
                    CheckedNode(n);
                }
            }
        }

        private void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = nodeChecked;
                if (node.Nodes.Count > 0)
                {
                    // If the current node has child nodes, call the CheckAllChildsNodes method recursively.
                    this.CheckAllChildNodes(node, nodeChecked);
                }
            }
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node.Nodes.Count > 0)
                {
                    CheckAllChildNodes(e.Node, e.Node.Checked);
                }
            }
        }

        private Dictionary<KeyParent, Keyword> GetCheckedTerms()
        {
            var outputDict = new Dictionary<KeyParent, Keyword>();
            foreach (TreeNode node in treeView1.Nodes)
            {
                MessageBox.Show(node.Text);
                if (node.Checked && node.Parent != null)
                {

                }
            }
            return outputDict;
        }

        private async void buttonNextStage_Click(object sender, EventArgs e)
        {
            Eapi = new eapi(dateTerms, urls, new SearchTerms(ReloadCheckedTerms()));
            this.Hide();
            new FormFinishStage(Eapi).ShowDialog(this);
            this.Show();
        }

        private void buttonBackStage_Click(object sender, EventArgs e)
        {
            Close();
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

        private void checkBoxMandatory_CheckedChanged(object sender, EventArgs e)
        {
            labelSave.Show();
        }

        private void dateTimePickerTerm_ValueChanged(object sender, EventArgs e)
        {
            labelSave.Show();
        }

        private void checkBoxTerm_CheckedChanged(object sender, EventArgs e)
        {
            labelSave.Show();
        }

        private void textBoxTerms_TextChanged(object sender, EventArgs e)
        {
            labelSave.Show();
        }
    }

    public class KeyParent : IEquatable<KeyParent>
    {
        public string key { get; set; }
        public string parentKey { get; set; }
        public string parentText { get; set; }

        public KeyParent(string key, string parentKey, string parentName)
        {
            this.key = key;
            this.parentKey = parentKey;
            this.parentText = parentName;
        }

        public void Show()
        {
            MessageBox.Show($"{key}, {parentKey}, {parentText}");
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + key.GetHashCode();
                hash = hash * 23 + parentKey.GetHashCode();
                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as KeyParent);
        }

        public bool Equals(KeyParent other)
        {
            if (other == null)
                return false;

            return key == other.key && parentKey == other.parentKey;
        }
    }
}