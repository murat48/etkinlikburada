using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hirinchallenge.Models
{
    public class photos
    {
        public int photoid { get; set; }
        public string photoname { get; set; }
        public int eventid { get; set; }

        public int placeid { get; set; }
        public int cityid { get; set; }
    }
}