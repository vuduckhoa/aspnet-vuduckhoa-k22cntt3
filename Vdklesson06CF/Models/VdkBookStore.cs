using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Vdklesson06CF.Models
{
    public class VdkBookStore:DbContext
    {
        public VdkBookStore():base() { }
        // khai bao cac thuoc tinh voi cac bang trong csdl
        public DbSet<VdkCategory>VdkCategories { get; set; }
        public DbSet<VdkBook>VdkBooks { get; set; }
    }
}