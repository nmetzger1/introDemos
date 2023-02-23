using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingDemo
{
    public class DataTypesDemo
    {
        static int Integer = 42;
        static decimal Decimal = 42.0m;
        static string String = "Forty Two";
        static Boolean Boolean = true;        

        public void PrintDataTypes()
        {
            Console.WriteLine("Integer: " + Integer);
            Console.WriteLine("Decimal: " + Decimal);
            Console.WriteLine("Decimal: \"" + String + '"');
            Console.WriteLine("Boolean: " + Boolean);
        }

        public void PrintArray()
        {
            int[] ints = { 1, 2, 3 };

            Console.WriteLine(ints);

            Console.Write("Array loop: ");

            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write(ints[i] + " ");
            }
        }
        
    }
}
