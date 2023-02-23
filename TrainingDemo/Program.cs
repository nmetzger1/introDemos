using System;

namespace TrainingDemo
{
    class Program
    {
        static void Main(string[] args)
         {
            
            //Data Types
            DataTypesDemo dataTypes = new DataTypesDemo();
            dataTypes.PrintDataTypes();
            dataTypes.PrintArray();

            //If/Else Flows
            Console.WriteLine("Demo with 7");
            ControlFlows.IfElseDemo(7);
            Console.WriteLine("Demo with 3");
            ControlFlows.IfElseDemo(3);

            //Switch Statements
            ControlFlows.SwitchDemo("Chrome");
            ControlFlows.SwitchDemo("Duck Duck Go");

            //Loops
            //For Loop
            ControlFlows.OneToTen();
            //While Loop
            ControlFlows.ByTwos();
            //ForEach Loop
            ControlFlows.WriteList2();

            //Jump Statements
            ControlFlows.BreakLoop();
            ControlFlows.ReturnLoop();


            //Functions
            FunctionsDemo functions = new FunctionsDemo();
            Console.WriteLine("5 x 2 = " + functions.TimesTwo(5));
            functions.LogThis("LALALALALA");

            int number = functions.Addition(2, 6000);
            Console.WriteLine(number);

        }

    }
}
