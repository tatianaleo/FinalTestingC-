﻿//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
//элементов в промежутке от M до N. Выполнить с помощью рекурсии.
int sum(int n)
{
    if (n<0) return 0;
    else return n+sum(n-1);
    }
Console.Write(sum(50));