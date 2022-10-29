/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Write("type the number:");
int a = int.Parse(Console.ReadLine()!);

int SumOFDigits(int number)
{
    int sum = 0;
  while(a > 0)
  {
    sum = sum + a % 10;
    a = a /10;
  }
    return sum;
}
Console.WriteLine(SumOFDigits(a));