using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello ! What's your firstname ?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What's your lastname ?");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Bonjour {firstName} {lastName}, nous sommes le {DateTime.Now}. Comment allez-vous ?");


        }
    }
}
