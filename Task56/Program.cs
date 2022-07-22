int[,] CreateRandom2dArray(int minValue, int maxValue)
{
    int rows = 5;
    int columns = 3;
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

void Show2dArray(int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int SumLineElements(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}

void FindMinLine(int[,] array)
{
    int minNumLine = 0;
    int minSumLine = SumLineElements(array, 0);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int tempSumLine = SumLineElements(array, i);
        if (minSumLine > tempSumLine)
        {
            minSumLine = tempSumLine;
            minNumLine = i;
        }
    }
    Console.WriteLine($"Номер строки с наименьшим элементом: {minNumLine + 1}.");
}

Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(min, max);
Show2dArray(array);
FindMinLine(array);