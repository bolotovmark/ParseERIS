using Microsoft.VisualBasic.Devices;
using System;
using System.Data;
using System.Net.Http.Json;
using System.Windows.Forms;
using System.Xml.Linq;
using WinFormsApp2.parse;


namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public eapi Eapi;
        public Dictionary<KeyTag, Keyword> checkedTerms = new Dictionary<KeyTag, Keyword>();
        public List<string> TypesSI;
        public string SumSearchTerms;

        public Form1(List<string> typesSI, string sumSearchTerms)
        {
            InitializeComponent();

            TypesSI = typesSI;
            SumSearchTerms = sumSearchTerms;

            //labelCount.Text = "";

            openFileDialog1.Filter = "Excel Files (*.xlsx)|*.xlsx";

            treeView1.CheckBoxes = true;

        }

        private Dictionary<KeyTag, Keyword> ReloadCheckedTerms()
        {
            checkedTerms = new Dictionary<KeyTag, Keyword>();

            foreach (TreeNode node in treeView1.Nodes)
            {
                CheckedNode(node, "last");
            }

            return checkedTerms;
        }

        private void CheckedNode(TreeNode tree, string last)
        {
            if (tree.Checked && tree.Name != "not")
            {
                checkedTerms.Add(new KeyTag(tree.Name, tree.Tag.ToString()), new FormDialogAddSearchTerms(tree.Text, last, tree.Name).ShowDialog(tree.Tag.ToString()));
            }

            if (tree.Nodes != null)
            {
                foreach (TreeNode n in tree.Nodes)
                {
                    CheckedNode(n, tree.Text);
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

        private async void buttonNextStage_Click(object sender, EventArgs e)
        {
            Eapi = new eapi(SumSearchTerms, new SearchTerms(ReloadCheckedTerms(), TypesSI));
            this.Hide();
            new FormFinishStage(Eapi).ShowDialog(this);
            this.Show();
        }

        private void buttonBackStage_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public class KeyTag : IEquatable<KeyTag>
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public KeyTag(string key, string value)
        {
            Key = key;
            Value = value;
        }

        public bool Equals(KeyTag other)
        {
            if (other == null)
                return false;

            return Key == other.Key && Value == other.Value;
        }
    }
}