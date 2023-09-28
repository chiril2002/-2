// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что остальных цифр нет.
// 645 -> 5
// 78 -> цифры цифры нет
// 32679 -> 6



Console.Write("Веди числа: ");
int Number = Convert.ToInt32(Console.ReadLine());
string NumberText = Convert.ToString(Number);
if (NumberText.Length > 2) {
  Console.WriteLine("третья цифра -> " + NumberText[2]);
}
else {
  Console.WriteLine("-> Наручных цифр нет");
}