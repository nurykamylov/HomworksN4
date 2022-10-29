/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Write("type the number:");
int a = int.Parse(Console.ReadLine()!);

Console.Write("type the degree:");
int b = int.Parse(Console.ReadLine()!);

int DegreeToB(int a, int b)
{
   int c = a;
   for (int i = 1; i < b; i++ )
   {
        c = c * a;
   }
   return c;
}
 int c = DegreeToB(a,b);
 Console.WriteLine(c);