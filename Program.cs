// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
// Через строку решать нельзя.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// System.Console.WriteLine("Введите трехзначное число ");
// int num = Convert.ToInt32(Console.ReadLine());
// int x1 = num/10;
// int x2 = x1%10;
// System.Console.WriteLine($"число {x2}");


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Через строку решать нельзя.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// System.Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
//     if (num>100)
//     {
//         double razr = Math.Log10(num);
//         int i = 1;
//         while (i<razr-2)
//         {
//             num = num/10;
//             i++;
//         }
//         num = num%10;
//         System.Console.WriteLine($"третье число равно  {num}");
//     }
//     else
//             System.Console.WriteLine($"в числе {num} нет третьей цифры");


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите номер дня недели ");
int num = Convert.ToInt32(Console.ReadLine());
if (num>=1 && num<=7)
{
    if (num>5)
    {
        System.Console.WriteLine($"День недели номер {num} является выходным");
    }
    else 
    System.Console.WriteLine($"День недели номер {num} НЕ является выходным");
}
else 
    System.Console.WriteLine($"День недели номер {num} НЕ является днем недели");

