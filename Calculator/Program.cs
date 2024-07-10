
for (int i=0; i<100; i++)
{

    Console.WriteLine("Enter first nember:");
    var firstNumber = Console.ReadLine();
    int firstNumInt = Convert.ToInt32(firstNumber);


    Console.WriteLine("What operation you want to do?");
    var operaion = Console.ReadLine();

    Console.WriteLine("Enter second nember:");
    var secondNumber = Console.ReadLine();
    int secondNumInt = Convert.ToInt32(secondNumber);

    if (operaion == "+")
    {
        int result = firstNumInt + secondNumInt;
        Console.WriteLine($"Result :{result}");
    }
    else if (operaion == "-")
    {
        int result = firstNumInt - secondNumInt;
        Console.WriteLine($"Result :{result}");
    }
    else if (operaion == "*")
    {
        int result = firstNumInt * secondNumInt;
        Console.WriteLine($"Result :{result}");
    }
    else if (operaion == "/")
    {
        if (secondNumInt == 0)
        {
            Console.WriteLine("Second number is 0. Impossible action");
        }
        else
        {
            int result = firstNumInt / secondNumInt;
            Console.WriteLine($"Result :{result}");
        }
    }

    Console.WriteLine("Do you want one more time?y/n");
    var answer= Console.ReadLine();
    if (answer == "n")
    {
        Console.WriteLine("Bye!\n");
        i = 100;
    }
    else if (answer == "y")
    {
        Console.WriteLine("Allright GO!\n");
    }
    else { i = 100; }
}