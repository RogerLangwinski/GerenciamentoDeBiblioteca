﻿using System;


namespace GerenciamentoDeBiblioteca
{
    class Menu
    {
        internal byte operacaoDesejada;
        Livro livro = new Livro();
        LivrosAlugados livrosAlugados = new LivrosAlugados();


        public void MenuGeral()
        {
            Console.WriteLine("\nQual operação deseja realizar? Digite um número:\n");
            Console.WriteLine("1 - Adicionar um livro ao acervo da biblioteca");
            Console.WriteLine("2 - Remover um livro do acervo da biblioteca");
            Console.WriteLine("3 - Consultar se um livro está disponível para aluguel");
            Console.WriteLine("4 - Aluguel de um livro para um usuário registrado");
            Console.WriteLine("5 - Devolução de um livro alugado");
            Console.WriteLine("6 - Mostrar todos os livros"); 
            Console.WriteLine("7 - Mostrar todos os livros alugados");
            Console.WriteLine("Outro dígito - Sair");
            operacaoDesejada = byte.Parse(Console.ReadLine());

            switch (operacaoDesejada)
            {
                case 1:
                    MenuAdicionarLivro();
                    break;
                case 2:
                    MenuRemoverLivro();
                    break;
                case 3:
                    MenuConsultarLivro();
                    break;
                case 4:
                    MenuAlugarLivro();
                    break;
                case 5:
                    MenuDevolverLivro();
                    break;
                case 6:
                    MenuMostrarTodosLivros();
                    break;
                case 7:
                    MenuMostrarTodosLivrosAlugados();
                    break;
            }
        }


        public void MenuFormularioPadrao()
        {
            Console.WriteLine("\nQual o titulo do livro?");
            string titulo = Console.ReadLine();

            Console.WriteLine("\nQual o autor do livro?");
            string autor = Console.ReadLine();

            Console.WriteLine("\nQual a data de publicação? (dd/mm/aaaa)");
            DateTime dataPublicacao;

            while (true)
            {
                try
                {
                    dataPublicacao = DateTime.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Data inválida! {e.Message}. Cadastre a data novamente (dd/mm/aaaa).");
                }
            }
            
            Console.WriteLine("\nQual quantidade de copias?");
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
            Console.WriteLine("\nQual título gostaria de consultar?");
            string consultarTitulo = Console.ReadLine();
            livro.ConsultarLivro(consultarTitulo);

            MenuGeral();
        }


        public void MenuAlugarLivro()
        {
            Console.WriteLine("\nQual título gostaria de alugar?");
            string alugarTitulo = Console.ReadLine();
            Console.WriteLine("\nQual autor do livro?");
            string alugarAutor = Console.ReadLine();            
            Console.WriteLine("Para qual usuário será alugado o livro?");
            Console.Write("Nome: ");
            string nomeUsuario = Console.ReadLine();
            Console.Write("Sobrenome: ");
            string sobrenomeUsuario = Console.ReadLine();

            Usuario usuario = new Usuario(nomeUsuario, sobrenomeUsuario);
            usuario.AdicionarUsuario(usuario);

            /* AS DUAS LINHAS ABAIXO FORAM IMPLEMENTADAS
             APÓS RECEBER AJUDA DO DEV ITAMAR POIS EU
             NÃO ESTAVA CONSEGUINDO REGISTRAR O LIVRO
             ALUGADO NA LISTA LIVROSALUGADOS */
            LivrosAlugados livroAlugado = new LivrosAlugados(nomeUsuario, sobrenomeUsuario, alugarTitulo, alugarAutor);
            livrosAlugados.AdicionarLivroAlugado(livroAlugado);

            MenuGeral();
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


        public void MenuMostrarTodosLivrosAlugados()
        {            
            livrosAlugados.MostrarLivrosAlugados();
            MenuGeral();
        }
    }
}
