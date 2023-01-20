/*  Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4
16, 4 -> кратно    */

int a = GetNumber();
int b = GetNumber(); 

int GetNumber()
{
Console.Write("Введите число:  ");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);
return number;
}

if (a % b == 0)
{
Console.WriteLine($"число {a} кратно числу {b}");
}
else
{
Console.WriteLine($"число {a} не кратно числу {b}, остаток {a % b}");
}