using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hirinchallenge.Models
{
    public class category
    {

        public int categoryid { get; set; }
        public string categoryname { get; set; }
        public string catergoryphoto { get; set; }
        public bool? categoryvisible { get; set; }

    }
}