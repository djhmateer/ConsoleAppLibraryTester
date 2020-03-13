using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MethodExtensions;

namespace ConsoleAppLibraryTester
{
    class Program
    {
        static void Main(string[] args)
        {
            string thing = "true";
            bool isPossibleToConvert = thing.CanConvertToBoolean();

            Console.WriteLine($"result is {isPossibleToConvert}");

        }
    }
}
