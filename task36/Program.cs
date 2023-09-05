/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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
        newArray[i] = rand.Next(-20, 20);
    }
}
// Подсчитываем cумму элементов, стоящих на нечётных позициях
int FingNum(int[] newArray)
{
    int sum = 0;
    for (int i = 1; i < newArray.Length; i += 2)
    {
        sum += newArray[i];
    }
    return sum;
}
// Ввод размера массива
int size = InputNum("Введите размер массива: ");
// Вывод
int[] newArr = CreateArray(size);
FillArray(newArr);
PrintArray(newArr);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {FingNum(newArr)}");
