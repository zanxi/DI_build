using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_build.Model
{
    public enum _LifeTime
    {
        Transcient,
        Scoped,
        Singlton
    }

    public abstract class ServiceDescriptor
    {
                                   // init;   
        public Type ServiceType { get; set; }
        public _LifeTime  LifeTime { get; set; }
    }
}
