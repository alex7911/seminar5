/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
// Ввод в консоль
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
// Создание одномерного массива
int[] CreateArray(int size)
{
    return new int[size];
}
// Вывод в консоль массива
void PrintArray(int[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
}
// Заполнение массива случайными числами в заданном диапазоне
void FillArray(int[] newArray)
{
    Random rand = new Random();
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rand.Next(100, 501);
    }
}
// Подсчитываем колличество чётных элементов в массиве
int FingNum(int[] newArray)
{
    int count = 0;
    for (int i = 0; i < newArray.Length; i++)
    {
        if (newArray[i] % 2 == 0)
        {
            count++;
        }

    }
    return count;
}
// Ввод размера массива
int size = InputNum("Введите размер массива: ");
// Вывод
int[] newArr = CreateArray(size);
FillArray(newArr);
PrintArray(newArr);
Console.WriteLine($"Чётных чисел в массиве: {FingNum(newArr)}");
