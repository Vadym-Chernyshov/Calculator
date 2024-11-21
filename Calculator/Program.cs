namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            Console.WriteLine("Please enter your first number"); //перше число
            string strFirstValue = Console.ReadLine();

            Console.WriteLine("Please enter your second number"); //друге число
            string strSecondValue = Console.ReadLine();

            try
            {
                decimal resultF = 0; //ініціалізація результату

                //конвертація вводу користувача
                decimal firstValueInTry = Convert.ToDecimal(strFirstValue);
                decimal secondValueInTry = Convert.ToDecimal(strSecondValue);

                Console.WriteLine("Choose a math operation +, -, * or /");
                string operation = Console.ReadLine(); //ввід математичної операції

                switch (operation)
                {
                    case "+":
                        resultF = firstValueInTry + secondValueInTry;                        
                        break;
                    case "-":
                        resultF = firstValueInTry - secondValueInTry;
                        break;
                    case "*":
                        resultF = firstValueInTry * secondValueInTry;
                        break;
                    case "/":                                             
                        resultF = firstValueInTry / secondValueInTry;                
                        break;
                     default:
                        Console.WriteLine("Упс...Неправильно введена операція");
                        break;      
                }
                Console.WriteLine(resultF);
            }
            catch(FormatException ex) //перевірка формату
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ймовірно неправильно введені числа, або вони завеликі. Спробуйте знову");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ділити на нуль не можна");
            }
            catch(Exception ex) //інші помилки
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Упс...Щось трапилось");
            }

            //минулий код

            ////перевірка вводу користувача та ініціалізація числових змінних за допомогою TryParse
            ////Знайшов за посиланням нижче
            ////https://learn.microsoft.com/ru-ru/dotnet/api/system.int32.tryparse?view=net-8.0
            //if (int.TryParse(strFirstValue, out int firstValue) && int.TryParse(strSecondValue, out int secondValue))
            //{
            //    Console.WriteLine("Choose a math operation +, -, * or /");
            //    string operation = Console.ReadLine(); //ввід математичної операції
            //    if (operation == "/" && secondValue == 0) //операція перевірки ділення на нуль
            //    {
            //        Console.WriteLine("You cannot divide by zero");
            //    }
            //    else
            //    {
            //        string resultOfOperetion = operation switch
            //        {
            //            //конвертація числовго значення в рядок
            //            //https://learn.microsoft.com/ru-ru/dotnet/api/system.convert.tostring?view=net-8.0#system-convert-tostring(system-int32)
            //            "+" => Convert.ToString(firstValue + secondValue),
            //            "-" => Convert.ToString(firstValue - secondValue),
            //            "*" => Convert.ToString(firstValue * secondValue),
            //            "/" => Convert.ToString((float)firstValue / secondValue), //можуть бути нецілі, краще float
            //            _ => "Incorect operation. Please try again"
            //        };
            //        Console.WriteLine(resultOfOperetion);
            //    }      
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect input. Please try again");
            //}
        }
    }
}
