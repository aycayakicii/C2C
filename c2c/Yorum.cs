using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace c2c
{
    public class Yorum
    {

        public int Id { get; set; }
        public int BlogId { get; set; }
        public string IsimSoyisim { get; set; }
        public string EMail { get; set; }
        public string Tarih { get; set; }
        

        public virtual Blog Blog { get; set; }


    }
}