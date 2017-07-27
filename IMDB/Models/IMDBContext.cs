using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IMDB.Models
{
    public class IMDBContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public IMDBContext() : base("name=IMDBContext")
        {
        }

        public System.Data.Entity.DbSet<IMDB.Models.Movie> Movies { get; set; }

        public System.Data.Entity.DbSet<IMDB.Models.Actor> Actors { get; set; }

        public System.Data.Entity.DbSet<IMDB.Models.Genre> Genres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
