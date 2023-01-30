using static System.Console;

WriteLine("Задан массив:");

int [,] array = getArray();
printArray(array);
int [] minSumIndex = findMinSumIndexArray(array);
printMinSumIndex(array, minSumIndex);

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

int [] findMinSumIndexArray(int [,] arr)
{
    int [] sum = new int [arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum[i] = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum[i] += arr[i,j];
        }
    }
    int minSum = sum[0];
    int count = 0;
    for (int i = 1; i < sum.Length; i++)
    {
        if (minSum == sum[i])
        {
            count += 1;
        }
        if (minSum > sum[i])
        {
            minSum = sum[i];
            count = 0;
        }
    }
    int [] minSumInd = new int [count+1];
    int temp = 0;
    for (int i = 0; i < sum.Length; i++)
    {
        if (sum[i] == minSum)
        {
            minSumInd[temp] = i;
            temp+=1;
        }
    }
    return minSumInd;
}

void printMinSumIndex(int [,] array, int [] minSumInd)
{
    if (minSumInd.Length == 1)
    {
        WriteLine($"Строка с минимальной суммой элементов: {minSumInd[0]+1}");
    }
    else
    {
        Write("Строки с минимальной суммой элементов: ");
        for (int i = 0; i < minSumInd.Length-2; i++)
        {
            Write($"{minSumInd[i]+1}, ");
        }
        WriteLine($"{minSumInd[minSumInd.Length-2]+1} и {minSumInd[minSumInd.Length-1]+1}");
    }
}
    