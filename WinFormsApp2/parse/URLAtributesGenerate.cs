using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.parse
{
    public class URLAtributesGenerate
    {
        public List<string> listURLAtributes = new List<string>() { };
        public List<TermsUrl> deepCopyList;

        public URLAtributesGenerate(List<TermsUrl> listTerms)
        {
            deepCopyList = new List<TermsUrl>();

            foreach (var item in listTerms)
            {
                deepCopyList.Add((TermsUrl)item.Clone());
            }
            Generate();
        }

        public void Generate()
        {
            foreach (TermsUrl term in deepCopyList)
            {
                if (term.formatQuery)
                {
                    term.Shake();
                }
            }

            listURLAtributes.Clear();
            var enumerator = deepCopyList.GetEnumerator();
            GetUrl(enumerator, "");
        }

        private void GetUrl(List<TermsUrl>.Enumerator enumerator, string sumURL)
        {
            if (enumerator.MoveNext())
            {
                var name = enumerator.Current.name;
                var words = enumerator.Current.words;

                foreach (string word in words)
                {
                    var nextURL = sumURL + $"&{name}={word}";
                    GetUrl(enumerator, nextURL);
                }
            }
            else
            {
                listURLAtributes.Add(sumURL);
            }
        }
    }

    public class TermsUrl : ICloneable
    {
        public List<string> words = new List<string>();
        public string title;
        public string name;
        public string tag;
        public bool formatQuery;  //true - И //fasle - ИЛИ

        public TermsUrl(string title, string name, string tag)
        {
            this.title = title;
            this.name = name;
            this.tag = tag;
            formatQuery = true;
        }

        private TermsUrl(string title, string name, string tag, bool formatQuery, List<string> words)
        {
            this.title= title;
            this.name = name;   
            this.tag = tag;
            this.formatQuery = formatQuery;
            this.words = words;
        }

        public void Shake()
        {
            List<string> tempList = new List<string>(words);

            //foreach (var word in tempList)
            //{
            //    MessageBox.Show(word);
            //}
            words.Clear();
            Permute(tempList, 0, tempList.Count - 1, tag);

            //foreach (var word in words)
            //{
            //    MessageBox.Show(word);
            //}
        }

        public void Permute(List<string> a, int i, int n, string tag)
        {
            int j;

            if (i == n)
            {
                string outValue = "";
                if (tag == "string")
                {
                    foreach (string temp in a)
                    {
                        outValue += "*" + temp;
                    }
                    outValue += "*";
                }
                else
                {
                    outValue = a[0];
                }

                words.Add(outValue);
            }
            else
            {
                string temp;
                for (j = i; j <= n; j++)
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;

                    Permute(a, i + 1, n, tag);

                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
        }

        public object Clone() => new TermsUrl(title, name, tag, formatQuery, new List<string>(words));
    }
}
