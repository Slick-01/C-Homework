// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int[] arr = GetRandomArray(10);
PrintArray(arr);
System.Console.WriteLine(GetMin(arr));
System.Console.WriteLine(GetMax(arr));

int GetMin(int[] array)
{
   int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}

int GetMax(int[] array)
{
   
   int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
       if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

int[] GetRandomArray(int length){
    int[] result = new int[length];

    for(int i = 0; i < length; i++){
        result[i] = new Random().Next(0, 100);
    }
    return result;
}

void PrintArray(int[] arr)
{
    foreach (int j in arr)
    {
        Console.Write(j + " ");
    }
    System.Console.WriteLine();
}

