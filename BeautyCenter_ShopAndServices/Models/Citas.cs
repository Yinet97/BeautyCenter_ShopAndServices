using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeautyCenter_ShopAndServices.Models
{
    public class Citas
    {
        [Key]
        public int CitaId { get; set; }
        public string NombreCliente { get; set; }
        public string Servicio { get; set; }
        public int CantPersonas { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
    }
}