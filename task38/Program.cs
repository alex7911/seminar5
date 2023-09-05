/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/
// Ввод в консоль
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
// Создание одномерного массива
double[] CreateArray(int size)
{
    return new double[size];
}
// Вывод в консоль массива
void PrintArray(double[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
}
// Заполнение массива случайными вещественными числами в заданном диапазоне
void FillArray(double[] newArray)
{
    Random rand = new Random();
    int max = 65, min = -25;
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = Math.Round(rand.NextDouble() * (max - min) + min, 2);
    }
}
// Подсчитываем разницу между максимальным и минимальным значением
double FingNum(double[] newArray)
{
    double maxElement = double.MinValue;
    double minElement = double.MaxValue;

    for (int i = 0; i < newArray.Length; i++)
    {
        if (maxElement < newArray[i])
        {
            maxElement = newArray[i];
        }
        if (minElement > newArray[i])
        {
            minElement = newArray[i];
        }
    }
    return maxElement - minElement; 
}
// Ввод размера массива
int size = InputNum("Введите размер массива: ");
// Вывод
double[] newArr = CreateArray(size);
FillArray(newArr);
PrintArray(newArr);
Console.WriteLine($"Разница между максимальным и минимальным значением: {FingNum(newArr)}");
