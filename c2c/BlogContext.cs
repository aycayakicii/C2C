using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace c2c
{
    public class BlogContext : DbContext
    {
        public BlogContext():base("BlogConnection")
        {
            
        }
        public DbSet<Kategori>Kategoriler { get; set; }
        public DbSet<Blog> Bloglar { get; set; }
        public DbSet<Yorum> Yorumlar { get; set; }
    }
}