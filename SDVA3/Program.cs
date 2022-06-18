// See https://aka.ms/new-console-template for more information

// Declare variables and then initialize them to zero.
double num1 = 0; double num2 = 0; //allows decimals

Console.ForegroundColor = ConsoleColor.Cyan; //Changes text colour in command line

// Display title as the C# console calculator app.
Console.WriteLine("Hello and Welcome to Katie's Calculator!\r");
Console.WriteLine("------------------------\n");
Console.WriteLine("This calculator will take two numbers followed " +
    "by your chosen math operator and calculate the results for you!\r");
Console.WriteLine("------------------------\n");

// Ask the user to type the first number.
Console.WriteLine("Please type the first number of the equation, and then press Enter");
num1 = Convert.ToDouble(Console.ReadLine());//Double allows for the input and output of decimal numbers

// Ask the user to type the second number.
Console.WriteLine("Please type the second number of the equation, and then press Enter");
num2 = Convert.ToDouble(Console.ReadLine());

// Ask the user to choose a math operation.
Console.WriteLine("Choose an option from the following list:");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");
Console.WriteLine("\tr - Remainder");
Console.WriteLine("\tp - Power");

Console.Write("Please select your option? ");

// Switch statement to do the math and change the colours. (Each operator has a different background and foreground combination)
switch (Console.ReadLine()) //Reads what the user input and chooses the corresponding functionality
{
    case "a":
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
        break;
    case "s":
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Clear();
        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
        break;
    case "m":
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
        break;
    case "d":
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
        break;
    case "r":
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine($"Your result: {num1} % {num2} = " + (num1 % num2));
        break;
    case "p":
        Console.BackgroundColor = ConsoleColor.DarkMagenta;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
        Console.WriteLine($"Your result: {num1} to the power of {num2} = " + Math.Pow(num1, num2));
        break;

}

// Wait for the user to respond before closing.
Console.Write("Press any key to close the Calculator console app...");
Console.ReadKey(); //Closes the console


