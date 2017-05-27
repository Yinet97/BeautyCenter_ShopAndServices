using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeautyCenter_ShopAndServices.Models
{
    public class Servicios
    {
        [Key]

        public int ServicioId { get; set; }
        public string Nombre { get; set; }
        public double Costo { get; set; }
    }
}