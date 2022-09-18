using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_build.Model
{
    internal class InstanceBasedServiceDescriptor : ServiceDescriptor
    {
        public object Instance { get; set; }
        public InstanceBasedServiceDescriptor(Type serviceType, object instance)
        {
            LifeTime = _LifeTime.Singlton;
            ServiceType = serviceType;
            Instance = instance;
        }
    }
}
