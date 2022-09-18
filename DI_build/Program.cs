using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI_build.Model;

namespace DI_build
{
    internal class Program
    {
        static void Main(string[] args)
        {
            iService service = new Service();
            var controller = new Controller(service);
            controller.Do();

            var reg = new Registration();
            var container = reg.ConfigureServices();
            //container.Resolve<Controller>().Do();

            IContainerBuilder builder = new ContainerBuilder();
            builder.RegisterSinglton<iService, Service>().
            RegisterTranscient<iHelper>(null,s => new Helper()).
            RegisterSinglton<iAnotherService>(null, AnotherService.instance);
        }
    }
}
