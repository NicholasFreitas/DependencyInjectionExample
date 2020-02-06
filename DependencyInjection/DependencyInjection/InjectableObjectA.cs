using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    class InjectableObjectA : IInjectableObjectInterface
    {
        public string Run()
        {
            return "Injectable Object A behavior.";
        }
    }
}
