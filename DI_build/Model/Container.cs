using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_build.Model
{
    public class Container : IContainer
    {
        public Container(IEnumerable<ServiceDescriptor> descrLists)
        {

        }

        public IScope CreateScope()
        {
            return null;
        }

    }
}
