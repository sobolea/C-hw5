// Задача 38: 
// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] array = CreateArray(5);
for( int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
Console.Write($" -> {Difference(array)}");

int Difference(int[] array)
{
    int max = array[0];
    int min = array[0];
    for ( int i = 1; i<array.Length; i++)
        if( array[i] > max)
            max = array[i];
        else if (array[i] < min)
            min = array[i];
    return max - min;
}



int[] CreateArray(int size)
{
    int[] array = new int[size];
    for( int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 100);
    return array;
}