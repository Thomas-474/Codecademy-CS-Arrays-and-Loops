using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void EL() => Console.WriteLine("");
        static void Border() => Console.WriteLine($"----------------------------------------------------");

        static void Main(string[] args)
        {
            // Building Arrays
            Console.WriteLine("Building Arrays:");
            EL();
            BuildingArrays();
            EL();
            Border();

            // Array Length
            Console.WriteLine("Array Length:");
            EL();
            ArrayLength();
            EL();
            Border();

            // Accessing Array Items
            Console.WriteLine("Accessing Array Items:");
            EL();
            AccessingArrayItems();
            EL();
            Border();

            // Editing Arrays
            Console.WriteLine("Editing Arrays:");
            EL();
            EditingArrays();
            EL();
            Border();

            // Built-In Methods
            Console.WriteLine("Built-In Methods:");
            EL();
            BuiltInMethods();
            EL();
            Border();

            // Documentation Hunt
            Console.WriteLine("Documentation Hunt:");
            EL();
            DocumentationHunt();


            Console.ReadKey();
        }

        // Building Arrays
        static void BuildingArrays()
        {
            string[] summerStrut;
            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "The Numbers", "Los Angeles" };
            int[] ratings = { 1, 2, 3, 4, 5 };

            foreach (string song in summerStrut)
            {
                Console.WriteLine(song);
            }
        }

        // Array Length
        static void ArrayLength()
        {
            string[] summerStrut;
            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

            if (summerStrut.Length == 8)
            {
                Console.WriteLine("Summer Strut playlist is ready to go!");
            }
            else if (summerStrut.Length > 8)
            {
                Console.WriteLine("Too many songs!");
            }
            else
            {
                Console.WriteLine("Add some songs!");
            }
        }

        // Accessing Array Items
        static void AccessingArrayItems()
        {
            string[] summerStrut;
            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };
            int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };

            Console.WriteLine($"You rated the song, {summerStrut[1]}, {ratings[1]} stars.");
        }

        // Editing Arrays
        static void EditingArrays()
        {
            string[] summerStrut;
            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };
            int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };

            summerStrut[7] = "I Like It";
            Console.WriteLine(summerStrut[7]);

            ratings[7] = 2;
            Console.WriteLine(ratings[7]);
        }

        // Built-In Methods
        static void BuiltInMethods()
        {
            string[] summerStrut;
            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };
            int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };

            int first3Star = Array.IndexOf(ratings, 3);
            Console.WriteLine($"Song number {first3Star + 1} is rated three stars.");

            string firstOver10Char = Array.Find(summerStrut, name => name.Length > 10);
            Console.WriteLine($"The first song that has more than 10 characters in the title is {firstOver10Char}.");

            Array.Sort(summerStrut);
            Console.WriteLine(summerStrut[0] + " & " + summerStrut[7]);
        }

        // Documentation Hunt
        static void DocumentationHunt()
        {
            string[] summerStrut;
            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };
            int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };

            // Creates empty array with space for 8 strings
            string[] summerStrutCopy = new string[8];

            // Copies summerStrut array and pastes it into summerStrutCopy
            Array.Copy(summerStrut, summerStrutCopy, 8);
            Console.WriteLine(summerStrutCopy[0]);

            Array.Reverse(summerStrut);
            Console.WriteLine(summerStrut[0]);
            Console.WriteLine(summerStrut[7]);

            Array.Clear(ratings, 0, 7);
            Console.WriteLine(ratings[0]);
        }

    }
}
