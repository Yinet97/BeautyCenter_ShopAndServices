using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeautyCenter_ShopAndServices.Models
{
    public class Productos
    {
        [Key]

        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public int CantExistencia { get; set; }

    }
}