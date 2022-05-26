// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
//345, 897, 568, 234] -> 2


int[] arrayCreation(int length)
{
    int[] arr = new int[length];
    Random rnd = new Random();
    for ( int i = 0 ; i< length ; i ++)
    {
        arr[i] = rnd.Next(100,999); 
    }
return arr;}

Console.Write("Размер массива : ");
int length = int.Parse(Console.ReadLine());
int[] array = arrayCreation(length);
string PrintArray(int[] array)
{
    string result = String.Empty;
    for (int i = 0; i < array.Length; i++){
        if (i == 0) result = "[" + Convert.ToString(array[i]) + ", ";//string builder
        else if (i < array.Length-1)
            result = result + Convert.ToString(array[i]) + ", ";
        else result = result + Convert.ToString(array[i]) + "]";
    }
return result;
}

int GetEvenArray (int [] array) 
{    
    int k = 0;  
 
    foreach(int element in array) 
            { 
 
                Console.Write("{0} ", element); 
                if (element % 2 == 0) 
                { 
                    k++; 
                     
                } 
            } 
    return k;         
 
 
} 

Console.WriteLine($"{PrintArray(array)} -> {GetEvenArray(array)}"); 






