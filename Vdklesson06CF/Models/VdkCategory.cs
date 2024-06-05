using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vdklesson06CF.Models
{
    public class VdkCategory
    {
        [key]
        public int VdkId { get; set; }
        public string VdkCategoryName { get; set; }
        // thuoc tinh quan he
        public virtual ICollection<VdkBook>VdkBooks { get;set;}
    }
}