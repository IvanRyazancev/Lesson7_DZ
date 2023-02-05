// Задача №3. В прямоугольной матрице найти строку с наименьшей суммой элементов.

void FillArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray (int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(numbers[i, j] + " | ");
        }
        Console.WriteLine();
    }
}

int SumString(int[,] numbers, int i)
{
    int minSumString = numbers[i, 0];

    for (int j = 1; j < numbers.GetLength(1); j++)
    {
        minSumString += numbers[i, j];
    }
    return minSumString;
}

Console.Write("Введите количество строк двумерного массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов двумерного массива: ");
int column = int.Parse(Console.ReadLine()!);

int[,] numbers = new int[rows, column];

FillArray(numbers);
PrintArray(numbers);

int count = 0;
int minSumString = SumString(numbers, 0);
for (int i = 1; i < numbers.GetLength(0); i++)
{
    int temp = SumString(numbers, i);

    if (minSumString > temp)
    {
        minSumString = temp;
        count = i;
    }
}

Console.WriteLine($"Номер строки с наименьшей суммой - {count + 1}, со значением ({minSumString}).");