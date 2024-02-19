// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Importa a biblioteca System.IO para manipulação de arquivos
using System.IO;

// Importa a biblioteca System para acessar informações do sistema
using System;

// Define a classe Program
class Program
{
    // Define o método Main, que é o ponto de entrada do programa
    static void Main()
    {
        // Obtém o caminho para a Área de Trabalho do usuário atual
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        // Combina o caminho da Área de Trabalho com o nome do arquivo para obter o caminho completo do arquivo
        string filePath = Path.Combine(path, "test.txt");

        // Cria um novo arquivo de texto no caminho especificado e escreve a string "oi" nele
        // Se o arquivo já existir, este método irá sobrescrever o arquivo existente
        File.WriteAllText(filePath, "oi");
        File.WriteAllText(filePath, "quero");
        File.WriteAllText(filePath, "testar");
    }
}
