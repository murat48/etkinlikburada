using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hirinchallenge.Models
{
    public static class Veritabani
    {
        private static Dictionary<string, category> icategory;
        private static Dictionary<string, events> ievent;
        private static Dictionary<string, city> icity;
        private static Dictionary<string, place> iplace;
        private static Dictionary<string, photos> iphoto;
        static Veritabani()
       {
            //categories
            icategory = new Dictionary<string, category>();
            icategory.Add("1", new category
          { 
             categoryid=1,
                categoryname="Tiyatro",
                catergoryphoto="tiyatro.jpg",
                categoryvisible=true
            
            
            });

            icategory.Add("2", new category
            {
                categoryid = 2,
                categoryname = "Konser",
                catergoryphoto = "konser.jpg",
                categoryvisible = true


            });
            icategory.Add("3", new category
            {
                categoryid = 3,
                categoryname = "Resim",
                catergoryphoto = "resim.jpg",
                categoryvisible = true


            });
            icategory.Add("4", new category
            {
                categoryid = 4,
                categoryname = "Gezi",
                catergoryphoto = "gezi.jpg",
                categoryvisible = true


            });
            /////////////////////////////////////////////
           
            ievent = new Dictionary<string, events>();
            //DateTime dtstrt = new DateTime(2022, 06, 31); 
            //DateTime dtend = new DateTime(2022, 06, 31);
            ievent.Add("1",new events
            {
                eventid=1,
                eventname="Hamlet",
                eventdescription= "An Epic Symphony & maNga Events Across Turkey’in bir kült haline gelen uluslararası ödüllü projesi  An Epic Symphony, 24 Haziran 2022’de ülkemizin en önemli rock gruplarından MANGA ‘yı Night Flight Symphony Orchestra eşliğinde yeniden ağırlıyor.",
                eventprice=0,
                eventphoto = "tiyatro.jpg",
                googlemaplink= "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d12770.442493895884!2d28.2517777946702!3d36.85180039188316!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14bfbdbff1961523%3A0xdf8e730ed1eeb2be!2sMarmaris%2C+Mu%C4%9Fla!5e0!3m2!1str!2str!4v1489600472832",
                //eventdate = "24.06.2022",
                eventdate = new DateTime(2022, 6, 24),
                eventenddate= new DateTime(2022, 6, 24),
                categoryid =1,
                cityid=1,
                adres="Adres  gelecek",
            });


            ievent.Add("2", new events
            {
                cityid = 1,
                eventid = 2,
                eventname = "Bir Bebek Evi",
                eventdescription = "fdsfsfdsfsfsfsffsfs",
                eventprice = 200,
                eventphoto= "resim.jpg",
                //eventdate = "25.06.2022",
                eventdate = new DateTime(2022, 6, 25),
                eventenddate = new DateTime(2022, 6, 25),
                categoryid = 1,
                googlemaplink = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d12770.442493895884!2d28.2517777946702!3d36.85180039188316!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14bfbdbff1961523%3A0xdf8e730ed1eeb2be!2sMarmaris%2C+Mu%C4%9Fla!5e0!3m2!1str!2str!4v1489600472832",
                adres = "Adres  gelecek",

            });
            ievent.Add("3", new events
            {
                cityid = 1,
                eventid = 3,
                eventname = "Üç Kuruşluk Opera",
                eventdescription = "fdsfsfdsfsfsfsffsfs",
                eventprice = 150,
                eventphoto = "konser.jpg",
                //eventdate="23.06.2022",
                eventdate = new DateTime(2022, 6, 23),
                eventenddate = new DateTime(2022, 6, 23),
                categoryid = 1,
                googlemaplink = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d12770.442493895884!2d28.2517777946702!3d36.85180039188316!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14bfbdbff1961523%3A0xdf8e730ed1eeb2be!2sMarmaris%2C+Mu%C4%9Fla!5e0!3m2!1str!2str!4v1489600472832",

                adres = "Adres  gelecek",
            });
            ievent.Add("4", new events
            {
                cityid = 2,
                eventid = 4,
                eventname = "Tarkan",
                eventdescription = "fdsfsfdsfsfsfsffsfs",
                eventprice = 250,
                eventphoto = "gezi.jpg",
                //eventdate = "27.06.2022",
                eventdate = new DateTime(2022, 6, 27),
                eventenddate = new DateTime(2022, 6, 27),
                categoryid = 2,
                googlemaplink = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d12770.442493895884!2d28.2517777946702!3d36.85180039188316!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14bfbdbff1961523%3A0xdf8e730ed1eeb2be!2sMarmaris%2C+Mu%C4%9Fla!5e0!3m2!1str!2str!4v1489600472832",

                adres = "Adres  gelecek",
            });
            ievent.Add("5", new events
            {
                cityid = 2,
                eventid = 5,
                eventname = "Serdar Ortaç",
                eventdescription = "fdsfsfdsfsfsfsffsfs",
                eventprice = 250,
                eventphoto = "",
                eventdate = new DateTime(2022, 6, 25),
                eventenddate = new DateTime(2022, 6, 25),
                //eventdate = "25.06.2022",
                categoryid = 2,
                googlemaplink = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d12770.442493895884!2d28.2517777946702!3d36.85180039188316!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14bfbdbff1961523%3A0xdf8e730ed1eeb2be!2sMarmaris%2C+Mu%C4%9Fla!5e0!3m2!1str!2str!4v1489600472832",

                adres = "Adres  gelecek",
            }); 
            ievent.Add("6", new events
            {
                cityid = 3,
                eventid = 6,
                eventname = "Fazıl Say",
                eventdescription = "fdsfsfdsfsfsfsffsfs",
                eventprice = 350,
                eventphoto = "konser.jpg",
                eventdate = new DateTime(2022, 6, 26),
                eventenddate = new DateTime(2022, 6, 26),
                //eventdate = "26.06.2022",
                categoryid = 2,
                googlemaplink = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d12770.442493895884!2d28.2517777946702!3d36.85180039188316!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14bfbdbff1961523%3A0xdf8e730ed1eeb2be!2sMarmaris%2C+Mu%C4%9Fla!5e0!3m2!1str!2str!4v1489600472832",
                adres = "Adres  gelecek",

            });
            ievent.Add("7", new events
            {
                cityid = 3,
                eventid = 7,
                eventname = "Marmaris Sanat Galeri",
                eventdescription = "fdsfsfdsfsfsfsffsfs",
                eventprice = 50,
                eventphoto = "gezi.jpg",
                eventdate = new DateTime(2022, 6, 22),
                eventenddate = new DateTime(2022, 6, 22),
                googlemaplink = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d12770.442493895884!2d28.2517777946702!3d36.85180039188316!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14bfbdbff1961523%3A0xdf8e730ed1eeb2be!2sMarmaris%2C+Mu%C4%9Fla!5e0!3m2!1str!2str!4v1489600472832",
                categoryid = 3,
                adres = "Adres  gelecek",

            }); 
            ievent.Add("8", new events
            {
                cityid = 2,
                eventid = 8,
                eventname = "Fotograf Galeri",
                eventdescription = "fdsfsfdsfsfsfsffsfs",
                eventprice = 50,
                eventphoto = "tiyatro.jpg",
                eventdate = new DateTime(2022, 6, 28),
                eventenddate = new DateTime(2022, 6, 28),
                categoryid = 3,
                googlemaplink = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d12770.442493895884!2d28.2517777946702!3d36.85180039188316!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14bfbdbff1961523%3A0xdf8e730ed1eeb2be!2sMarmaris%2C+Mu%C4%9Fla!5e0!3m2!1str!2str!4v1489600472832",

                adres = "Adres  gelecek",
            });
            ievent.Add("9", new events
            {
                cityid = 1,
                eventid = 9,
                eventname = "Marmaris Gezisi",
                eventdescription = "fdsfsfdsfsfsfsffsfs",
                eventprice = 550,
                eventphoto = "",
                eventdate = new DateTime(2022, 6, 21),
                eventenddate = new DateTime(2022, 6, 21),
                categoryid = 3,
                googlemaplink = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d12770.442493895884!2d28.2517777946702!3d36.85180039188316!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14bfbdbff1961523%3A0xdf8e730ed1eeb2be!2sMarmaris%2C+Mu%C4%9Fla!5e0!3m2!1str!2str!4v1489600472832",
                adres = "Adres  gelecek",

            });
            ievent.Add("10", new events
            {
                cityid = 2,
                eventid = 10,
                eventname = "Antalya Gezisi",
                eventdescription = "fdsfsfdsfsfsfsffsfs",
                eventprice = 650,
                eventphoto = "konser.jpg",
                eventdate = new DateTime(2022, 6, 21),
                eventenddate = new DateTime(2022, 6, 21),
                categoryid = 3,
                googlemaplink = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d12770.442493895884!2d28.2517777946702!3d36.85180039188316!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14bfbdbff1961523%3A0xdf8e730ed1eeb2be!2sMarmaris%2C+Mu%C4%9Fla!5e0!3m2!1str!2str!4v1489600472832",

                adres = "Adres  gelecek",
            }); 
            ievent.Add("11", new events
            {
                cityid = 3,
                eventid = 11,
                eventname = "İstanbul Gezisi",
                eventdescription = "fdsfsfdsfsfsfsffsfs",
                eventprice = 650,
                eventphoto = "resim.jpg",
                //eventdate = "25.06.2022",
                eventdate = new DateTime(2022, 6, 25),
                eventenddate = new DateTime(2022, 6, 25),
                categoryid = 3,
                googlemaplink = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d12770.442493895884!2d28.2517777946702!3d36.85180039188316!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14bfbdbff1961523%3A0xdf8e730ed1eeb2be!2sMarmaris%2C+Mu%C4%9Fla!5e0!3m2!1str!2str!4v1489600472832",
                adres = "Adres  gelecek",
            });


            iphoto = new Dictionary<string, photos>();
         
                //DateTime dtstrt = new DateTime(2022, 06, 31); 
                //DateTime dtend = new DateTime(2022, 06, 31);
                iphoto.Add("1", new photos
                {
                    photoid = 1,
                    photoname = "tiyatro.jpg",
                    eventid = 1,
                    placeid = 1,



                    cityid = 1,
                });


                iphoto.Add("2", new photos
                {
                    photoid = 2,
                    photoname = "konser.jpg",
                    eventid = 1,
                    placeid = 1,



                    cityid = 1,
                });
                iphoto.Add("3", new photos
                {
                    photoid = 3,
                    photoname = "gezi.jpg",
                    eventid = 1,
                    placeid = 1,



                    cityid = 1,
                });
                iphoto.Add("4", new photos
                {
                    photoid = 4,
                    photoname = "resim.jpg",
                    eventid = 1,
                    placeid = 1,



                    cityid = 1,
                });
                iphoto.Add("5", new photos
                {
                    photoid = 5,
                    photoname = "resim.jpg",
                    eventid = 2,
                    placeid = 2,



                    cityid = 2,
                });
                iphoto.Add("6", new photos
                {
                    photoid = 6,
                    photoname = "konser.jpg",
                    eventid = 2,
                    placeid = 2,



                    cityid = 2,
                });
                iphoto.Add("7", new photos
                {
                    photoid = 7,
                    photoname = "konser.jpg",
                    eventid = 2,
                    placeid = 2,



                    cityid = 2,
                });
                iphoto.Add("8", new photos
                {
                    photoid = 8,
                    photoname = "resim.jpg",
                    eventid = 2,
                    placeid = 2,



                    cityid = 2,
                });
                iphoto.Add("9", new photos
                {
                    photoid = 9,
                    photoname = "gezi.jpg",
                    eventid = 2,
                    placeid = 2,



                    cityid = 2,
                });
                iphoto.Add("10", new photos
                {
                    photoid = 10,
                    photoname = "konser.jpg",
                    eventid = 2,
                    placeid = 2,



                    cityid = 2,
                });
                iphoto.Add("11", new photos
                {
                    photoid = 11,
                    photoname = "gezi.jpg",
                    eventid = 2,
                    placeid = 2,



                    cityid = 2,
                });
            

            icity = new Dictionary<string, city>();
            
                icity.Add("1", new city
                {
                    cityid = 1,
                    cityname="Marmaris",
                }) ;

                icity.Add("2", new city
                {
                    cityid = 2,
                    cityname = "Bodrum",
                });
                icity.Add("3", new city
                {
                    cityid = 3,
                    cityname = "Fethiye",
                });
                icity.Add("4", new city
                {
                    cityid = 4,
                    cityname = "Alanya",
                });
                icity.Add("5", new city
                {
                    cityid = 5,
                    cityname = "Kemer",
                });
            


            iplace = new Dictionary<string, place>();
            
                iplace.Add("1", new place
                {
                    placeid=1,
                    placename="Arena",

                });

                iplace.Add("2", new place
                {
                    placeid = 2,
                    placename = "Back Street",

                });
                iplace.Add("3", new place
                {
                    placeid = 3,
                    placename = "Kule Rock City Bar",

                });
                iplace.Add("4", new place
                {
                    placeid = 4,
                    placename = "Halikarnas",

                });
            







        }

        public static void Add(category model)
        {
            var last = icategory.Keys.LastOrDefault();
            string key = model.categoryname.ToLower();
            if(icategory.ContainsKey(key))
            {
          
                icategory[(key)] = model;
            }
            else
            {
                int sayi = Convert.ToInt32(last);
                sayi++;
                icategory.Add(sayi.ToString(), model);
            }
        }
        public static IEnumerable<category> Kategori
        {
            get { return icategory.Values; }

        }
        public static IEnumerable<events> gtevent
        {
            get { return ievent.Values; }

        }

        public static IEnumerable<photos> gtphoto
        {
            get { return iphoto.Values; }

        }
        public static IEnumerable<city> gtcity
        {
            get { return icity.Values; }

        }
    }
}