using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concreate
{
    public class Car:IEntity
    {
        public int ID { get; set; }
        public string CarName { get; set; }
        public int   BrandID { get; set; }
        public decimal Price { get; set; }
        //public string Color { get; set; }


    }
}
