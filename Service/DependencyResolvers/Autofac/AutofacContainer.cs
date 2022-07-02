using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Repository.Abstract;
using Repository.Concrete;
using Service.Abstract;
using Service.Concrete;

namespace Service.DependencyResolvers.Autofac
{
    public class AutofacContainer : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CarService>().As<ICarService>().SingleInstance();
            builder.RegisterType<CarRepository>().As<ICarRepository>().SingleInstance();
        }
    }
}
