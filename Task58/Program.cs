using static System.Console;

WriteLine("Заданны две матрицы:");
int [,] matrix1 = getMatrix();
int [,] matrix2 = getMatrix();
WriteLine("Первая:");
printMatrix(matrix1);
WriteLine("И вторая:");
printMatrix(matrix2);
int [,] multiMatrix = multiplyMatrix(matrix1, matrix2);
printMultiplyMatrix(matrix1, matrix2, multiMatrix);

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

int [,] multiplyMatrix(int [,] matrixA, int [,] matrixB)
{
    if (matrixA.GetLength(1) == matrixB.GetLength(0))
    {
        int [,] matrixC = new int [matrixA.GetLength(0), matrixB.GetLength(1)];
        for (int i = 0; i < matrixC.GetLength(0); i++)
        {
            for (int j = 0; j < matrixC.GetLength(1); j++)
            {
                matrixC[i,j] = 0;
                for (int k = 0; k < matrixA.GetLength(1); k++)
                {
                    matrixC[i,j] += matrixA[i,k] * matrixB[k,j];
                }
            }
        }
        return matrixC;
    }
    else
    {
        if (matrixB.GetLength(1) == matrixA.GetLength(0))
        {
            int [,] matrixC = new int [matrixB.GetLength(0), matrixA.GetLength(1)];
            for (int i = 0; i < matrixC.GetLength(0); i++)
            {
                for (int j = 0; j < matrixC.GetLength(1); j++)
                {
                    matrixC[i,j] = 0;
                    for (int k = 0; k < matrixB.GetLength(1); k++)
                    {
                        matrixC[i,j] += matrixB[i,k] * matrixA[k,j];
                    }
                }
            }
            return matrixC;
        }
        else
        {
            int [,] matrixC = new int [1,1];
            return matrixC;
        }
    }
}

void printMultiplyMatrix(int [,] matrixA, int [,] matrixB, int [,] matrixC)
{
    if (matrixA.GetLength(1) == matrixB.GetLength(0))
    {
        WriteLine("При умножении первой матрицы на вторую получается матрица:");
        for (int i = 0; i < matrixC.GetLength(0); i++)
        {
            for (int j = 0; j < matrixC.GetLength(1); j++)
            {
                Write($"{matrixC[i,j],4}");
            }
            WriteLine("");
        }
    }
    else
    {
        if (matrixB.GetLength(1) == matrixA.GetLength(0))
        {
            WriteLine("При умножении второй матрицы на первую получается матрица:");
            for (int i = 0; i < matrixC.GetLength(0); i++)
            {
                for (int j = 0; j < matrixC.GetLength(1); j++)
                {
                    Write($"{matrixC[i,j],4}");
                }
                WriteLine("");
            }
        }
        else
        {
            WriteLine("Эти матрицы нельзя умножить друг на друга");
        }
    }
}