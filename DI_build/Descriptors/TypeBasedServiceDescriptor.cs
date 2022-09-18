using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_build.Model
{
    internal class TypeBasedServiceDescriptor : ServiceDescriptor
    {
        public Type ImplementationType { get; set; }
    }
}
