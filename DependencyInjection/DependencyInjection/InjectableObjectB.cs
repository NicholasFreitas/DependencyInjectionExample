using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    class InjectableObjectB : IInjectableObjectInterface
    {
        public string Run()
        {
            return "Injectable Object B";
        }
    }
}
