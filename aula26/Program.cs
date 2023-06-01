using aula26;
using System.Data;
using System.Security.Claims;


internal class Program
{
    private static void Main(string[] args)
    {
        /*Pessoa pessoa = new Pessoa();
        pessoa.Nome = "Daisy";
        pessoa.Proficao = "Pior princesa";
        pessoa.insertOnDb();

        pessoa.Nome = "MARIOKKKKK zoei";
        pessoa.updateOnDb();

        *//*Pessoa pessoa2 = new Pessoa();
        pessoa2.Id = 2;
        pessoa2.deleteOnDb();*/

        DataTable dt = Pessoa.getAll();

        //Console.WriteLine(dt.Rows.);
        PrintDataTable(dt);

        List<Pessoa> pessoas = Pessoa.getAllToList();
        pessoas.ForEach(pessoa => Console.WriteLine(pessoa));
    }
    private static void PrintDataTable(DataTable table)
    {
        Console.WriteLine("{0,10}\t{1,10}\t{2,10}\t",
           "ID",
           "Nome",
           "Proficao"
           );
        foreach (DataRow row in table.Rows)
        {
            Console.WriteLine("{0,10}\t{1,10}\t{2,10}\t",
                row["id"],
                row["nome"],
                row["profissao"]
                );
        }
    }
}
