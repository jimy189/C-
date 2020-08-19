using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
               string nome;
            int quartos;
            double produto;
            int idade;
            double altura;

            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();
            
            Console.WriteLine("Digite quantos quartos tem: ");
            quartos = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Digite o preço do Produto: ");
            produto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a idade: ");
            idade = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Digite a altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nome Completo: " + nome);
            Console.WriteLine("Numero de Quartos: " + quartos);
            Console.WriteLine("Preço do Produto: " +produto);
            Console.WriteLine("Nome:" + nome + " Idade: " + idade + " Tamanho: "+ altura);
        }
    }
}
