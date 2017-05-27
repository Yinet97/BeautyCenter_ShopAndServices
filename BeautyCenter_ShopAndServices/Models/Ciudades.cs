using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeautyCenter_ShopAndServices.Models
{
    public class Ciudades
    {
        [Key]

        public int ProvinciaId { get; set; }
        public int CiudadId { get; set; }
        public string NombreCiudad { get; set; }
    }
}