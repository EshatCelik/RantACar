using BLL.Abstract;
using BLL.Concreate.EntityFramework;
using DAL.Concreate;
using Entity.Concreate;
using System;

namespace Console.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarService _carService = new CarService(new CarDalManager()); ;

           var list= _carService.GetAll().Data;

            foreach (var item in list)
            {
                System.Console.WriteLine(item.CarName);
            }

            //int x = 123;
            //int r = 0;

            //string ss = "";
            //while (x>0)
            //{
            //    if (x>0)
            //    {


            //        r = x % 10;
            //        x = x / 10;
            //        ss = ss + r.ToString();
            //    }
            //    else
            //    {
            //        r = x % 10;
            //        x = x / 10;
            //        ss = ss + r.ToString();
            //    }


            //}

            //System.Console.WriteLine(ss);

        }
    }
}
