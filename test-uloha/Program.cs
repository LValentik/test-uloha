using System;

namespace test_uloha
{
    class Program
    {
        static void Main(string[] args)
        {
            bool start = true;
            while (start == true)
            {
                Console.WriteLine();
                Console.Write("Zadejte číslo: ");
                string x = Console.ReadLine();
                if (x == "n")
                {
                    Console.WriteLine("Ukončuji program...");
                    start = false;
                }
                else
                {
                    int n = int.Parse(x);
                    int z = n % 2;
                    if (z > 0)
                    {
                        Console.WriteLine("Vaše číslo je liché");
                    }
                    else
                    {
                        Console.WriteLine("Vaše číslo je sudé");
                    }
                }



            }
            Console.ReadKey();









        }
    }
}
