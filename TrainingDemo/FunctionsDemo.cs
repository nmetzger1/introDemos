using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingDemo
{
    public class FunctionsDemo
    {
        public int TimesTwo(int number)
        {
            return number * 2;
        }

        public void LogThis(string text)
        {
            Console.WriteLine(text);
        }

        public int Addition(int num1, int num2)
        {
            int sum = num1+ num2;

            if(sum > 1000)
            {
                Console.WriteLine("That is a big number!");
            }

            return sum;
        }
        
    }
}
