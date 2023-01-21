/* Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет  */

int a = GetNumber();
int b = GetNumber(); 

int GetNumber()
{
Console.Write("Введите число:  ");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);
return number;
} 

if (a == b * b || b == a * a)
{
Console.WriteLine($"Одно число является квадратом другого");
}
else
{
Console.WriteLine($"Одно число не является квадратом другого");
}