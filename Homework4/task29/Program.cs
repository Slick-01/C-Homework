// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

PrintArray(GetRandomArray(8));

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
        System.Console.WriteLine(j);
    }
}
