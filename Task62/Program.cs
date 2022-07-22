// 1 Вариант

// void Show2dArray(int[,] array)

// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] array = new int[4, 4];

// int element = 1;
// int i = 0;
// int j = 0;

// while (element <= array.GetLength(0) * array.GetLength(1))
// {
//   array[i, j] = element;
//   element++;
//   if (i <= j + 1 && i + j < array.GetLength(1) - 1)
//     j++;
//   else if (i < j && i + j >= array.GetLength(0) - 1)
//     i++;
//   else if (i >= j && i + j > array.GetLength(1) - 1)
//     j--;
//   else
//     i--;
// }

// Show2dArray(array);



// 2 Вариант

void SpiralMatrix(int[,] array)
{
    int s = 1;

    for (int y = 0; y < array.GetLength(1); y++)
    {
        array[0, y] = s;
        s++;
    }
    for (int x = 1; x < array.GetLength(0); x++)
    {
        array[x, array.GetLength(0) - 1] = s;
        s++;
    }
    for (int y = array.GetLength(1) - 2; y >= 0; y--)
    {
        array[array.GetLength(0) - 1, y] = s;
        s++;
    }
    for (int x = array.GetLength(0) - 2; x > 0; x--)
    {
        array[x, 0] = s;
        s++;
    }

    int c = 1;
    int d = 1;

    while (s < array.GetLength(0) * array.GetLength(1))
    {

        while (array[c, d + 1] == 0)
        {
            array[c, d] = s;
            s++;
            d++;
        }

        while (array[c + 1, d] == 0)
        {
            array[c, d] = s;
            s++;
            c++;
        }

        while (array[c, d - 1] == 0)
        {
            array[c, d] = s;
            s++;
            d--;
        }

        while (array[c - 1, d] == 0)
        {
            array[c, d] = s;
            s++;
            c--;
        }
    }


    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            if (array[x, y] == 0)
            {
                array[x, y] = s;
            }
        }
    }
}

void Show2dArray(int[,] array)

{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите размет квадратного массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[n, n];

SpiralMatrix(array);
Show2dArray(array);