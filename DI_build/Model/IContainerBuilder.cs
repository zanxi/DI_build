using DI_build.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_build
{
    public interface IContainerBuilder
    {
        void Register(ServiceDescriptor serviceDescriptor);
        IContainer Build();
    }
}
