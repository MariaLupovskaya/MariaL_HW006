﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите числа через запятую");
string str = Console.ReadLine();
int[] array = Array.ConvertAll(str.Split(','), int.Parse);
int result = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        result++;
    }
}
 
Console.WriteLine($"Кол-во чисел больше 0 равно {result}");