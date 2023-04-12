using System;

public class teste
{
    public static void Main(string[] args)
    {
        exercicio4();
    }

    public static void exercicio1()
    {
        int a;
        while (true)
        {
            Console.WriteLine("Insira um inteiro positivo: ");
            a = int.Parse(Console.ReadLine());

            if (a > 0) {
                break;
            } else {
                Console.WriteLine("Insira um numero valido");
                continue; 
            
            }
        }

        Console.Write("Números inteiros pares entre 1 e "+a+": ");

        int[] pares = new int[a%2];
        for(int i = 1; i < a; i++){
            if(i % 2 == 0){
                Console.Write(i + ",");
            }
        }


    }

    public static void exercicio4(){

        int zeca = 0, joao = 0, branco = 0, nulo = 0;
        string entrada = "";
        while (entrada != "FIM"){

            Console.WriteLine("Insira seu voto: ");
            entrada = Console.ReadLine();

            if(entrada == "JOAO")
            {
                joao++;
            }else if(entrada == "ZECA")
            {
                zeca++;
            }else if(entrada == "BRANCO")
            {
                branco++;
            }
            else
            {
                nulo++;
            }

        }
        Console.WriteLine("Os votos foram: ");
        Console.WriteLine("Zeca: " + zeca + " | Joao: " + joao);
        Console.WriteLine("Branco: " + branco + " | Nulo: " + nulo);
    }

    public static void exercicio13()
    {
        int sum = 0;
        for(int i = 1; i <=500; i++)
        {
            if(i % 2 == 0)
            {
                sum += i;
            }
        }
        Console.WriteLine("A soma foi de " + sum);
    }

    public static void exercicio16()
    {
        int N;
        while (true)
        {
            Console.WriteLine("Insira um inteiro menor que 50: ");
            N = int.Parse(Console.ReadLine());
            
            if(N < 50)
            {
                break;
            }

        }

        while (N >= 250)
        {
            N = N * 3;

        }

        Console.WriteLine("resultado: " + N);
    }

    public static void exercicio17()
    {

        for(int i = 15; i<=200; i++)
        {
            Console.WriteLine("O quadrado de "+ i + " = "+i*i );
            
        }

    }
}