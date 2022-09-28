using System;
using System.Text;

namespace task_2
{
    internal class Program
    {
        /*
         2. Пользователь с клавиатуры вводит некоторый текст. Приложение
           должно изменять регистр первой буквы каждого предложения на
           букву в верхнем регистре. Например, если пользователь ввёл: «today
           is a good day for walking. i will try to walk near the sea». Результат работы
           приложения: «Today is a good day for walking. I will try to walk near the sea».
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Введите арифметическое выражение (числа и операции через пробел): ");
            string? str = Console.ReadLine();
            //string str = "today is a good day for walking. i will try to walk near the sea.";

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(str[0].ToString().ToUpper());
            for (int i = 1; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]) && char.IsWhiteSpace(str[i - 1]) && ".!?".IndexOf(str[i - 2]) != -1)
                {
                    stringBuilder.Append(str[i].ToString().ToUpper());
                }
                else
                {
                    stringBuilder.Append(str[i]);
                }
            }
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}