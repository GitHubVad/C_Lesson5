﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

void FillArray(int [] array)  
{      
    for (int i =0; i<array.Length; i++)          
    array[i] = new Random().Next(1,101);  
}   

void PrintArray(int [] array)  
{      
    foreach (int el in array)      
    {          
        Console.Write($"{el} ");      
    }      
    Console.WriteLine();  
}
void Method(int [] array)
{
	int sum= 0;
	for(int i=1; i<array.Length; i= i+2)
		 sum+=array[i];        
	Console.WriteLine($"Сумма нечетных позиций = {sum}");
}
int[] array = new int[12];
FillArray(array);
PrintArray(array);
Method(array);