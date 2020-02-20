using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using MyWcfService;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(Service1)))
            {
                host.Open();
                Console.WriteLine("Veuillez entrer un chiffre");
                int val = Convert.ToInt32( Console.ReadLine());
                Service1 myServ = new Service1();
                int result = Convert.ToInt32(myServ.Fibonacci(val)); ;
                Console.WriteLine("Le Fibonacci("+ val +") = "+ result);
                Console.ReadKey();
                //host.Close();

            }
        }
    }
}
