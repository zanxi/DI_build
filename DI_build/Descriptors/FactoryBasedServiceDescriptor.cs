using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_build.Model
{
    internal class FactoryBasedServiceDescriptor : ServiceDescriptor
    {
        public Func<IScope, object> factory { get; set; }
    }
}
