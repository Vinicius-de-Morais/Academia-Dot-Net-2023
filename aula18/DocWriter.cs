using aula18;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace aula18
{

    internal class DocWriter
    {
        public static void printFile(string file)
        {
            try
            {
                StreamReader reader = new StreamReader(file, Encoding.UTF8);
                do
                {
                    Console.WriteLine(reader.ReadLine());
                } while (!reader.EndOfStream);
                reader.Close();
            }
            catch (Exception)
            {
                throw new Exception("Error while reading the file's content");
            }
        }

        public static void printFileNames(string file)
        {
            try
            {
                StreamReader reader = new StreamReader(file, Encoding.UTF8);
                string[] vectorPessoa; 
                string actualLine;
                do
                {
                    actualLine = reader.ReadLine();
                    vectorPessoa = actualLine.Split(";");
                    Console.WriteLine(vectorPessoa[0]);
                } while (!reader.EndOfStream);
                reader.Close();
            }
            catch (Exception)
            {
                throw new Exception("Error while reading the file's content");
            }
        }

        public static List<Pessoa> getFileList(string file)
        {

            List<Pessoa> contentList = new();
            try
            {
                StreamReader reader = new StreamReader(file, Encoding.UTF8);
                string[] vectorPessoa;
                string actualLine;
                do
                {
                    actualLine = reader.ReadLine();
                    vectorPessoa = actualLine.Split(";"); 
                    contentList.Add(new Pessoa(vectorPessoa[0], vectorPessoa[1], vectorPessoa[2]));
                } while (!reader.EndOfStream);
                reader.Close();

                return contentList;
            }
            catch (Exception)
            {
                throw new Exception("Error while reading the file's content");
            }
        }

        public static void writeByList(List<Pessoa> list, string file)
        {
            try
            {
                StreamWriter writer = new StreamWriter(file, append: true); 

                foreach (var item in list)
                {
                    writer.WriteLine(item.Nome + ";" + item.Email + ";" + item.DataNascimento);
                    writer.Flush();
                }
                writer.Close();
            }
            catch (Exception)
            {
                throw new Exception("Error while writing on file");
            }
        }

        public static void ReWriteByList(List<Pessoa> list, string file)
        {
            try
            {
                StreamWriter writer = new StreamWriter(file);

                foreach (var item in list)
                {
                    writer.WriteLine(item.Nome + ";" + item.Email + ";" + item.DataNascimento);
                    writer.Flush();
                }
                writer.Close();
            }
            catch (Exception)
            {
                throw new Exception("Error while writing on file");
            }
        }

        public static void writeOne(Pessoa pessoa, string file)
        {
            try
            {
                StreamWriter writer = new StreamWriter(file, append: true);

                writer.WriteLine(pessoa.Nome + ";" + pessoa.Email + ";" + pessoa.DataNascimento);

                writer.Close();
            }
            catch (Exception)
            {
                throw new Exception("Error while writing on file");
            }
        }

        public static Pessoa getOne(string email, string file)
        {
            try
            {
                StreamReader reader = new StreamReader(file, Encoding.UTF8);
                string[] vectorPessoa;
                string actualLine;
                do
                {
                    actualLine = reader.ReadLine();
                    vectorPessoa = actualLine.Split(";");
                    if (vectorPessoa[1].Equals(email))
                    {
                        return new Pessoa(vectorPessoa[0], vectorPessoa[1], vectorPessoa[2]);
                    }

                } while (!reader.EndOfStream);

                reader.Close();
                return null;
            }
            catch (Exception)
            {
                throw new Exception("Error while writing on file");
            }
        }

        public static int getIndex(Pessoa pessoa, string file)
        {
            try
            {
                StreamReader reader = new StreamReader(file, Encoding.UTF8);

                string[] vectorPessoa;
                string actualLine;
                int index = 0;
                do
                {
                    actualLine = reader.ReadLine();
                    vectorPessoa = actualLine.Split(";");
                    Console.WriteLine(vectorPessoa[1] + "|"+(pessoa.Email));
                    if (vectorPessoa[1].Equals(pessoa.Email))
                    {
                        return index;
                    }
                    index++;

                } while (!reader.EndOfStream);

                reader.Close();
                return -1;
            }
            catch (Exception)
            {
                throw new Exception("Error while writing on file");
            }
        }

        // ainda n ta funcionando por causa da logica de chave primaria
        public static void update(Pessoa pessoa, string file)
        {
            try
            {
                int index = getIndex(pessoa, file);
                Console.WriteLine(index);
                /*List<Pessoa> list = getFileList(file);
                list[index] = pessoa;
                ReWriteByList(list, file);*/
            }
            catch (Exception)
            {
                throw new Exception("Error while writing on file");
            }
        }
    }   
}