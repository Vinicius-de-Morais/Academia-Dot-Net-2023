using System;
using System.Runtime.Intrinsics.X86;

public class aula07
{
    public static void Main(String[] args)
    {
        //exercicio17();
        //exercicio16();
        //exercicio15();
        //exercicio14();
        //exercicio13();
        //exercicio12();

    }

    public static void exercicio1()
    {

    }

    public static void exercicio12()
    {
        System.Random random = new System.Random();

        int[,] matrix = new int[4, 3];

        // preenchedo os valores
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.Write("Linha" + i + " ");
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = random.Next(50);
                if (i + j % 2 == 0)
                {
                Console.Write(matrix[i, j] + "\t");
                }
            }
            Console.WriteLine();
        }

    }

    public static void exercicio13()
    {
        System.Random random = new System.Random();

        int[,] matrix = new int[5, 5];
        int diagonalPrim = 0, diagonalSec = 0;

        // preenchedo os valores
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = random.Next(50);
            }
        }

        // exibindo a matriz
        int aux = matrix.GetLength(1) - 1;


        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.Write("Linha" + i + " ");

            // pegar os valores da diagonal principal
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if(i == j)
                {
                    diagonalPrim += matrix[i, i];
                }
                Console.Write(matrix[i, j] + "\t");

            }

            Console.WriteLine();

            // somando os valores da diagonal
            while (aux >= 0)
            {
                diagonalSec += matrix[i, aux];
                aux--;
                break;
            }
        }

        if(diagonalPrim == diagonalSec)
        {
            Console.WriteLine("A soma das diagonais sao a mesma");
        } else
        {
            Console.WriteLine("A soma das diagonais nao sao a mesma");
        }
        Console.WriteLine("Diagonal primaria" + diagonalPrim + " Diagonal Secundaria: "+ diagonalSec);
    }

    public static void exercicio14()
    {
        System.Random random = new System.Random();

        int[,] matrix = new int[5, 5];
        int diagonalPrim = 0, diagonalSec = 0;

        // preenchedo os valores
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = random.Next(50);
            }
        }

        // exibindo a matriz
        int aux = matrix.GetLength(1) - 1;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.Write("Linha" + i + " ");
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == j)
                {
                    diagonalPrim = matrix[i, i];
                }

                Console.Write(matrix[i, j] + "\t");

            }

            Console.WriteLine();

            while (aux >= 0)
            {
                diagonalSec = matrix[i, aux];
                aux--;
                break;
            }

            if( diagonalSec != diagonalPrim)
            {
                Console.WriteLine("As diagonais nao sao iguais");
                break;
            }
        }
        if (diagonalPrim == diagonalSec)
        {
            Console.WriteLine("As diagonais sao iguais");
        }

        Console.WriteLine("Diagonal primaria" + diagonalPrim + " Diagonal Secundaria: " + diagonalSec);
    }

    public static void exercicio15()
    {
        System.Random random = new System.Random();

        int[,] matrix = new int[4, 4];
        int[,] matrixRevolution = new int[4, 4];

        // preenchedo os valores
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = random.Next(50);
                matrixRevolution[i, j] = random.Next(50);
            }
        }

        Console.WriteLine("------------ tabela 1 ------------");
        // exibindo a matriz
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.Write("Linha" + i + " ");
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }


        Console.WriteLine("------------ tabela 2 ------------");
        // exibindo a matriz
        for (int i = 0; i < matrixRevolution.GetLength(0); i++)
        {
            Console.Write("Linha" + i + " ");
            for (int j = 0; j < matrixRevolution.GetLength(1); j++)
            {
                Console.Write(matrixRevolution[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("------------ tabela soma ------------");

        // somando as tabelas e exibindo a matriz resultante
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.Write("Linha" + i + " ");
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] += matrixRevolution[i, j];
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }




    }

    public static void exercicio16()
    {
        System.Random random = new System.Random();
    
        int[,] matrix = new int[3, 4];

        // preenchedo os valores
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = random.Next(50);
            }
        }

        int[,] newMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];

        // invertendo as tabelas e exibindo a newMatrix
        for (int i = 0; i < newMatrix.GetLength(0); i++)
        {
            Console.Write("Linha" + i + " ");
            for (int j = 0; j < newMatrix.GetLength(1); j++)
            {
                newMatrix[i, j] = matrix[j, i];
                Console.Write(newMatrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        // exibindo a matriz
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.Write("Linha" + i + " ");
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public static void exercicio17()
    {

        System.Random random = new System.Random();
        
        // inicializando variaveis necessarias
        int max = 0, min = 100000, maxLin=0, maxCol=0, minCol = 0, minLin = 0;

        int[,] matrix = new int[10,10];
        
        // preenchendo a matriz
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = random.Next(50);
            }
        }

        // logica para verificar valor a valor e exibir matriz
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.Write("Linha" + i+" ");
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] >= max)
                {
                    max = matrix[i, j];
                    maxLin = i;
                    maxCol = j;
                } else if(matrix[i, j] <= min)
                {
                    min = matrix[i, j];
                    minLin = i;
                    minCol = j;
                }

                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("O maior elemento foi: "+ max + " Na Coluna: " + maxCol + " Na linha: " + maxLin);
        Console.WriteLine("O menor elemento foi:" + min + " Na Coluna: " + minCol + " Na linha: " + minLin);
    }
}