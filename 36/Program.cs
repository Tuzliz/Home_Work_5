﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, 
// стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// Задаем одномерный массив из случайных чисел 
int[] ArrayCreation(int length)
    {
    int[] arr = new int[length];
    Random rnd = new Random();
    for ( int i = 0 ; i< length ; i ++){
        arr[i] = rnd.Next(1,10);
    }
return arr;} 

int unEvenPositionInArraySum(int[] array)
{ // метод поиска не чётных индексов и суммирования значений по этим индексов
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            sum += array[i];
    }
return sum;
}


////метод, который печатает наш массив на консоль
void PrintArray(int [] arr)
{
foreach(int item in arr)
Console.Write($"{item} ");
}
int [] arr = ArrayCreation(10);
int res = unEvenPositionInArraySum(arr); 
PrintArray(arr);
Console.WriteLine();
Console.Write($"Сумма нечетных индексов: {res}");
