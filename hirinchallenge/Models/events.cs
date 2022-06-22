using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hirinchallenge.Models
{
    public class events
    {

        public int eventid { get; set; }
        public string eventname { get; set; }
        public string eventdescription { get; set; }
        public DateTime eventdate { get; set; }
        public DateTime eventenddate { get; set; }
        public string eventphoto { get; set; }
        public float eventprice { get; set; }
        public int categoryid { get; set; }
        public int placeid { get; set; }
        public int cityid { get; set; }
        public string googlemaplink { get; set; }
        public string adres { get; set; }
    }
}