using System;

namespace Strategy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            double Number1;
            double Number2;

            while (true)
            {
                try
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.DarkYellow;

                    Console.Write("Number One ( Please Use / For Momayes ): ");

                    Number1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\nNumber Two ( Please Use / For Momayes ): ");

                    Number2 = Convert.ToDouble(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("---------------------------------------------------------------------");

                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                    Console.WriteLine("Sum = " + calculator.OperateCalculator(Number1, Number2, new Sum()));            // Polymorphism  ===> همچنین استراتژی پترن است چون داریم از بیرون کلاسمون (( یعنی کلاس کلکیولیتور )) بهش استراتژی یا عملیات مورد نظرمون رو پاس میدیم ===> Sum پاس دادیم

                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("---------------------------------------------------------------------");

                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                    Console.WriteLine("Mines = " + calculator.OperateCalculator(Number1, Number2, new Mines()));      // Polymorphism ===> همچنین استراتژی پترن است چون داریم از بیرون کلاسمون (( یعنی کلاس کلکیولیتور )) بهش استراتژی یا عملیات مورد نظرمون رو پاس میدیم ===> Mines پاس دادیم

                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("---------------------------------------------------------------------");

                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                    Console.WriteLine("Multiple = " + calculator.OperateCalculator(Number1, Number2, new Multiple()));      // Polymorphism ===> همچنین استراتژی پترن است چون داریم از بیرون کلاسمون (( یعنی کلاس کلکیولیتور )) بهش استراتژی یا عملیات مورد نظرمون رو پاس میدیم ===> Multiple پاس دادیم

                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("---------------------------------------------------------------------");

                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                    Console.WriteLine("Divide = " + calculator.OperateCalculator(Number1, Number2, new Divide()));      // Polymorphism ===> همچنین استراتژی پترن است چون داریم از بیرون کلاسمون (( یعنی کلاس کلکیولیتور )) بهش استراتژی یا عملیات مورد نظرمون رو پاس میدیم ===> Divide پاس دادیم

                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.WriteLine("\nPress Enter To Refresh Software ");
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("------------------------------------------");

                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    Console.WriteLine("\n----Erorr----Erorr----Erorr----Erorr----Erorr----");

                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.WriteLine("\nPress Enter To Refresh Software ");
                }

                Console.ReadKey();
            }
        }
    }
}
