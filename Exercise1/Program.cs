//This console asks the user for a number then counts backwards to 0.
Console.WriteLine("Please enter a number");
int userNum; 


//Ask the user for a number, verify it's a valid INT
if(int.TryParse(Console.ReadLine(), out userNum))
{
    Console.WriteLine("Counting down from {0}", userNum);
    
    //Call the function here
    Countdown(userNum);
}
else
{
    Console.WriteLine("Please enter a valid number");
}

//Define the function here

void Countdown(int num)
{
    for (int i = num; i >= 0 ; i--)
    {
        Console.WriteLine(i);
    }
}