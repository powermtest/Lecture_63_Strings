using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_63_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Ajem Debest ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim()); //usuwa spacje na koncu stringa
            Console.WriteLine("Trim: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("Imie: " +firstName );
            Console.WriteLine("Nazwisko: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("(prostsza metoda) Imie: " +names[0]);
            Console.WriteLine("(prostsza metoda) Nazwisko: " + names[1]);

            Console.WriteLine(fullName.Replace("Ajem", "I am"));

            if (string.IsNullOrWhiteSpace("")) //jak dziala obrona przed spacjami
            {
                Console.WriteLine("Nierawidlowe");
            }

            //konwersja stringow
            Console.WriteLine("----------------------------");

            Console.WriteLine("zaczynamy konwersje stringow");

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 25.78f;
            
            Console.WriteLine(price.ToString("C"));
            Console.WriteLine(price.ToString("C0"));







        }
    }
}
