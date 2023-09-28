// Задача 10: Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введи трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
  
if (number<100 || number >=1000)
{
    Console.WriteLine("вы ввели не трехзначное чило " );
    return;
}
Console.WriteLine($"введенное число '{number}'" );
int secondRank = number / 10 %10;
Console.WriteLine ($"вторая цифра '{secondRank}'");

