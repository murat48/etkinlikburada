using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hirinchallenge.Models
{
    public static class veritabani2
    {
        private static List<category> icategory;

        static veritabani2()
        {
            icategory = new List<category>();
            {
                new category() { categoryid = 1, categoryname = "Tiyatro", catergoryphoto = "tiyatro.jpeg", categoryvisible = true };
                new category() { categoryid = 2, categoryname = "Konser", catergoryphoto = "konser.jpeg", categoryvisible = true };
                new category() { categoryid = 3, categoryname = "Resim", catergoryphoto = "resim.jpeg", categoryvisible = true };
                new category() { categoryid = 4, categoryname = "Gezi", catergoryphoto = "gezi.jpeg", categoryvisible = true };
            }



        }

        public static List<category> Kategori
        {

            get { return icategory; }
        }
        public static void kategoriekle(category cat)
        {
            icategory.Add(cat);
        }

        public static category kategorigetir(int catid)
        {
            category id = null;
            foreach (var category in icategory)
            {
                if (category.categoryid == catid)
                {
                    id = category;
                }
            }
            return id;
        }
    }
}