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
            ValueTypes();

            for (; ; )
            {
                Powitanie();
                Wiek();
                Settings();
            }
        }

        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("maxInt = " + maxInt);
            Console.WriteLine("minInt = " + minInt);
            Console.WriteLine("maxLong = " + maxLong);
            Console.WriteLine("minLong = " + minLong);
        }

        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

        private static void Wiek()
        {
            {

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
        }
        /// <summary>
        /// Wypisujemy powitanie użytkownika
        /// </summary>
        private static void Powitanie()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Tutaj wpisz swoje imię: ");
            string name = Console.ReadLine();
            Console.WriteLine("Witaj, " + name);
        }
    }
}
