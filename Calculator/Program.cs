﻿namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            Console.WriteLine("Please enter your first number"); //перше число
            string strFirstValue = Console.ReadLine();

            Console.WriteLine("Please enter your second number"); //друге число
            string strSecondValue = Console.ReadLine();

            //перевірка вводу користувача та ініціалізація числових змінних за допомогою TryParse
            //Знайшов за посиланням нижче
            //https://learn.microsoft.com/ru-ru/dotnet/api/system.int32.tryparse?view=net-8.0
            if (int.TryParse(strFirstValue, out int firstValue) && int.TryParse(strSecondValue, out int secondValue))
            {
                Console.WriteLine("Choose a math operation +, -, * or /");
                string operation = Console.ReadLine(); //ввід математичної операції

                string resultOfOperetion = operation switch
                {
                    //конвертація числовго значення в рядок
                    //https://learn.microsoft.com/ru-ru/dotnet/api/system.convert.tostring?view=net-8.0#system-convert-tostring(system-int32)
                    "+" => Convert.ToString(firstValue + secondValue),
                    "-" => Convert.ToString(firstValue - secondValue),
                    "*" => Convert.ToString(firstValue * secondValue),
                    "/" => Convert.ToString((float)firstValue / secondValue), //можуть бути нецілі, краще float
                      _ => "Incorect operation. Please try again" 
                };
                Console.WriteLine(resultOfOperetion);
            }
            else
            {
                Console.WriteLine("Incorrect input. Please try again");
            }
        }
    }
}
