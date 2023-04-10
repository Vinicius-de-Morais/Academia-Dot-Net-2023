// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class teste
{
    public static void Main(string[] args)
    {
        Exercicio13();
    }


    public static void Exercicio12(){

        double marcacaoInicio, marcacaoFinal, combustivelGasto, valorRecebido, 
            totalKm, mediaConsumo, lucro;

        Console.WriteLine("Digite a marcação do odômetro no início do dia (em Km): ");
        marcacaoInicio = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a marcação do odômetro no final do dia (em Km): ");
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
        Console.WriteLine("Insira o salario do minimo");
        double salario = 2 * double.Parse(Console.ReadLine());

        Console.WriteLine("Insira o valor da bicicleta");
        double bicicletasValue = double.Parse(Console.ReadLine());

        Console.WriteLine("Insira a quantidade de bicicletas");
        int bicicletasQuantity = int.Parse(Console.ReadLine());

        double aumento = (bicicletasValue / 0.15) * bicicletasQuantity;

        double trueSalary = salario + aumento;

        Console.WriteLine("O salario do empregado e "+trueSalary);
    }
}
