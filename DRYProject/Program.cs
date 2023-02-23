using System;

namespace DRYProject
{
    class Program
    {
        static void Main(string[] args)
        {
            DRY_Demo demo = new DRY_Demo();
            DRY_Demo_2 demo_2 = new DRY_Demo_2();

            Console.WriteLine("Original:");
            demo.LoginAsTeacher();
            demo.LoginAsStudent();

            Console.WriteLine("****************");
            Console.WriteLine("Refactored:");
            demo_2.LoginAsTeacher();
            demo_2.LoginAsStudent();
        }
    }
}