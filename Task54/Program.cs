using static System.Console;

WriteLine("Задан массив:");
int [,] array = getArray();
printArray(array);
WriteLine("После сортировки получается такой массив:");
sortArray(array);
printArray(array);

int[,] getArray()
{
    Random rnd = new Random();
    int[,] arr = new int[rnd.Next(3, 7), rnd.Next(3, 7)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(1, 11);
        }
    }
    return arr;
}

void printArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Write($"{arr[i, j],4}");
        }
        WriteLine("");
    }
}

void sortArray(int[,] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = j; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i, j] < arr[i, k + 1])
                {
                    temp = arr[i, j];
                    arr[i, j] = arr[i, k + 1];
                    arr[i, k + 1] = temp;
                }
            }
        }
    }
}