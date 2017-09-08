using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Web.Views
{
    public class YoloContext: DbContext
    {
        public YoloContext() :base("DefaultConnection")
        { }

        //public DbSet<>
    }
}