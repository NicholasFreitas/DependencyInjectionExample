using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{

    /// <summary>
    /// This class helps with the decoupling of the object from the service that will need to run these injectable objects
    /// The factory is now responsble for the injectable object creation and will also aid in creating mocks as well.
    /// </summary>
    class InjectableObjectFactory
    {

        public static IInjectableObjectInterface GetObjectA() 
        {
            return new InjectableObjectA();
        }

        public static IInjectableObjectInterface GetObjectB() 
        {
            return new InjectableObjectB();
        }
    }
}
