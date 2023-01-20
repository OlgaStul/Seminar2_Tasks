/* Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

int GetRandomNumber()                                        // int GetRandomValue()
{                                                            // {
Random rnd = new Random();                                   // return new Random().Next(100, 1000);
int result = 0;                                              // }

result = rnd.Next(100, 1000);
return result;
}

int DeleteSecondDigitOfNumber(int number)                    // int DeleteSecondNumber(int number)     
{                                                            // {
int secondDigit = (number / 100) * 10 + (number % 10);       // return (number / 100) * 10 + (number % 10);
return secondDigit;                                          // }
}

int number = GetRandomNumber();                              // int number = GetRandomValue();
int number2 = DeleteSecondDigitOfNumber(number);             // int result = DeleteSecondNumber(number);

Console.WriteLine($"Было {number} - стало {number2}");       // Console.WriteLine($"Было {number}, стало {result}.");


