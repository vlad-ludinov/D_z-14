using static System.Console;

int [,] getArray()
{
    Random rnd = new Random();
    int [,] array = new int [rnd.Next(3,7),rnd.Next(3,7)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(1,11);
        }
    }
    return array;
}

