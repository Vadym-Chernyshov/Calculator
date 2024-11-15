namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            Console.WriteLine("Please enter your first number"); //перше число
            string strFirstValue = Console.ReadLine();

            Console.WriteLine("Please enter your first second number"); //друге число
            string strSecondValue = Console.ReadLine();

            //перевірка вводу користувача та ініціалізація числових змінних за допомогою TryParse
            //Знайшов за посиланням нижче
            //https://learn.microsoft.com/ru-ru/dotnet/api/system.int32.tryparse?view=net-8.0
            if (int.TryParse(strFirstValue, out int firstValue) && int.TryParse(strFirstValue, out int secondValue))
            {
                
            }
            else
            {
                Console.WriteLine("Incorrect input. Please try again");
            }
        }
    }
}
