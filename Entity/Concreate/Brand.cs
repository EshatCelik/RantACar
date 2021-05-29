using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concreate
{
   public class Brand:IEntity
    {
        public int ID { get; set; }
        public string BrandName { get; set; }
    }
}
