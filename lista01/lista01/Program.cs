// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class teste
{
    public static void Main(string[] args)
    {
        Exercicio13();
    }

    public static void exercicio11(){

        Console.Write("Digite o número de eleitores: ");
        int totalEleitores = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de votos brancos: ");
        int votosBrancos = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de votos nulos: ");
        int votosNulos = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de votos válidos: ");
        int votosValidos = int.Parse(Console.ReadLine());

        double percentualBrancos = (double)votosBrancos / totalEleitores * 100;
        double percentualNulos = (double)votosNulos / totalEleitores * 100;
        double percentualValidos = (double)votosValidos / totalEleitores * 100;

        Console.WriteLine("Percentual de votos brancos: " + percentualBrancos.ToString("F2") + "%");
        Console.WriteLine("Percentual de votos nulos: " + percentualNulos.ToString("F2") + "%");
        Console.WriteLine("Percentual de votos válidos: " + percentualValidos.ToString("F2") + "%");
    }

    public static void Exercicio12(){

        double marcacaoInicio, marcacaoFinal, combustivelGasto, valorRecebido, 
            totalKm, mediaConsumo, lucro;

        Console.WriteLine("Digite a marcação no início do dia (em Km): ");
        marcacaoInicio = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a marcação no final do dia (em Km): ");
        marcacaoFinal = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de combustível gasto (em litros): ");
        combustivelGasto = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor total recebido dos passageiros (em R$): ");
        valorRecebido = double.Parse(Console.ReadLine());

        totalKm = marcacaoFinal - marcacaoInicio;
        mediaConsumo = totalKm / combustivelGasto;
        lucro = valorRecebido - (combustivelGasto * 6.90);

        Console.WriteLine("Média do consumo: " + mediaConsumo.ToString("F2") + " Km/l");
        Console.WriteLine("Lucro do dia: R$ " + lucro.ToString("F2"));
    }

    public static void Exercicio13()
    {   
        // Ler o salario minimo, o valor das bicicletas e a quantidade
        Console.WriteLine("Insira o salario do minimo");
        double salario = 2 * double.Parse(Console.ReadLine());

        Console.WriteLine("Insira o valor da bicicleta");
        double bicicletasValue = double.Parse(Console.ReadLine());

        Console.WriteLine("Insira a quantidade de bicicletas");
        int bicicletasQuantity = int.Parse(Console.ReadLine());

        // Fazer a l[ogica do calculo
        double aumento = (bicicletasValue / 0.15) * bicicletasQuantity;

        double trueSalary = salario + aumento;

        Console.WriteLine("O salario do empregado e "+trueSalary);
    }
}
