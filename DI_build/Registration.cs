using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_build
{
    // pattern builder - autofac
    internal class Registration
    {
        public Container ConfigureServices()
        {
            //var builder = new ContainerBuilder();
            //builder.RegisterTransient<iService, Service>();
            //builder.RegisterScoped<Controller, Controller>();
            return new Container();
        }
    }
}
