using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_build.Model
{
    public class Registration
    {
        public IContainer ConfigureService()
        {
            var builder = new ContainerBuilder();
            builder.RegisterTranscient<iService, Service>();
            builder.RegisterScoped<Controller, Controller>();
            return builder.Build();
        }
    }
}
