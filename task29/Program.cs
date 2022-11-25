// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.WriteLine("Введите значение массива: ");
int numArr = Convert.ToInt32(Console.ReadLine());
int[] array = new int[numArr];
Console.WriteLine("Массив создан: ");
var arr = FillArray(numArr);
PrintArray(arr);

int[] FillArray(int length)
{
    int[] result = new int[length];
    for(int i =0; i < result.Length; i++)
    {
        result[i] = new Random().Next(0, 100);
    }
    return result;
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}

