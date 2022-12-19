﻿/* Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

int[] GetArray(int size, int minValue, int maxValue) 
{
    int[] res = new int[size];
    for(int i=0; i<size; i++)
    {
        res[i] = new Random().Next(minValue,maxValue+1);
        // Console.Write($"{res[i]} ");
    }
    return res;
}

void PrintArray(int[] arr)
{
     for(int i=0; i<arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
int[] array = GetArray(5,100,999);
PrintArray(array);
Console.WriteLine();

void Result (int[] arr)
    {int count = 0;
    for(int i=0; i<arr.Length; i++)
    {
    if(arr[i]%2 ==0) count++;
    }
    Console.WriteLine(count);
    }
Result(array);