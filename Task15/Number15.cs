/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите цифру, обозначающую день недели: ");
int NumberOfTheDay = Convert.ToInt32(Console.ReadLine());

void CheckDayOfTheWeek (int NumberOfTheDay) 
{
  if (NumberOfTheDay == 6 || NumberOfTheDay == 7) 
  {
  Console.WriteLine("Выходной");
  }
  else 
  if (NumberOfTheDay < 1 || NumberOfTheDay > 7) 
  {
    Console.WriteLine("Такого номера дня недели нет");
  }
  else 
  Console.WriteLine("Не выходной");
}

CheckDayOfTheWeek(NumberOfTheDay);