using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {


            //through constructor
            var objServ = new ObjectService(InjectableObjectFactory.GetObjectA());
            
            objServ.RunService();



            //through method
            var objServ2 = new ObjectService();

            objServ2.RegisterServiceDependency(InjectableObjectFactory.GetObjectB());

            objServ2.RunService();




        }
    }
}
