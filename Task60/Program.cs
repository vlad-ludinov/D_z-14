using static System.Console;

int [,,] array = get3DArray();
print3DArray(array);



int [,,] get3DArray()
{
    Random rnd = new Random();
    int [,,] array3D = new int [rnd.Next(2,5), rnd.Next(2,5), rnd.Next(2,5)];
    int [] check = new int [array3D.GetLength(0)*array3D.GetLength(1)*array3D.GetLength(2)];
    int temp = 0;
    bool indicator = true;
    int count = 0;
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                while (indicator)
                {
                    array3D[i,j,k] = rnd.Next(10,100);
                    for (int n = 0; n < check.Length; n++)
                    {
                        if (array3D[i,j,k] != check[n])
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
                check[count] = array3D[i,j,k];
                indicator = true;
                count +=1;
            }
        }
    }
    return array3D;
}

void print3DArray(int [,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(2); i++)
    {
        for (int j = 0; j < array3D.GetLength(0); j++)
        {
            for (int k = 0; k < array3D.GetLength(1); k++)
            {
                Write($"{array3D[j,k,i],5}({j},{k},{i})");
            }
            WriteLine("");
        }
    }
}