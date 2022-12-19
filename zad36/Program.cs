/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

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
int[] array = GetArray(4,-9,9);
PrintArray(array);
Console.WriteLine();

void Result(int[] arr)
{
    int count =0;
    for(int i=0; i<arr.Length; i++)
    {
        if (i%2!=0) count = count + arr[i];
    }
    Console.WriteLine(count);
}
Result(array);


