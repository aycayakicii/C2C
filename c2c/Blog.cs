using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace c2c
{
    public class Blog
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Görsel { get; set; }
        public string Yazi { get; set; }
        //public Nullable<int> KategoriId { get; set; }
        public string Tarih { get; set; }
        public int Begeni { get; set; }


        //Foreign Keys

        public virtual List<Kategori> Kategori { get; set; }
        public virtual List<Yorum> Yorum { get; set; }




    }
}