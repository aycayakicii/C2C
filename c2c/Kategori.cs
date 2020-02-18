using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace c2c
{
    public class Kategori
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        

        public virtual List<Blog> Blog { get; set; }



    }
}