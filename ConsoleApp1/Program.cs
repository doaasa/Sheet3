using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("Enter a number");
                string input = Console.ReadLine();
                int number;
                bool resultOFnumb = int.TryParse(input, out number);
                if (resultOFnumb)
                {
                    int fac = 1;
                    for (int i = 1; i <= number; i++)
                    {
                        fac = fac * i;
                    }
                    Console.Write(number + "!" + " = " + fac);
                    break;
                }
                Console.WriteLine("INVALID Enter number");
            }
           
        }
    }
}
