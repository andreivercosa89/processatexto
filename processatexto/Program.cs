using System;

namespace processatexto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            Console.WriteLine("Informe o nome completo: ");
            nome = Console.ReadLine();

            Console.WriteLine("1 - Imprime o nome: " + nome);
            Console.WriteLine("2 - Imprime o 1 caracter: " + nome.Substring(0,1));
            Console.WriteLine("3 - Quantidade caracter: " + nome.Length);
            Console.WriteLine("4 - Ultimo caracter: " + nome.Substring(nome.Length -1,1));
            Console.WriteLine("5 - Ate o 3 caracter: " + nome.Substring(0, 3));
            Console.WriteLine("6 - O 4 caracter da cadeia : " + nome.Substring(3,1));
            Console.WriteLine("7 - Todos os caracter menos o primeiro: " + nome.Substring(1));
            Console.WriteLine("8 - Os Dois Ultimos: " + nome.Substring(nome.Length - 2,2));
        }
    }
}
