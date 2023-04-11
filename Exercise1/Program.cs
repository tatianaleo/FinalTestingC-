//Задайте значение N. Напишите программу, которая выведет все натуральные числа
//в промежутке от N до 1. Выполнить с помощью рекурсии.

int naturals(int n)
{
    if(n == 1) 
    {
    Console.Write("1");
    return 1; 
    }
    else 
    {
        Console.Write($"{n},");
        return naturals(n - 1);
    }
  }
naturals(5);



  