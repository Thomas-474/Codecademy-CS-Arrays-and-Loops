using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void EL() => Console.WriteLine("");
        static void Border() => Console.WriteLine($"--------------------------------------------------------------------");

        static void Main(string[] args)
        {
            // While Loop
            Console.WriteLine("While Loop:");
            EL();
            WhileLoop();
            EL();
            Border();

            // Do...While Loop
            Console.WriteLine("Do...While Loop:");
            EL();
            DoWhileLoop();
            EL();
            Border();

            // For Loop
            Console.WriteLine("For Loop:");
            EL();
            ForLoop();
            EL();
            Border();

            // For Each Loop
            Console.WriteLine("For Each Loop:");
            EL();
            ForEachLoop();
            EL();
            Border();

            // Comparing Loops
            Console.WriteLine("Comparing Loops:");
            EL();
            ComparingLoops();
            EL();
            Border();

            // Jump Statements
            Console.WriteLine("Jump Statements:");
            EL();
            JumpStatements();


            Console.ReadKey();
        }

        // While Loop
        static void WhileLoop()
        {
            int emails = 20;

            while (emails > 0)
            {
                Console.WriteLine($"There are {emails} emails. Deleting 1 email now.");
                emails -= 1;
            }

            Console.WriteLine("INBOX ZERO ACHIEVED!");
        }

        // Do...While Loop
        static void DoWhileLoop()
        {
            bool buttonClick = true;

            do
            {Console.WriteLine("BLARRRRRRRRR");}
            while (!buttonClick);

            Console.WriteLine("Time for a five minute break.");
        }

        // For Loop
        static void ForLoop()
        {
            for (int i = 1; i < 17; i++)
            {CreateTemplate(i);}
        }
        static void CreateTemplate(int week)
        {
            Console.WriteLine($"Week {week}");
            Console.WriteLine("Announcements: \n \n \n ");
            Console.WriteLine("Report Backs: \n \n \n");
            Console.WriteLine("Discussion Items: \n \n \n");
        }

        // For Each Loop
        static void ForEachLoop()
        {
            string[] todo = {"respond to email", "make wireframe", "program feature", "fix bugs"};
      
            foreach (string item in todo)
            {CreateTodoItem(item);}
        }
        static void CreateTodoItem(string item)
        {Console.WriteLine($"[] {item}");}

        // Comparing Loops
        static void ComparingLoops()
        {
            string[] websites = { "twitter", "facebook", "gmail" };
      
            foreach (string site in websites)
            {CreateSite(site);}
        }
        static void CreateSite(string site)
        {Console.WriteLine(site);}

        // Jump Statements
        static void JumpStatements()
        {
            bool buttonClick = true;
            int timesRinged = 0;

            do
            {
                Console.WriteLine("BLARRRRR");
                timesRinged++;
                if (timesRinged == 3)
                {break;}
            }
            while(!buttonClick);
        }

    }
}
