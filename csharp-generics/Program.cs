using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Toy<int> toyInt = new Toy<int>(1);
            Console.WriteLine(toyInt.DefaultValue());
            Console.WriteLine(toyInt.Value.ToString());

            Toy<string> toyString = new Toy<string>("Burak");
            Console.WriteLine(toyString.DefaultValue());
            Console.WriteLine(toyString.Value.ToString());


            Console.ReadLine();
            
        }
    }
}
