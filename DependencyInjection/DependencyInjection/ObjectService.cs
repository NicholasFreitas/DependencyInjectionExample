using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    /// <summary>
    /// We can inject the behavior in a few ways. 
    /// We can make a method to register the service or
    /// we can inject the service through the constructor
    /// </summary>
    class ObjectService
    {
        /// <summary>
        /// This is the dependency. We can use it's functionality and
        /// at run time we can inject the behavior. Which means all this
        /// class is concerned with is the service it's providing.
        /// The responsibility of member creation is then given to another
        /// class (in this instance, the InjectableObjectFactory.
        /// </summary>
        private IInjectableObjectInterface _objectDependency;


        public ObjectService()
        {
        }

        public ObjectService(IInjectableObjectInterface injectableObjectInterface)
        {
            _objectDependency = injectableObjectInterface;
        }

        public void RegisterServiceDependency(IInjectableObjectInterface injectableObjectInterface) 
        {
            _objectDependency = injectableObjectInterface;
        }

        public void RunService() 
        {
            Console.WriteLine(_objectDependency.Run());
        }

    }
}
