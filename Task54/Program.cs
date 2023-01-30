using static System.Console;

int [,] getArray()
{
    Random rnd = new Random();
    int [,] arr = new int [rnd.Next(3,7),rnd.Next(3,7)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = rnd.Next(1,11);
        }
    }
    return arr;
}

void printArray(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Write(arr[i,j]);
        }
        WriteLine("");
    }
}