// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void FillArray(int [] array )
{
    for (int i =0; i<array.Length; i++)
        array[i] = new Random().Next(100,999);
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
    int sum=0;
    for (int i =0; i<array.Length; i++)
        if (array[i]%2 == 0) sum+=1;
       Console.WriteLine($"Сумма четных эдементов массива = {sum}");
}

int [] array  = new int [12];
FillArray(array);
PrintArray(array);
Summa(array);

