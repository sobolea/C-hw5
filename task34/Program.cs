#pragma warning disable
// Задача 34: 
//Задайте массив заполненный случайными положительными трёхзначными 
//числами. Напишите программу, которая покажет количество 
//чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] array = CreateArray(4);
PrintArray(array);
int sum = Sum(array);
Console.Write($"-> {sum}");

int Sum( int[] array)
{
    int sum = 0;
    for( int i = 0; i < array.Length; i++)
        if ( array[i] % 2 == 0)
            sum ++;
    return sum;
}

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for( int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
    return array;
}

void PrintArray(int[] array)
{
    for( int i = 0; i < array.Length; i ++)
        Console.Write($"{array[i]} ");
}