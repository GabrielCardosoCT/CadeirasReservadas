using System;

class Program
{
    static void Main(string[] args)
    {
        bool sair = false;
        char[,] mat = new char[9, 9];

        do
        {
            Console.WriteLine("Posição da cadeira: linha e coluna");
            int lin = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            if (lin < 1 || lin > 9 || col < 1 || col > 9)
            {
                Console.WriteLine("Para sair, digite um local inexistente.");
                sair = true;
            }
            else
            {
                if (mat[lin - 1, col - 1] == '.')
                {
                    sair = true;
                    mat[lin - 1, col - 1] = 'x';
                    Console.WriteLine("Cadeira reservada...");
                }
                else
                {
                    Console.WriteLine("Cadeira indisponível...");
                }
            }
        } while (!sair);

        Console.WriteLine(" 123456789");
        for (int i = 0; i < 9; i++)
        {
            Console.Write((i + 1) + " ");
            for (int j = 0; j < 9; j++)
            {
                Console.Write(mat[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
