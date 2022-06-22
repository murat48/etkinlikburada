using hirinchallenge.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace hirinchallenge.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        //Lütfen dikkat çok önemli bir durum nedeniyle proje bugün başladım elimden geldiğince yaptım daha çok kod kısmında görünümde hatalar çok ama kod yapısına bakarsanız sevinirim.Teşekkürler.
        //Baseurllocaldecalisanolmasigerekiyor

        string Baseurl = "https://localhost:44308/";
        public async Task<ActionResult> Index()
        {
            List<category> EmpInfo = new List<category>();
            using (var client = new HttpClient())
            {
                //Passing service base url
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                //Define request data format
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //Sending request to find web api REST service resource GetAllEmployees using HttpClient
                //HttpResponseMessage Res = await client.GetAsync("api/Event/Getevent?id=2");parametreli

                //HttpResponseMessage Res = await client.GetAsync("api/Event/Getevent?id=" + 2);parametreli
                HttpResponseMessage Res = await client.GetAsync("api/Event/Getcategories");
                //Checking the response is successful or not which is sent using HttpClient
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                    //Deserializing the response recieved from web api and storing into the Employee list
                    EmpInfo = JsonConvert.DeserializeObject<List<category>>(EmpResponse);
                }


                List<events> EmpInfo2 = new List<events>();
                using (var client2 = new HttpClient())
                {
                    //Passing service base url
                    client2.BaseAddress = new Uri(Baseurl);
                    client2.DefaultRequestHeaders.Clear();
                    //Define request data format
                    client2.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    //Sending request to find web api REST service resource GetAllEmployees using HttpClient
                    //HttpResponseMessage Res = await client.GetAsync("api/Event/Getevent?id=2");parametreli

                    //HttpResponseMessage Res = await client.GetAsync("api/Event/Getevent?id=" + 2);parametreli
                    HttpResponseMessage Res2 = await client2.GetAsync("api/Event/Dateofeventwillbe");
                    //Checking the response is successful or not which is sent using HttpClient
                    if (Res2.IsSuccessStatusCode)
                    {
                        //Storing the response details recieved from web api
                        var EmpResponse2 = Res2.Content.ReadAsStringAsync().Result;
                        //Deserializing the response recieved from web api and storing into the Employee list
                        EmpInfo2 = JsonConvert.DeserializeObject<List<events>>(EmpResponse2);
                    }


                }

                List<events> endevent = new List<events>();
                using (var client3 = new HttpClient())
                {
                    //Passing service base url
                    client3.BaseAddress = new Uri(Baseurl);
                    client3.DefaultRequestHeaders.Clear();
                    //Define request data format
                    client3.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    //Sending request to find web api REST service resource GetAllEmployees using HttpClient
                    //HttpResponseMessage Res = await client.GetAsync("api/Event/Getevent?id=2");parametreli

                    //HttpResponseMessage Res = await client.GetAsync("api/Event/Getevent?id=" + 2);parametreli
                    HttpResponseMessage Res3 = await client3.GetAsync("api/Event/Dateofeventend");
                    //Checking the response is successful or not which is sent using HttpClient
                    if (Res3.IsSuccessStatusCode)
                    {
                        //Storing the response details recieved from web api
                        var EmpResponse3 = Res3.Content.ReadAsStringAsync().Result;
                        //Deserializing the response recieved from web api and storing into the Employee list
                        endevent = JsonConvert.DeserializeObject<List<events>>(EmpResponse3);
                    }

                    ViewBag.cat = EmpInfo;
                    ViewBag.even = EmpInfo2;
                    ViewBag.evenend = endevent;
                    ViewBag.cit = Veritabani.gtcity;
                    return View();
                }








            }
        }
        public ActionResult Kaydedilenler()
        {

            return PartialView(Veritabani.Kategori);
        }
        public ActionResult searchevent(FormCollection form, int id)
        {
            string adi = form["name"];
            adi = adi.ToLower();
           
            ViewBag.eventdetail = Veritabani.gtevent.Where(i => i.eventname.ToLower() == adi);
            int idd = 0;
            int catid = 0;
            foreach (hirinchallenge.Models.events i in ViewBag.eventdetail)
            {
                idd= i.eventid;
                catid = i.categoryid;
            }
          ViewBag.veriler = Veritabani.gtphoto.Where(i => i.eventid==idd);
            ViewBag.catergorydetail = Veritabani.Kategori.Where(i => i.categoryid == catid);
            return View();


        }
        [HttpPost]
        public ActionResult filtrele(FormCollection form)
        {
            int katid = 0;
            string kategori = form["kategori"];
            if (kategori!="Kategori")
            {
                 katid = Convert.ToInt32(form["kategori"]);
            }
            int sehirid = 0;
            string sehir = form["sehir"];
            if (sehir != "Sehirler")
            {
                sehirid = Convert.ToInt32(form["sehir"]);
            }
            string tarih =form["tarih"];
            DateTime simdikitarih = DateTime.Now;
            if (tarih == "today")
            { 
                simdikitarih = simdikitarih.AddDays(0);
            }
            else if(tarih=="tomorrow")
            {
                simdikitarih = simdikitarih.AddDays(1);
            }
            else if (tarih == "weekend")
            {
                simdikitarih = simdikitarih.AddDays(7);
            }
            else if(tarih=="15gun")
            {
                simdikitarih = simdikitarih.AddDays(15);
            }
            else
            {
                tarih = "";
            }
           
            if(tarih==""||sehirid==0||katid==0)
            { 
                if(sehirid==0)
                {
                    ViewBag.filters = Veritabani.gtevent.Where(i => i.categoryid == katid);
                }
                else if(katid==0&&sehirid!=0)
                {
                    ViewBag.filters = Veritabani.gtevent.Where(i => i.cityid == sehirid);
                }
                else if(katid!=0&&sehirid!=0)
                {
                    ViewBag.filters = Veritabani.gtevent.Where(i => i.categoryid == katid && i.cityid == sehirid);
                }
           
            }
            else
            {
                ViewBag.filters = Veritabani.gtevent.Where(i => i.categoryid == katid || i.cityid == sehirid||i.eventdate==simdikitarih);
            }

            int idd = 0;
            int catid = 0;
            foreach (hirinchallenge.Models.events i in ViewBag.filters)
            {
                idd = i.eventid;
                catid = i.categoryid;
            }
            ViewBag.veriler = Veritabani.gtphoto.Where(i => i.eventid == idd);
            ViewBag.catergorydetail = Veritabani.Kategori.Where(i => i.categoryid == catid);
            return View();
        }
        public ActionResult Eventsdetail(int id)
        {
           ViewBag.veriler= Veritabani.gtphoto.Where(i => i.eventid == id);
            ViewBag.eventdetail = Veritabani.gtevent.Where(i => i.eventid == id);
            int catid = 0;
            foreach (hirinchallenge.Models.events i in ViewBag.eventdetail)
            {
                catid = i.categoryid;
            }
            ViewBag.catergorydetail = Veritabani.Kategori.Where(i => i.categoryid==catid);
            return View();
        }
        [HttpPost]
        public ActionResult ilet(category model)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    Veritabani.Add(model);
                    //string adi = form["name"];
                    //string mail = form["message"];
                    //string email = form["email"];

                  //string adi = model.categoryname;
                  //  string mail = model.catergoryphoto;
                    if (ViewBag.Mesaj != null)
                    {
                        //ModelState.Remove("adi");
                        //ModelState.Remove("mail");


                        //adi = "";
                        //mail = "";

                    }

                    return RedirectToAction("Index", "Home");
                }
                else
                {

                    TempData["msj"] = "Hata!!!Lutfen Tum Alanlari Doldurunuz!!!";

                    return RedirectToAction("iletisim", "Home");

                }
            }
            catch
            {

                return View();
            }
        }




 
 


            }
        }