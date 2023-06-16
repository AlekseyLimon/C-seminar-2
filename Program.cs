// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int Show(string message)
// {
// Console.Write($"{message}");
// return Convert.ToInt32(Console.ReadLine());
// }

// int number = Show("Введите трехзначное число ");
// if ((number >=100) && (number <1000))
// {
// int midle = (number % 100 - number % 10) / 10;
// Console.WriteLine($"Вторая цифра числа {number} является {midle}");
// }
// else
// Console.WriteLine("Оно не трехзначное");






// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int Show(string message)
// {
// Console.Write($"{message}");
// return Convert.ToInt32(Console.ReadLine());
// }

// int number = Show("Введите число ");

// if ((number >= 100) && (number < 1000))
// {
//     int ThirdDigit = number % 10 ;
//     Console.WriteLine($"третьей цифрой числа {number} является {ThirdDigit}");
// }

// if ((number >= 1000) && (number < 10000))
// {
//     int ThirdDigit = (number %100 - number % 10) / 10 ;
//     Console.WriteLine($"третьей цифрой числа {number} является {ThirdDigit}");
// }
// if ((number >= 10000) && (number < 100000))
// {
//     int ThirdDigit = (number %1000 - number % 100) / 100 ;
//     Console.WriteLine($"третьей цифрой числа {number} является {ThirdDigit}");
// }
// if (number < 100)
//  {   
//     Console.WriteLine("Третьей цифры нет");
// }




//     Задача 15: Напишите программу, которая принимает на вход цифру, 
//     обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Show(string message)
{
Console.Write($"{message}");
return Convert.ToInt32(Console.ReadLine());
}

int number = Show("Введите цифру, означающую день недели ");
if ((number >= 6) && (number < 8))
{
Console.WriteLine($"День под номером {number} является выходным");
}
if ((number >= 1) && (number < 6))
{
Console.WriteLine($"День под номером {number} не является выходным");
}
if (number > 7)
{
Console.WriteLine("Нет такого дня");
}