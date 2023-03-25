// suЗадача 36: Задайте одномерный массив, заполненный 
//случайными числами. Найдите сумму элементов, стоящих на 
//нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] array = CreateArray(4);
PrintArray(array);
Console.Write($" -> {Sum(array)}");

int Sum(int[] array)
{
    int sum = 0;
    for( int i = 1; i <array.Length; i += 2)
        sum += array[i];
    return sum;
}


int[] CreateArray(int size)
{
    int[] array = new int[size];
    for ( int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 100);
    return array;
}

void PrintArray(int[] array)
{
    for( int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}