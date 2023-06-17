using System;
class program
{
    static void Main()
    {


        int[,] matriz1 = new int[3, 2];
        matriz1[0, 0] = 1;
        matriz1[0, 1] = 2;
        matriz1[1, 0] = 3;
        matriz1[1, 1] = 4;
        matriz1[2, 0] = 5;
        matriz1[2, 1] = 6;

        for(int i=0; i<3; i++)
        {
            for (int j=0; j<2; j++)
            {
                Console.WriteLine("Elementos en la posicion [{0},{1}:{2}",i,j, matriz1[i,j]);
            }
        }
        Console.WriteLine();
    }
}
