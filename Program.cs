using System;

namespace Temps
{
    class Program
    {
        static void Main(string[] args)
        {
            int tmp;
            Console.Write("\n\n");
            Console.Write("Display a temperature in farenheit and return a suitable message:\n");

            Console.Write("Input days temperature : ");
            tmp = Convert.ToInt32(Console.ReadLine());
            if (tmp < 0)
                Console.Write("Freezing weather.\n");
            else if (tmp < 32)
                Console.Write("Very cold weather.\n");
            else if (tmp < 45)
                Console.Write("Cold weather.\n");
            else if (tmp > 60)
                Console.Write("Normal in temp.\n");
            else if (tmp > 80)
                Console.Write("Its Hot.\n");
            else
                Console.Write("Its very hot.\n");
            
            
            Console.Writeline("This is a basic Console Writeline command, Howdy dorks!");
            
            Console.Writeline("Hi.");
            Console.WriteLine("Dorks");
            
            

        }
    }
}
