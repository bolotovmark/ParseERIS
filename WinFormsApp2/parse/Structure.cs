﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.parse
{

    public class Structure
    {
        public Result result { get; set; } = new Result();
    }

    public class Result
    {
        public int count { get; set; } = 0;
        public int start { get; set; } = 0;
        public int rows { get; set; } = 0;
        public List<Item> items { get; set; } = new List<Item>();
    }

    public class Item
    {
        public string vri_id { get; set; } = "";
        //public string org_title { get; set; }
        //public string mit_number { get; set; }
        //public string mit_title { get; set; }
        //public string mit_notation { get; set; }
        //public string mi_modification { get; set; }
        //public string mi_number { get; set; }
        //public string verification_date { get; set; }
        //public string valid_date { get; set; }
        //public string result_docnum { get; set; }
        //public bool applicability { get; set; }
        
    }

}
