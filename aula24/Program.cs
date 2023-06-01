
using System.Formats.Asn1;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;
using Newtonsoft.Json;

internal class Program
{
    private static void Main(string[] args)
    {

        serialize("aaaaaa");
        desserialize();

        /*teste teste = new teste("nome");
        serializeXML(teste);*/

        Pessoa pessoa = new Pessoa();
        pessoa.salario = 1;
        pessoa.idade = 12;
        pessoa.nome = "teste";

        serializeXML(pessoa);
        deserializeXML();
    }

    public static void serialize(string str)
    {
        FileStream fileStream = new FileStream(@"E:\Academia-Dot-Net-2023\aula24\arquivo.data", FileMode.OpenOrCreate);
        BinaryFormatter format = new BinaryFormatter();
        format.Serialize(fileStream, str);
        fileStream.Close();

    }

    public static void desserialize()
    {
        FileStream fileStream = new FileStream(@"E:\Academia-Dot-Net-2023\aula24\arquivo.data", FileMode.Open);
        BinaryFormatter format = new BinaryFormatter();
        string teste = (string)format.Deserialize(fileStream);
        fileStream.Close();

        Console.WriteLine(teste);

    }


    public static void serializeXML(Pessoa pessoa)
    {
        FileStream fileStream = new FileStream(@"E:\Academia-Dot-Net-2023\aula24\xml.xml", FileMode.OpenOrCreate);
        XmlSerializer format = new XmlSerializer(typeof(Pessoa));
        format.Serialize(fileStream, pessoa);
        fileStream.Close();

    }

    public static void deserializeXML()
    {
        FileStream fileStream = new FileStream(@"E:\Academia-Dot-Net-2023\aula24\xml.xml", FileMode.Open);
        XmlSerializer format = new XmlSerializer(typeof(Pessoa));
        object pessoa = format.Deserialize(fileStream);

        Console.WriteLine(pessoa.ToString());
        fileStream.Close();

    }

    public static void serializeJSON(Pessoa pessoa, FileStream fileStream)
    {
        FileStream fileStream = new FileStream(@"E:\Academia-Dot-Net-2023\aula24\xml.xml", FileMode.OpenOrCreate);
        JsonWriter format = new JsonTextWriter(fileStream);
        format.Serialize(fileStream, pessoa);
        fileStream.Close();

    }

    public static void serializeJSON(Pessoa pessoa)
    {
        FileStream fileStream = new FileStream(@"E:\Academia-Dot-Net-2023\aula24\xml.json", FileMode.OpenOrCreate);
        string json = JsonConvert.SerializeObject(pessoa);
        format.Serialize(fileStream, pessoa);
        fileStream.Close();

    }
}

[Serializable]
internal class teste
{
    public string nome { get; set; }
    public teste(string nome)
    {
        this.nome = nome;
    }
}

[Serializable]
public class Pessoa
{
    public string nome;
    public int idade;
    public double salario;
}