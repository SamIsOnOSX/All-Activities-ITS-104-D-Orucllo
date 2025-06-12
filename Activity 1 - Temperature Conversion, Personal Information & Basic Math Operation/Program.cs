using System;
//Sir Ako rang gi usa tanan kay para ma run nimo... Number 1, 2, 3 nani siya (Func1, Func2, Func3 respectively)
namespace MyNamespace
{
    class Program
    {
        static void Func1()
        {
            Console.WriteLine("Input temperature in Celsius");
            string? input = Console.ReadLine();

            if (float.TryParse(input, out float celsius))
            {
                float fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine("For that input, the temperature in Fahrenheit is:" + fahrenheit + " degrees.");
            }
            else
            {
                Console.WriteLine("Oyyy dili mao");
            }
        }

        static void Func2()
        {
            Console.WriteLine("Give me your personal information, name first!");
            string? name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name cannot be empty.");
                return;
            }

            Console.WriteLine("You are: " + name + " now you your age!");

            string? age = Console.ReadLine();
            if (string.IsNullOrEmpty(age))
            {
                Console.WriteLine("Age cannot be empty.");
                return;
            }

            Console.WriteLine("You are " + age + " years old! when what is your fav colour?");

            string? Fav_Color = Console.ReadLine();
            if (string.IsNullOrEmpty(Fav_Color))
            {
                Console.WriteLine("Favorite color cannot be empty.");
                return;
            }

            Console.WriteLine("Damn... I also like " + Fav_Color + " Sheesh");
        }

        static void Func3()
        {
            Console.WriteLine("Skibidi Calculator");
            Console.WriteLine("Enter the first number (if you are sigma):");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Invalid number.");
                return;
            }

            Console.WriteLine("Enter an operator (+, -, *, /): (Minus is an opp)");
            string? op = Console.ReadLine();
            if (string.IsNullOrEmpty(op))
            {
                Console.WriteLine("Operator cannot be empty.");
                return;
            }

            Console.WriteLine("Enter the second number:(to complete the skibidi transformatio.)");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Invalid number.");
                return;
            }

            double result = 0;

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Onsa bai?");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Onsa?");
                    return;
            }

            Console.WriteLine("The result is: " + result);
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose a function to call:");
                Console.WriteLine("1. Function 1");
                Console.WriteLine("2. Function 2");
                Console.WriteLine("3. Function 3");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                string? input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Func1();
                        break;
                    case "2":
                        Func2();
                        break;
                    case "3":
                        Func3();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}