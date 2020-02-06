using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{

    /// <summary>
    /// This interface represents the structure of the object we intend to inject.
    /// In this insance we have a simple Run command that represents some sort of behavior
    /// for the object.
    /// </summary>
    interface IInjectableObjectInterface
    {
        public string Run();
    }
}
