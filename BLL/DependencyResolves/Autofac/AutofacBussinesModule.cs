using Autofac;
using Autofac.Extras.DynamicProxy;
using BLL.Abstract;
using BLL.Concreate.EntityFramework;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
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

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }

    }
}
