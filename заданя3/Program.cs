﻿//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и, наконец, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введи цифру, обозначающую день недели: ");
int Number = Convert.ToInt32(Console.ReadLine());

void ValidateWeekday (int Number)
 {
  if (Number == 6 || Number == 7) 
  {
  Console.WriteLine("(этот день выходной) -> да");
  }
  if (Number < 1 || Number > 7) 
  {
    Console.WriteLine("это вообще не день недели");
  }
  else Console.WriteLine("(этот день не выходной) -> нет");
}

