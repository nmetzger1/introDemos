using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRYProject
{
    internal class DRY_Demo_2
    {
        public void LoginAsStudent()
        {
            Selenium2.Login("testStudent", "testpassword");

            Selenium2.GoTo("Student Dashboard");
        }

        public void LoginAsTeacher()
        {
            Selenium2.Login("testTeacher", "testpassword");
            Selenium2.GoTo("Teacher Dashboard");
        }

    }

    internal class Selenium2
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

        public static void Login(string username, string password)
        {
            Selenium.SendKeys(username);
            Selenium.SendKeys(password);
            Selenium.ClickButton("login");
        }
    }
}
