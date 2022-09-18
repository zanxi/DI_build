using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_build.Model
{
    internal class ContainerBuilder : IContainerBuilder
    {
        private readonly List<ServiceDescriptor> _descrLists = new List<ServiceDescriptor>();

        public void Register(ServiceDescriptor serviceDescriptor)
        {
            _descrLists.Add(serviceDescriptor);

        }

        public IContainer Build()
        {
            return null; // new Container();
        }
    }
}
