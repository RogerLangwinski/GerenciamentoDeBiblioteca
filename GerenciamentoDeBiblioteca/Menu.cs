using System;

namespace GerenciamentoDeBiblioteca
{
    class Menu
    {
        internal byte operacaoDesejada;
        Livro livro = new Livro();


        public void MenuGeral()
        {
            Console.WriteLine("Qual operação deseja realizar? Digite um número:\n");
            Console.WriteLine("1 - Adicionar um livro ao acervo da biblioteca");
            Console.WriteLine("2 - Remover um livro do acervo da biblioteca");
            Console.WriteLine("3 - Verificar se um livro está disponível para empréstimo");
            Console.WriteLine("4 - Empréstimo de um livro para um usuário registrado");
            Console.WriteLine("5 - Devolução de um livro emprestado");
            Console.WriteLine("6 - Mostrar todos os livros");
            Console.WriteLine("Outro dígito - Sair");
            operacaoDesejada = byte.Parse(Console.ReadLine());

            while (operacaoDesejada >= 1 && operacaoDesejada <= 6)
            {
                if (operacaoDesejada == 1)
                {
                    MenuAdicionarLivro();
                }
                else if (operacaoDesejada == 2)
                {
                    MenuRemoverLivro();
                }
                else if (operacaoDesejada == 3)
                {
                    MenuConsultarLivro();
                }
                else if (operacaoDesejada == 4)
                {
                    MenuEmprestarLivro();
                }
                else if (operacaoDesejada == 5)
                {
                    MenuDevolverLivro();
                }
                else if (operacaoDesejada == 6)
                {
                    MenuMostrarTodosLivros();
                }
            }
        }


        public void MenuFormularioPadrao()
        {
            Console.WriteLine("Qual o titulo do livro?");
            string titulo = Console.ReadLine();

            Console.WriteLine("Qual o autor do livro?");
            string autor = Console.ReadLine();

            Console.WriteLine("Qual a data de publicação?");
            DateTime dataPublicacao = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Qual quantidade de copias?");
            byte quantidade = byte.Parse(Console.ReadLine());

            livro.Titulo = titulo;
            livro.Autor = autor;
            livro.DataPublicacao = dataPublicacao;
            livro.Copias = quantidade;
        }


        public void MenuAdicionarLivro()
        {
            MenuFormularioPadrao();
            livro.AdicionarLivro(livro.Titulo, livro.Autor, livro.DataPublicacao, livro.Copias);

            MenuGeral();
        }


        public void MenuRemoverLivro()
        {
            MenuFormularioPadrao();
            livro.RemoverLivro(livro.Titulo, livro.Autor, livro.DataPublicacao, livro.Copias);

            MenuGeral();
        }


        public void MenuConsultarLivro()
        {

        }


        public void MenuEmprestarLivro()
        {

        }


        public void MenuDevolverLivro()
        {

        }


        public void MenuMostrarTodosLivros()
        {
            Console.WriteLine("\nLIVROS DO ACERVO:");
            livro.MostrarLivros();
            Console.ReadLine();
            MenuGeral();
        }


    }
}
