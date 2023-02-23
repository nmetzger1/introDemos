using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRYProject
{
    internal class DRY_Demo
    {
        public void LoginAsStudent()
        {
            Selenium.SendKeys("testStudent");
            Selenium.SendKeys("testpassword");
            Selenium.ClickButton("login");

            Selenium.GoTo("Student Dashboard");
        }

        public void LoginAsTeacher()
        {
            Selenium.SendKeys("testTeacher");
            Selenium.SendKeys("testpassword");
            Selenium.ClickButton("login");

            Selenium.GoTo("Teacher Dashboard");
        }

    }

    internal class Selenium
    {
        public static void SendKeys(string text)
        {
            Console.WriteLine("typing text: " + text);
        }

        public static void ClickButton(string button)
        {
            Console.WriteLine("clicking button: " + button);
        }

        public static void GoTo(string location)
        {
            Console.WriteLine("Going to: " + location);
        }

        public int Addition(int num1, int num2)
        {
            int sum = num1 + num2;

            if(sum > 1000)
            {
                Console.WriteLine("That is a big number!");
            }

            return sum;
        }
    }

    
}
