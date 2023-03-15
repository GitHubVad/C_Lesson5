// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

void FillArray(int [] array )  
{      
    for (int i =0; i<array.Length; i++)          
    array[i] = new Random().Next(1,11);  
}   

void PrintArray(int [] array)  
{      
    foreach (int el in array)      
    {          
        Console.Write($"{el} ");      
    }      
    Console.WriteLine();  
}
void Summa(int [] array)
{	
	 for (int i = 0; i < array.Length; i++)
        for (int j = 0; j < array.Length - 1; j++)
            if (array[j] > array[j + 1])
            {
                int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
            }
		int sum = array[^1] - array[0];	
	Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {sum}");	
}

int[] array = new int[4];

FillArray(array);
PrintArray(array);
Summa(array);