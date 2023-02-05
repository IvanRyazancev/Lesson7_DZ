// Задача №2. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " | ");
        }        
        Console.WriteLine("");
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

Console.Write("Введите количество строк двумерного массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов двумерного массива: ");
int column = int.Parse(Console.ReadLine()!);

int[,] numbers = new int[rows, column];

Console.WriteLine("Исходный массив: ");
FillArray(numbers);
PrintArray(numbers);
Console.WriteLine();

if (rows == column)
{
    for (int i = 0; i < numbers.GetLength(0)-1; i++)
    {            
        for (int j = i + 1; j < numbers.GetLength(1); j++)
        {                                           
            int temp = numbers[i, j];
            numbers[i, j] = numbers[j, i];
            numbers[j, i] = temp;                     
        }
    }    
    Console.WriteLine("Измененный массив: ");    
    PrintArray(numbers);
}
else
{
    Console.WriteLine("Поменять строки и столбцы невозможно, так как матрица не является квадратной.");
}