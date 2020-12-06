using System;

namespace Lesson3_String_and_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------
            //           Домашнее задание    
            //-----------------------------------

            ////Задание 1
            //int count = 0;
            //Console.WriteLine("Вводите значения: ");
            //while (true)
            //{
            //    int symbl = Console.Read();
            //    if (symbl == ' ')
            //        count++;
            //    else if (symbl == '.')
            //        break;
            //}
            //Console.WriteLine($"Количество пробелов = {count}");


            ////Задание 2
            //Console.WriteLine("Введите 6-ый номер билета: ");
            //string number = Console.ReadLine();
            //if (number.Length == 6)
            //{
            //    int first = (number[0] - '0') + (number[1] - '0') + (number[2] - '0');
            //    int last = (number[3] - '0') + (number[4] - '0') + (number[5] - '0');
            //    if (first == last)
            //        Console.WriteLine("Этот билет счастливый!");
            //    else
            //        Console.WriteLine("Этот билет НЕ счастливый!");
            //}
            //else
            //    Console.WriteLine("Вы ввели число не из 6 символов!!!");


            ////Задание 3
            //Console.WriteLine("Введите текст (лат.): ");
            //string text = Console.ReadLine();
            //string rText = string.Empty;
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] >= 'a' && text[0] <= 'z')
            //        rText += Convert.ToChar((text[i] - 32));
            //    else if (text[i] >= 'A' && text[i] <= 'Z')
            //        rText += Convert.ToChar(text[i] + 32);
            //    else
            //        rText += Convert.ToChar(text[i]);
            //}
            //Console.WriteLine($"Получившийся текст: \n{rText}");


            ////Задание 4
            //int begin = 3, end = 7;
            //for (int i = begin; i <= end; i++)
            //{
            //    for (int j = 0; j < begin; j++)
            //    {
            //        Console.Write($"{begin} ");
            //    }
            //    Console.WriteLine();
            //    begin++;
            //}


            ////Задание 5
            //string num,rNum = "";
            //Console.WriteLine("Введите число: ");
            //num = Console.ReadLine();
            //if (int.Parse(num) > 0)
            //{
            //    for (int i = num.Length - 1; i >= 0; i--)
            //    {
            //        rNum += num[i];
            //    }
            //    Console.WriteLine(rNum);
            //}
            //else
            //    Console.WriteLine("Вы ввели неправильное число!!!");



        }
    }
}
