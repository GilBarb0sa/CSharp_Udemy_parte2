using System;
using System.IO;
using System.Collections.Generic;

namespace TrabComArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exemplo 1
            //string sourcePath = @"C:\Users\40357200896\Documents\Gilberto\file.txt";
            //string targetPath = @"C:\Users\40357200896\Documents\Gilberto\file2.txt";

            //try
            //{   
            //    //Cria um nome arqruivo semelhante, só alterando o nome do arquivo
            //    FileInfo fileInfo = new FileInfo(sourcePath);
            //    fileInfo.CopyTo(targetPath);
            //    string[] lines = File.ReadAllLines(sourcePath); //puxa a info no arquivo e apresenta em tela
            //    foreach (string line in lines)
            //    {
            //        Console.WriteLine(line);
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(e.Message);
            //}
            #endregion

            #region Exemplo 2
            //string path = @"C:\Users\40357200896\Documents\Gilberto\file.txt";
            //FileStream fs = null;
            //StreamReader sr = null;
            //try
            //{
            //    //fs = new FileStream(path, FileMode.Open); //Aqui abre um arquivo
            //    //sr = new StreamReader(fs); //captura o arquivo que foi aberto
            //    sr = File.OpenText(path); //Faz o trabalho das duas instancias que foi realizado acima
            //    while (!sr.EndOfStream)  //Enquanto não chegar ao final da Stream vai ler uma linha
            //    {
            //        string line = sr.ReadLine(); //captura apenas uma linha do arquivo
            //        Console.WriteLine(line);
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error accurred");
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    //Fecha ambos mesmo se foi sucesso ou não o seu manuseio
            //    if (sr != null) sr.Close();
            //    if (fs != null) fs.Close();
            //}
            #endregion

            #region Exemplo 3
            //string path = @"C:\Users\40357200896\Documents\Gilberto\file.txt";
            //try
            //{
            //    using (StreamReader sr = File.OpenText(path))  // Este metodo é o metodo simplificado acessando o FileStream com StreamReader
            //    {
            //        while (!sr.EndOfStream) //Gera o texto até chegar ao fim a stream
            //        {
            //            string line = sr.ReadLine();
            //            Console.WriteLine(line);
            //        }
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(e.Message);
            //}
            #endregion

            #region Exemplo 4
            //string sourcePath = @"C:\Users\40357200896\Documents\Gilberto\file.txt";
            //string targetPath = @"C:\Users\40357200896\Documents\Gilberto\file2.txt";
            //try
            //{
            //    string[] lines = File.ReadAllLines(sourcePath); // Inseri o SourcePath numa lista de linhas
            //    using (StreamWriter sw = File.AppendText(targetPath)) //inseri no streawriter e sobrecreve com o AppendText
            //    {
            //        foreach (string line in lines)
            //        {
            //            sw.WriteLine(line.ToUpper()); //Transforma o file2 textos em maiusculos
            //        }
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(e.Message);
            //}
            #endregion

            #region Exemplo 5
            //string path = @"C:\Users\40357200896\Documents\Gilberto\myfolder";

            //try
            //{
            //    //Listar as pastas a partir de uma pasta informada
            //    var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
            //    Console.WriteLine("FOLDERS: ");
            //    foreach (string s in folders)
            //    {
            //        Console.WriteLine(s);
            //    }

            //    //Listar os arquivos a partir de uma pasta informada
            //    var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
            //    Console.WriteLine("FILES: ");
            //    foreach (string s in files)
            //    {
            //        Console.WriteLine(s);
            //    }

            //    //Criando uma nova pasta
            //    Directory.CreateDirectory(path + @"\newfolder");
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(e.Message);
            //}
            #endregion

            #region Exemplo 6
            string path = @"C:\Users\40357200896\Documents\Gilberto\myfolder\file.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
            #endregion
        }
    }
}
