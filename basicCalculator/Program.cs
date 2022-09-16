int i = 0;
while (i <= 10)
{

    Console.WriteLine("This is a calculator: ");
    Console.WriteLine("Choose one of the choices from 1-4.");
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Subtract");
    Console.WriteLine("3. Multiply");
    Console.WriteLine("4. Divide");

    int choice = int.Parse(Console.ReadLine());
    int firstNum, secondNum, result;

    if (choice == 1)
    {
        Console.WriteLine("Enter 1st number: ");
        firstNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter 2nd number: ");
        secondNum = int.Parse(Console.ReadLine());

        result = firstNum + secondNum;
        Console.WriteLine($"{firstNum} + {secondNum} = {result}");
    }

    else if (choice == 2)
    {
        Console.WriteLine("Enter 1st number: ");
        firstNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter 2nd number: ");
        secondNum = int.Parse(Console.ReadLine());

        result = firstNum - secondNum;
        Console.WriteLine($"{firstNum} - {secondNum} = {result}");
    }
    else if (choice == 3)
    {
        Console.WriteLine("Enter 1st number: ");
        firstNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter 2nd number: ");
        secondNum = int.Parse(Console.ReadLine());

        result = firstNum * secondNum;
        Console.WriteLine($"{firstNum} * {secondNum} = {result}");
    }
    else if (choice == 4)
    {
        Console.WriteLine("Enter 1st number: ");
        firstNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter 2nd number: ");
        secondNum = int.Parse(Console.ReadLine());

        result = firstNum / secondNum;
        Console.WriteLine($"{firstNum} / {secondNum} = {result} (integer)");
    }
    else
    {
        Console.WriteLine("Invalid choice. Choose again.");
    }
    i++;
}

