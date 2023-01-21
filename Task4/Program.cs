/* Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
7 и 23.

14 -> нет
46 -> нет
161 -> да   */

int a = GetNumber(); 

int GetNumber()
{
Console.Write("Введите число:  ");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);
return number;
} 

if (a % 7 == 0 && a % 23 == 0)
{
    Console.WriteLine($"число {a} кратно одновременно 7 и 23");
}
else
{
    Console.WriteLine($"число {a} не кратно одновременно 7 и 23");
}