using System;

namespace task_1
{
    internal class Program
    {
        /*
         1. Пользователь с клавиатуры вводит в строку арифметическое
           выражение. Приложение должно посчитать его результат.
           Необходимо поддерживать только две операции: «+» и «–».
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Введите арифметическое выражение (числа и операции через пробел): ");
            string? str = Console.ReadLine();
            //string str = "-3 + 32 + -2 - 5 + 11 + -4";

            string[] arrayOfString = str.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            double result = 0, num1 = 0;
            bool plus = true;
            for (int i = 0; i < arrayOfString.Length; i++)
            {
                if (double.TryParse(arrayOfString[i], out num1))
                {
                    if (plus)
                        result = result + num1;
                    else
                        result = result - num1;
                }
                else
                    plus = arrayOfString[i] == "+";
            }
            Console.WriteLine(result);
        }
    }
}