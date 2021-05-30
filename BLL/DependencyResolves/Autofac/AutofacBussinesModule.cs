using Autofac;
using BLL.Abstract;
using BLL.Concreate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DependencyResolves.Autofac
{


    //bu sınıfı kullanmak için outofac kütüphanesi kullanmalıdır
    public class AutofacBussinesModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CarService>().As<ICarCervice>().SingleInstance();

        }

    }
}
