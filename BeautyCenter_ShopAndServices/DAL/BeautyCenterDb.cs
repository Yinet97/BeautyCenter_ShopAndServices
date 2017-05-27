using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BeautyCenter_ShopAndServices.DAL
{
    public class BeautyCenterDb : DbContext
    {
        public BeautyCenterDb() : base("BCDataBase")
        {

        }
    }
}