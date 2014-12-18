using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialization of new objects of classes Arbiter and Season
            Console.Title = "Add new Arbiter";
            Arbiter newArbiter = new Arbiter();
            Season newSeason = new Season();


            Console.WriteLine("First name of new arbiter: ");
            newArbiter.FirstName = Console.ReadLine();
            
            Console.WriteLine("Last name of new arbiter: ");
            
                Console.WriteLine("First name of new arbiter: ");
                newArbiter.FirstName = Console.ReadLine();
            
            newArbiter.LastName = Console.ReadLine();
        }
    }
}
