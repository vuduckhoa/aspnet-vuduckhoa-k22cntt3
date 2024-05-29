using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lesson06.Models
{
    public class VdkSong
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Vdk:hay nhap tieu de")]
        [DisplayName("tieu de")]
        public string VdkTitle { get; set; }
        [Required(ErrorMessage ="Vdk:hay nhap tac gia")]
        [DisplayName("tac gia")]

        public string VdkAuthor { get; set; }
        [Required(ErrorMessage ="Vdk:hay nhap nghe si")]
        [StringLength(50,MinimumLength =2, ErrorMessage = "Vdk:ten nghe si toi thieu 2 ki tu,toi da 50 ky tu")]
        [DisplayName("nghe si")]

        public string VdkArtist { get; set; }
        [Required(ErrorMessage ="Vdk:hay nhap nam xuat ban")]
        [RegularExpression(@"[0-9]{4}", ErrorMessage = "Vdk:nhap xuat ban phai co 2 ky tu so ")]
        [Range(1900,2024, ErrorMessage = "Vdk:nam xuat ban khoang 1900-2024")]
        public string VdkYearRelease { get; set; }
    }
}