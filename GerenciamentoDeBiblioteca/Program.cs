using System;
using System.Collections.Generic;


namespace GerenciamentoDeBiblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro();

            Console.WriteLine("Qual operação deseja realizar? Digite um número:");
            Console.WriteLine("1 - Adicionar um livro ao acervo da biblioteca");
            byte operacaoDesejada = byte.Parse(Console.ReadLine());

            while (operacaoDesejada == 1) 
            {
                Console.WriteLine("Qual o titulo do livro?");
                string titulo = Console.ReadLine();

                Console.WriteLine("Qual o autor do livro?");
                string autor = Console.ReadLine();

                Console.WriteLine("Qual a data de publicação?");
                DateTime dataPublicacao = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Qual quantidade desse livro a ser adicionada?");
                byte quantidadeAdicionada = byte.Parse(Console.ReadLine());

                livro.AdicionarLivro(titulo, autor, dataPublicacao, quantidadeAdicionada);

                Console.WriteLine("Deseja continuar adicionando livros? 1-Sim   2-Não");
                operacaoDesejada = byte.Parse(Console.ReadLine());                
            }
            Console.WriteLine("Livros do acervo:\n");
            livro.MostrarLivros();
            Console.ReadLine();
        }
    }
}
