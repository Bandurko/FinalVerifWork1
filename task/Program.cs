// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:

// [“Hello”, “2”, “world”, “:-)”] -> [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] -> [“-2”]
// [“Russia”, “Denmark”, “Kazan”] -> []

// Избавиться от "магического числа" 3  !!!


using System;
using static System.Console;

Clear();

Console.WriteLine("Введите массив строк через пробел");
string str = Console.ReadLine();
int ch = 3; // избавляемся от "магических чисел"

string[] array = str.Split(" ");
string[] result = FindResult(array, ch);
WriteLine();
Console.WriteLine($"[{String.Join(", ", array)}] -> [{String.Join(", ", FindResult(array, ch))}]");

string[] FindResult(string[] input, int ch) // Наполняет результирующий массив элементами
{
    string[] output = new string[GetCount(input, ch)];

    for(int i = 0, j = 0; i < input.Length; i++) {
        if(input[i].Length <= ch) {
            output[j] = input[i];
            j++;
        }
    }
    return output;
}

int GetCount(string[] input, int ch) // Находит размер результирующего массива
{
    int count = 0;
    foreach (string el in input)
    {
    count += el.Length <= ch ? 1 : 0;
    }
    return count;
}

