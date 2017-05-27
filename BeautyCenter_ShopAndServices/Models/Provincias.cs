using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeautyCenter_ShopAndServices.Models
{
    public class Provincias
    {
        [Key]
        public int ProvinciaId { get; set; }
        public string NombreProv { get; set; }
    }
}