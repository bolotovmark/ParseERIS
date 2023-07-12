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
    public class SearchTerms
    {
        public Dictionary<KeyParent, Keyword> checkedTerms = new Dictionary<KeyParent, Keyword>();

        public bool resultOutput;

        //work for parse
        public SearchTerms(Dictionary<KeyParent, Keyword> checkedTerms)
        {
            this.checkedTerms = checkedTerms;
        }

        public bool CheckRow(ref Dictionary<string, string> row, bool etaMI)
        {
            bool output = true;
            //foreach(var temp in row)
            //{
            //    MessageBox.Show(temp.Key);
            //}
            foreach (var dictKeyword in checkedTerms)
            {
                if (row.ContainsKey(dictKeyword.Key.key))
                {
                    
                    var rowValue = row[dictKeyword.Key.key];
                    var keywordValue = dictKeyword.Value;

                    if (keywordValue.tag == "etaMI" || keywordValue.tag == "singleMI")
                    {
                        if (etaMI && keywordValue.tag == "etaMI")
                        {
                            if (keywordValue.words.Count > 0)
                            {
                                if (keywordValue.formatQuery)
                                {
                                    output = keywordValue.words.All(str => rowValue.ToLower().Contains(str));
                                }
                                else
                                {
                                    output = keywordValue.words.Any(str => rowValue.ToLower().Contains(str));
                                }
                            }
                        }
                        if (!etaMI && keywordValue.tag == "singleMI")
                        {
                            if (keywordValue.words.Count > 0)
                            {
                                if (keywordValue.formatQuery)
                                {
                                    output = keywordValue.words.All(str => rowValue.ToLower().Contains(str));
                                }
                                else
                                {
                                    output = keywordValue.words.Any(str => rowValue.ToLower().Contains(str));
                                }
                            }
                        }
                    }
                    if (keywordValue.words.Count > 0)
                    {
                        if (keywordValue.formatQuery)
                        {
                            output = keywordValue.words.All(str => rowValue.ToLower().Contains(str));
                        }
                        else
                        {
                            output = keywordValue.words.Any(str => rowValue.ToLower().Contains(str));
                        }
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
    }

    public class Keyword : ICloneable
    {
        public string title { get; set; }
        public string name { get; set; }
        public string tag { get; set; }
        public bool mandatory { get; set; }
        public bool formatQuery { get; set; }//true - И //fasle - ИЛИ
        public List<string> words { get; set; }

        public Keyword(string title, string name, string tag)
        {
            this.title = title;
            this.name = name;
            this.tag = tag;
            words = new List<string>();
        }

        private Keyword(string title, string name, string tag, bool mandatory, bool formatQuery, List<string> words)
        {
            this.title = title;
            this.name = name;
            this.tag = tag;
            this.mandatory = mandatory;
            this.formatQuery = formatQuery;
            this.words = words;
        }

        public object Clone() => new Keyword(title, name, tag, mandatory, formatQuery, new List<string>(words));
    }
}
