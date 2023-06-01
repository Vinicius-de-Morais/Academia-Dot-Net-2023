using Criptografia;
using CriptografiaSimetricaAndAssimetrica;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("#####encriptando#####");

        string cript = SimetricEncrypt("message");
        Console.WriteLine(cript);

        Console.WriteLine("#####decriptando#####");
        string decript = SimetricDecrypt(cript, "empressiveKey");
        Console.WriteLine(decript);

        Console.WriteLine("#####decriptando arquivo#####");
        string file = @"E:\Academia-Dot-Net-2023\aula25\dadoscripto.txt";
        string message = decriptFile(file, "atos20232");
        Console.WriteLine(message);


        Assimetrica assimetrica = new Assimetrica();
        Console.WriteLine("#####encriptando assimetrico #####");
        string Acript = AssimetricEncrypt("message", assimetrica);
        Console.WriteLine(Acript);

        Console.WriteLine("#####decriptando assimetrico #####");
        string Adecript = AssimetricDecrypt(Acript, assimetrica);
        Console.WriteLine(Adecript);
    }

    private static string decriptFile(string filename, string key)
    {
        StreamReader file = new StreamReader(filename, Encoding.UTF8);
        string message = file.ReadToEnd();
        string decripted = SimetricDecrypt(message, key);
        return decripted;

    }

    private static string SimetricEncrypt(string message)
    {
        Simetrica simetrica = new Simetrica();
        string cripted = simetrica.EncryptData(message, "empressiveKey");
        return cripted;
    }

    private static string SimetricDecrypt(string message, string key)
    {
        Simetrica simetrica = new Simetrica();
        string decripted = simetrica.DecryptData(message, key);
        return decripted;
    }

    private static string AssimetricEncrypt(string message, Assimetrica assimetrica)
    {
        string cripted = assimetrica.encrypt(message);
        return cripted;
    }

    private static string AssimetricDecrypt(string message, Assimetrica assimetrica)
    {
        string decripted = assimetrica.decrypt(message);
        return decripted;
    }
}