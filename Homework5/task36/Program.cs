// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] arr = GetRandomArray(10);
PrintArray(arr);
System.Console.WriteLine(GetEvenNumber(arr));

int GetEvenNumber(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
            sum += arr[i];
    }
    return sum;
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
