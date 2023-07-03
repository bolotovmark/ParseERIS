using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;

namespace WinFormsApp2.parse
{
    public class Keyword
    {
        public List<string> words = new List<string>();
        public string tag { get; set; }
        public bool mandatory { get; set; }
    }

    public class SearchTerms
    {
        public List<string> SumTypesSI;

        public Dictionary<KeyTag, Keyword> checkedTerms = new Dictionary<KeyTag, Keyword>();

        public bool resultOutput;

        //work for parse
        public SearchTerms(Dictionary<KeyTag, Keyword> checkedTerms, List<string> TypesSI)
        {
            this.checkedTerms = checkedTerms;

            SumTypesSI = new List<string>();
            Permute(TypesSI, 0, TypesSI.Count - 1);
        }

        //empty for test
        public SearchTerms(List<string> TypesSI) {

            SumTypesSI = new List<string>();
            Permute(TypesSI, 0, TypesSI.Count - 1);
        }
        
        public bool CheckRow(ref Dictionary<string, string> row, bool etaMI)
        {
            bool output = true;
            foreach(var dictKeyword in checkedTerms)
            {
                
                if(row.ContainsKey(dictKeyword.Key.Key))
                {
                    var rowValue = row[dictKeyword.Key.Key];
                    var keywordValue = dictKeyword.Value;

                    if(keywordValue.tag == "etaMI" || keywordValue.tag == "singleMI")
                    {
                        if(etaMI && keywordValue.tag == "etaMI")
                        {
                            if (keywordValue.words.Count > 0)
                            {
                                output = keywordValue.words.Any(str => rowValue.ToLower().Contains(str));
                            }
                        }
                        if(!etaMI && keywordValue.tag == "singleMI")
                        {
                            if (keywordValue.words.Count > 0)
                            {
                                output = keywordValue.words.Any(str => rowValue.ToLower().Contains(str));
                            }
                        }

                    }
                    if (keywordValue.words.Count > 0)
                    {
                        output = keywordValue.words.Any(str => rowValue.ToLower().Contains(str));
                    }
                }
                else
                {
                    if (dictKeyword.Value.mandatory)
                    {
                        return false;
                    }
                }

                if (!output)
                {
                    return false;
                }
            }
            return output;
        }

        private void Permute(List<string> a, int i, int n)
        {
            int j;

            if (i == n)
            {
                string outValue = "";
                foreach (string temp in a)
                {

                    outValue += "*" + temp;
                }
                outValue += "*";
                SumTypesSI.Add(outValue);
            }
            else
            {
                string temp;
                for (j = i; j <= n; j++)
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;

                    Permute(a, i + 1, n);

                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
        }
    }
}
