using aula30.DataModels;
using Microsoft.EntityFrameworkCore;
using System.Reflection.PortableExecutable;

namespace aula30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite: \n" +
                "1 - Para criar uma pessoa \n" +
                "2 - Para Alterar o nome da Pessoa \n" +
                "3 - Para Inserir um email \n" +
                "4 - Para Excluir uma pessoa\n" +
                "5 - Para Consultar tudo\n" +
                "6 - Para Consultar pelo ID\n");

            int option = int.Parse(Console.ReadLine());

            Context context = new Context();

            switch (option)
            {
                case 1:
                    try
                    {
                        Console.WriteLine("Insira o nome da pessoa");
                        Pessoa pessoa = new Pessoa();
                        pessoa.name = Console.ReadLine();

                        Console.WriteLine("Insira um Email: ");
                        string emailtemp = Console.ReadLine();

                        pessoa.Emails = new List<Email>()
                        {
                            new Email()
                            {
                                email = emailtemp
                            }
                        };

                        context.Pessoas.Add(pessoa);
                        context.SaveChanges();

                        Console.WriteLine("Pronto Cadastrado");
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    break;
                case 2:
                    try
                    {
                        Console.WriteLine("Insira o id da pessoa");
                        int id = int.Parse(Console.ReadLine());

                        Pessoa? pessoa = context.Pessoas.Find(id);

                        if (pessoa == null)
                        {
                            Console.WriteLine("Id não encontrado! Pressione qualquer tecla para voltar");
                            Console.ReadKey();
                            break;
                        }

                        Console.WriteLine("\nID: " + pessoa.id + "\nNome Atual: " + pessoa.name);
                        Console.WriteLine("\nInforme o nome correto: ");
                        pessoa.name = Console.ReadLine();

                        context.Pessoas.Update(pessoa);
                        context.SaveChanges();
                        Console.WriteLine("Alterações Feitas com Sucesso");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    break;

                case 3:
                    try
                    {
                        Console.WriteLine("Insira o id da pessoa");
                        int id = int.Parse(Console.ReadLine());

                        Pessoa? pessoa = context.Pessoas.Find(id);

                        if (pessoa == null)
                        {
                            Console.WriteLine("Id não encontrado! Pressione qualquer tecla para voltar");
                            Console.ReadKey();
                            break;
                        }

                        Console.WriteLine("Insira um Email: ");
                        string emailtemp = Console.ReadLine();

                        pessoa.Emails = new List<Email>()
                        {
                            new Email()
                            {
                                email = emailtemp
                            }
                        };

                        context.Pessoas.Update(pessoa);
                        context.SaveChanges();

                        Console.WriteLine("Pronto Cadastrado");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    break;
                case 4:
                    try
                    {
                        Console.WriteLine("Insira o id da pessoa");
                        int id = int.Parse(Console.ReadLine());

                        Pessoa? pessoa = context.Pessoas.Find(id);

                        if (pessoa == null)
                        {
                            Console.WriteLine("Id não encontrado! Pressione qualquer tecla para voltar");
                            Console.ReadKey();
                            break;
                        }

                        Console.WriteLine("Deseja realmente excluir a pessoa "+pessoa.name);
                        Console.WriteLine("E seus emails");
                        foreach(Email email in pessoa.Emails)
                        {
                            Console.WriteLine("\t"+email.email);
                        }

                        Console.WriteLine("Y - sim | N - nao");
                        string answer = Console.ReadLine();

                        if(answer.ToUpper() == "Y")
                        {
                            context.Pessoas.Remove(pessoa);
                            context.SaveChanges();
                        }
                        else
                        {
                            Console.WriteLine("Pronto Cadastrado");
                            break;
                        }
                        
                        Console.WriteLine("Pronto Removido");

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    break;
                case 5:
                    List<Pessoa> pessoas = (from Pessoa pessoa in context.Pessoas 
                                            select pessoa).Include(pes => pes.Emails).ToList<Pessoa>();

                    foreach (Pessoa pessoa in pessoas)
                    {
                        Console.WriteLine(pessoa);
                    }
                    break;
                case 6:

                    Console.WriteLine("Insira o id da pessoa");
                    int teste = int.Parse(Console.ReadLine());

                    Pessoa? pessoa1 = context.Pessoas.Include(pes => pes.Emails).
                                      Where(p => p.id == teste).FirstOrDefault();

                    if (pessoa1 == null)
                    {
                        Console.WriteLine("Id não encontrado! Pressione qualquer tecla para voltar");
                        Console.ReadKey();
                        break;
                    }

                    Console.WriteLine(pessoa1);
                    
                    break;
            }
        }
            
    }
}