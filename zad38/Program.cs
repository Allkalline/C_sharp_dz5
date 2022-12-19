/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

double[] GetArray() 
{
    double[] res = new double[5];
    for(int i=0; i<res.Length; i++)
    {
        res[i] = new Random().NextDouble();
        // Console.Write($"{res[i]} ");
    }
    return res;
}

void PrintArray(double[] arr)
{
     for(int i=0; i<arr.Length; i++)
    {
        Console.Write($"{Math.Round(arr[i], 2)} ");
    }
}
double[] array = GetArray();
PrintArray(array);
Console.WriteLine();

void Result(double[] arr)
{
    double max = arr[0];
    double min = arr[0];

    for(int i=0; i<arr.Length; i++)
    {
        if (max<arr[i]) 
        {
            max=arr[i];
        }
        else if (min>arr[i]) min=arr[i];

    }
       double X = max - min; 
     Console.WriteLine (Math.Round(X,2));
}

Result(array);

