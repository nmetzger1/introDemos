using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TrainingDemo
{
    public class ControlFlows
    {
        public static void IfElseDemo(int number)
        {
            if (number < 5)
            {
                Console.WriteLine("Your number is less than 5.");
            }
            else
            {
                Console.WriteLine("Your number is greater than or equal to 5.");
            }
        }

        public static void SwitchDemo(string browser)
        {
            switch (browser.ToLower())
            {
                case "chrome":
                    Console.WriteLine("You entered Chrome");
                    break;
                case "firefox":
                    Console.WriteLine("You entered Firefox");
                    break;
                default:
                    Console.WriteLine("The browser you have entered is not supported");
                    break; 

            }
        }

        public static void OneToTen()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void ByTwos()
        {
            int number = 0;
            
            while(number <= 20)
            {
                Console.WriteLine(number);
                number = number + 2;
            }

            Console.WriteLine("Done!");
        }

        public static void WriteList()
        {
            string[] actors = { "William Hartnell", "Patrick Troughton", "Jon Pertwee",
                    "Tom Baker", "Peter Davison", "Colin Baker", "Sylvester McCoy",
                    "Paul McGann", "Christopher Eccleston", "David Tennant",
                    "Matt Smith", "Peter Capaldi", "Jodie Whittaker" };

            Console.WriteLine("Here is a list of actors that have played 'The Doctor':");

            foreach (var name in actors)
            {
                Console.WriteLine(name);                
            }

        }

        public static void WriteList2()
        {
            string[] actors = { "William Hartnell", "Patrick Troughton", "Jon Pertwee",
                    "Tom Baker", "Peter Davison", "Colin Baker", "Sylvester McCoy",
                    "Paul McGann", "Christopher Eccleston", "David Tennant",
                    "Matt Smith", "Peter Capaldi", "Jodie Whittaker" };

            Console.WriteLine("Here is a list of actors that have played 'The Doctor':");

            for (int i = 0; i < actors.Length; i++)
            {
                Console.WriteLine(actors[i]);
            }

        }

        public static void BreakLoop()
        {
            int number = 0;

            while(number <= 20) { 
                Console.WriteLine(number);
                number++;

                if(number == 7)
                {
                    Console.WriteLine("Lucky number 7!");
                    break;
                }
            }

            Console.WriteLine("Done!");
        }

        public static void ReturnLoop()
        {
            int number = 0;

            while (number <= 20)
            {
                Console.WriteLine(number);
                number++;

                if (number == 7)
                {
                    Console.WriteLine("Lucky number 7!");
                    return;
                }
            }

            Console.WriteLine("Done!");
        }

    }
}
