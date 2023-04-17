using System.Linq.Expressions;

public class Aula06
{
    public static void Main(string[] args)
    {
        exercicio03();
    }

    public static void exercicio01()
    {
        int[] values = new int[10];
        int value;

        for(int i =0;  i<10; i++)
        {
            Console.WriteLine("Insira o valor no indice "+ i);
            value = int.Parse(Console.ReadLine());
            values[i] = value;
        }
        // fiz separado propositalmente;
        int par = 0, impar = 0;
        for (int i = 0; i < 10; i++)
        {
            if (values[i] % 2 == 0)
            {
                par++;
            }
            else
            {
                impar++;
            }
        }

        Console.WriteLine("Pares " + par + " Impar " + impar);
    }

    public static void exercicio03()
    {
        int[] values = new int[5];
        int value;

        for (int i = 0; i < values.Length; i++)
        {
            Console.WriteLine("Insira o valor no indice " + i);
            value = int.Parse(Console.ReadLine());
            values[i] = value;
        }

        for (int i = 0; i < values.Length; i++)
        {
            for (int j = 1; j <= values[i]; j++)
            {
                if (values[i] % j == 0 && values[i] == j)
                {
                    if (values[i] % 2 != 0 || values[i] == 2)
                        Console.WriteLine("O numero " + values[i] + " no indice "+ i +" e primo");
                }
               
            }
        }
    }

    public static void exercicio06()
    {
        int[] values = new int[10];
        for(int i = 0; i <10; i++)
        {
            values[i] = i;
        }
        Array.Reverse(values);
    }

}