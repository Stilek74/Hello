using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Tutaj wpisz swoje imię: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Witaj, " + name);

                    Console.Write("Teraz podaj nam swój wiek: ");
                }
                int age;
                bool result = int.TryParse(Console.ReadLine(), out age);

                if (age > 17)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Brawo, możesz do nas dołączyć!");
                }
                else if (result == false)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Przykro nam, nie wprowadziłeś poprawnego wieku");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Przykro nam, nie możesz do nas dołączyć");
                }
                Console.ReadKey();
            }
        }
    }
}
