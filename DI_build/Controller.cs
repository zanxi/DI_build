using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_build
{
    internal class Controller
    {
        private readonly iService _service;
        public Controller(iService service)
        {
            _service = service;
        }

        public void Do() { }
    }
}
