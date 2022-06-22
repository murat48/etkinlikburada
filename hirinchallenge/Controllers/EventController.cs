using hirinchallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace hirinchallenge.Controllers
{
    
    public class EventController : ApiController
    {

        public IEnumerable<events> Getevent()
        {
            return Veritabani.gtevent;

        }
        public IEnumerable<category> Getcategories()
        {
            return Veritabani.Kategori;

        }
        [HttpGet]
        public IEnumerable<category> categoriesname(int id)
        {
            return Veritabani.Kategori.Where(i=>i.categoryid==id);

        }
        [HttpGet]
        public IEnumerable<events> eventgt(int id)
        {
            return Veritabani.gtevent.Where(i => i.eventid == id);

        }

        public IEnumerable<events> gtphoto(int id)
        {
            return Veritabani.gtevent.Where(i => i.eventid == id);

        }
        [HttpGet]
        public IEnumerable<events> Dateofeventend()
        {


            //var timerecords = await _context.TimeTrackers
            //    .Where(t => t.TtUserId >= 7 && t.TtUserId <= 10 && t.IsCompleted == true && t.TtInStamp >= startDt && t.TtInStamp <= endDt)
            //    .OrderByDescending(tt => tt.TtId)
            //    .ToListAsync();


            DateTime date = DateTime.Now;
            DateTime startDt = new DateTime(2022, 6, 24);
            DateTime endDt = new DateTime(2022, 6, 30);
            //return Veritabani.gtevent.Where(i => i.eventdate >= startDt && i.eventdate <= endDt);
            return Veritabani.gtevent.Where(i => i.eventenddate < date.AddDays(-1));
        }
        [HttpGet]
        public IEnumerable<events> Dateofeventwillbe()
        {


            //var timerecords = await _context.TimeTrackers
            //    .Where(t => t.TtUserId >= 7 && t.TtUserId <= 10 && t.IsCompleted == true && t.TtInStamp >= startDt && t.TtInStamp <= endDt)
            //    .OrderByDescending(tt => tt.TtId)
            //    .ToListAsync();


            DateTime date = DateTime.Now;
            DateTime startDt = new DateTime(2022, 6, 24);
            DateTime endDt = new DateTime(2022, 6, 30);
            //return Veritabani.gtevent.Where(i => i.eventdate >= startDt && i.eventdate <= endDt);
            return Veritabani.gtevent.Where(i => i.eventenddate > date.AddDays(-1));
        }
    }
}
