﻿/* Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/


int getFromUserData (string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);

    return result;
}
int userNumber = getFromUserData ("Введите значение границы ряда");
PrintRange(userNumber);

void PrintRange(int N)
{
    if (N == 0)
    {
       
        return;
    }
    Console.Write(N +",");
    PrintRange(N-1);
    
}



