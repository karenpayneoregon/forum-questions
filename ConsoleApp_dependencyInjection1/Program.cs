using System;

namespace ConsoleApp_dependencyInjection1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConstructorInjection();

            Console.ReadLine();
        }

        private static void ConstructorInjection()
        {
            var client = new Client(new Service1());
            client.ServeMethod();

            client = new Client(new Service2());
            client.ServeMethod();
        }
    }
    public interface IService
    {
        void Serve();
    }
    public class Service1 : IService
    {
        public void Serve() { Console.WriteLine("Service1 Called"); }
    }
    public class Service2 : IService
    {
        public void Serve() { Console.WriteLine("Service2 Called"); }
    }
    public class Client
    {
        private readonly IService _service;
        public Client(IService service)
        {
            _service = service;
        }
        
        public void ServeMethod() { _service.Serve(); }
        
    }
}
