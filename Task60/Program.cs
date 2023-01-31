using static System.Console;

int [,] getMatrix()
{
    Random rnd = new Random();
    int [,] matrix = new int [rnd.Next(2,5), rnd.Next(2,5), rnd.Next(2,5)];
    int [] check = new int [matrix.GetLength(0)*matrix.GetLength(1)*matrix.GetLength(2)];
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                while (indicator)
                {
                    matrix[i,j,k] = rnd.Next(10,100);
                    for (int n = 0; n < check.Length; n++)
                    {
                        if (matrix[i,j,k] != check[n])
                        {
                            temp +=1;
                        }
                    }
                    if (temp == check.Length)
                    {
                        indicator = false;
                    }
                    temp = 0;
                }
                indicator = true;
            }
        }
    }
    return matrix;
}