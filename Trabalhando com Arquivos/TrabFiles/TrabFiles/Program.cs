using System;
using TrabFiles.Entities;
using System.IO;
using System.Globalization;

namespace TrabFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string sourceFilePath = Console.ReadLine();

            try
            {
                // Lê todas as linhas do arquivo especificado no caminho fornecido
                string[] lines = File.ReadAllLines(sourceFilePath);

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath); // Obtém o caminho do diretório onde o arquivo original está localizado
                string targetFolderPath = sourceFolderPath + @"\out";  // Define o caminho da pasta "out", onde o arquivo de saída será salvo // Cria o caminho para a pasta "out"
                string targetFilePath = targetFolderPath + @"\sumary.csv";   // Define o caminho para o arquivo de saída (sumary.csv) na pasta "out"

                // Cria o diretório de destino caso ele não exista
                Directory.CreateDirectory(targetFolderPath);  // Se a pasta "out" não existir, ela será criada

                // Cria ou abre o arquivo sumary.csv no modo de anexação para escrita
                using (StreamWriter sw = File.AppendText(targetFilePath))  // Abre o arquivo para adicionar novos dados ao final
                {
                    // Itera sobre cada linha lida do arquivo original
                    foreach (string line in lines)
                    {
                        // Divide a linha em campos separados por vírgula
                        string[] fields = line.Split(','); // Assumindo que o arquivo está em formato CSV
                        // Atribui os valores dos campos às variáveis correspondentes
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture); // Preço do produto, convertendo de string para double
                        int quantity = int.Parse(fields[2]);  // Quantidade do produto, convertendo de string para int

                        // Cria um objeto Product com os dados extraídos da linha
                        Product prod = new Product(name, price, quantity);

                        // Escreve no arquivo de saída o nome do produto e o valor total (preço * quantidade)
                        // O valor total é formatado com 2 casas decimais
                        sw.WriteLine(prod.Name + "," + prod.ValorTotal().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
