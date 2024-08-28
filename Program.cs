// NUMBERS

// int age = 30;
// System.Console.Write(age);
// by default the number is int, so we need to add L to make it long
// long bigNumber = 90000L;
// Console.Write(bigNumber);

// double negativeNumber = -3.14D;

// by default a decimal number is double, so we need to add F to make it float
// float smallNumber = 3.14F;
// System.Console.Write(smallNumber);

// decimal money = 3.14M;

// System.Console.Write("long max: " + long.MaxValue);
// System.Console.Write("long min: " + long.MinValue);

// System.Console.Write("double max: " + double.MaxValue);
// System.Console.Write("double min: " + double.MinValue);

// System.Console.Write("decimal max: " + decimal.MaxValue);
// System.Console.Write("decimal min: " + decimal.MinValue);

// System.Console.Write("float max: " + float.MaxValue);
// System.Console.Write("float min: " + float.MinValue);

// STRINGS
// string name = "John"; // '' is for char
// char letter = 'A';

// CONVERTING STRINGS TO NUMBERS
// String textAge = "30";
// int age = int.Parse(textAge);
// int age = Convert.ToInt32(textAge);
// long age = Convert.ToInt64(textAge);
// double age = Convert.ToDouble(textAge);
// float age = Convert.ToSingle(textAge);
// decimal age = Convert.ToDecimal(textAge);

// CONST
// const int vat = 20;
// const double percentVat = vat / 100D;
// int balance = 1000;
// Console.Write(balance * percentVat);

/* EXERCISE 1
1. Create and initialize two ints
2. Make a vaiable to work out the remainder
3. Output the remainder to the screen
4. Chang the first int varaibe to another number
5. and recalculate the remainder
6. output the new remainder to the screen
*/

// int num1 = 11;
// int num2 = 3;
// var remainder = num1 % num2;
// Console.Write(remainder);

// INPUT OUTPUT
// Console.Write("Enter your name: ");
// string name = Console.ReadLine() ?? string.Empty;

// Console.Write("Enter your age: ");
// string ageInput = Console.ReadLine() ?? string.Empty;
// int age = string.IsNullOrEmpty(ageInput) ? 0 : Convert.ToInt32(ageInput);

// Console.Write($"Hello {name}! ");

// if (age > 0 && age < 18)
// {
//     Console.Write("You are a minor.");
// }
// else if (age >= 18 && age < 65)
// {
//     Console.Write("You are an adult.");
// }
// else if (age >= 65 && age < 120)
// {
//     Console.Write("You are a senior.");
// }
// else
// {
//     Console.Write("Invalid age.");
// }

// SWITCH STATEMENTS
// Console.Write("Enter a day of the week: ");
// string answer = Console.ReadLine() ?? string.Empty;

// switch(answer)
// {
//     case "Monday":
//         Console.Write("You entered Monday.");
//         break;
//     case "Tuesday":
//         Console.Write("You entered Tuesday.");
//         break;
//     case "Wednesday":
//         Console.Write("You entered Wednesday.");
//         break;
//     case "Thursday":
//         Console.Write("You entered Thursday.");
//         break;
//     case "Friday":
//         Console.Write("You entered Friday.");
//         break;
//     case "Saturday":
//         Console.Write("You entered Saturday.");
//         break;
//     case "Sunday":
//         Console.Write("You entered Sunday.");
//         break;
//     default:
//         Console.Write("Invalid day.");
//         break;
// }

// NUMERIC FORMATTING

// double value = 12345.6789D;
// Console.WriteLine(string.Format("{0} {1}", value, 33)); 
// Console.WriteLine(string.Format("{0:0.00}", value)); 

// double money = 10D / 3D;
// Console.WriteLine(money.ToString("C")); // currency
// Console.WriteLine(money.ToString("C0")); // currency
// Console.WriteLine(money.ToString("C1")); // currency
// Console.WriteLine(money.ToString("C2")); // currency

// TRY PARSE

// bool success = true;

// while (success)
// {
//     Console.Write("Enter a number: ");
//     string input = Console.ReadLine() ?? string.Empty;

//     if (int.TryParse(input, out int number))
//     {
//         success = false;
//         Console.WriteLine("You entered: " + number) ;
//     }
//     else
//     {
//         Console.WriteLine("Invalid number.");
//     }
// }

// EXERCISE 2

/*
Ask the user to enter a number for a table
Write a for loop to print the table of the number
*/

// bool success = true;

// while (success)
// {
//     Console.Write("Enter a number: ");
//     string input = Console.ReadLine() ?? string.Empty;

//     if (int.TryParse(input, out int number))
//     {
//         success = false;
//         for (int i = 1; i <= 12; i++)
//         {
//             Console.WriteLine($"{number} x {i} = {number * i}");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Invalid number.");
//     }
// }

// FIZZ BUZZ
/*
Create a for loop that prints the numbers from 1 to 100
If the number is divisible by 3, print Fizz
If the number is divisible by 5, print Buzz
If the number is divisible by 3 and 5, print FizzBuzz
*/

for (int i = 1; i <= 20; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}