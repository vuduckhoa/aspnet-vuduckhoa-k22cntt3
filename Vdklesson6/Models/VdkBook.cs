using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vdklesson06CF.Models
{
    public class VdkBook
    {
        [Key]
        public int VdkId { get; set; }
        public string VdkTitle { get; set; }
        public string VdkAuthor { get; set;}
        public string VdkYear { get; set;}
        public string VdkPulisher { get; set;}
        public string VdkPicture { get; set;}
        public int VdkCategoryId { get; set;}
        // thuoc tinh quan he
        public virtual VdkCategory VdkCategory { get; set; }
    }
}