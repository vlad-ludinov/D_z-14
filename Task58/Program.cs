using static System.Console;

int [,] getMatrix()
{
    Random rnd = new Random();
    int [,] matrix = new int [rnd.Next(2,5), rnd.Next(2,5)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1,11);
        }
    }
    return matrix;
}

void printMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Write($"{matrix[i,j],4}");
        }
        WriteLine("");
    }
}