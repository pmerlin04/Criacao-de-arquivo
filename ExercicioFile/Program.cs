using ExercicioFile.Entities;
using System;
using System.Globalization;
using System.IO;

namespace ExercicioFile
{
    class Program
    {
        static void Main(string[] args)
        {
            
             //caminho do arquivo
            string sourcePath = @"d:\C#\Secao13-arquivos\produtos.csv";
           
            //caminho de destino
            string targetPath = @"d:\C#\Secao13-arquivos\out\summary.csv";

            string[] produtos = File.ReadAllLines(sourcePath);

            using (StreamWriter sw = File.AppendText(targetPath))
            {
                foreach (string produto in produtos)
                {
                    string[] nomeProduto = produto.Split(',');

                    string[] precoProduto = produto.Split(',');

                    string[] quantidadeProduto = produto.Split(',');

                    string nome = nomeProduto[0];
                    double preco = double.Parse(precoProduto[1], CultureInfo.InvariantCulture);
                    int quantidade = int.Parse(quantidadeProduto[2]);

                    Produtos p = new Produtos(nome, preco, quantidade);
                    Console.WriteLine();
                    Console.WriteLine(p);

                    Console.WriteLine("total: " + p.Total().ToString("F2"), CultureInfo.InvariantCulture);
                    sw.WriteLine(p);
                }
            }












            /*
            using (StreamWriter sw1 = fileInfo1.AppendText())
            {
               foreach (string line in lines)
               {
                    
                    Console.WriteLine("Qual o nome do produto? ");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Preço do produto? ");
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Quantidade do produto? ");
                    int quantidade = int.Parse(Console.ReadLine());

                    Produtos produto = new Produtos(nome, preco, quantidade);

                    sw1.WriteLine(produto);
                    
               }
            }*/



        }
    }
}
