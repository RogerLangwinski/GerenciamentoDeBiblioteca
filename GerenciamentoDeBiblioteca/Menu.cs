using System;


namespace GerenciamentoDeBiblioteca
{
    class Menu
    {
        internal byte operacaoDesejada;
        Livro livro = new Livro();
        LivrosAlugados livrosAlugados = new LivrosAlugados();



        public void MenuGeral()
        {
            Console.WriteLine("\n\nQual operação deseja realizar? Digite um número:\n"
            + "1 - Adicionar um livro ao acervo da biblioteca\n"
            + "2 - Remover um livro do acervo da biblioteca\n"
            + "3 - Consultar se um livro está disponível para aluguel\n"
            + "4 - Aluguel de um livro para um usuário registrado\n"
            + "5 - Devolução de um livro alugado\n"
            + "6 - Mostrar todos os livros\n"
            + "7 - Mostrar todos os livros alugados\n"
            + "Outro dígito - Sair");
            operacaoDesejada = byte.Parse(Console.ReadLine());
            Console.WriteLine("\n");

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
            Console.WriteLine("\n\nQual o titulo do livro?");
            string titulo = Console.ReadLine();

            Console.WriteLine("\nQual o autor do livro?");
            string autor = Console.ReadLine();

            Console.WriteLine("\nQual o ano de publicação?");
            short anoPublicacao = short.Parse(Console.ReadLine());


            Console.WriteLine("\nQual quantidade de copias?");
            byte quantidade = byte.Parse(Console.ReadLine());

            livro.Titulo = titulo;
            livro.Autor = autor;
            livro.AnoPublicacao = anoPublicacao;
            livro.Copias = quantidade;
        }


        public void MenuAdicionarLivro()
        {
            MenuFormularioPadrao();
            livro.AdicionarLivro(livro.Titulo, livro.Autor, livro.AnoPublicacao, livro.Copias);

            MenuGeral();
        }


        public void MenuRemoverLivro()
        {
            MenuFormularioPadrao();
            livro.RemoverLivro(livro.Titulo, livro.Autor, livro.AnoPublicacao, livro.Copias);

            MenuGeral();
        }


        public void MenuConsultarLivro()
        {
            Console.WriteLine("\n\nQual título gostaria de consultar?");
            string consultarTitulo = Console.ReadLine();
            livro.ConsultarLivro(consultarTitulo);

            MenuGeral();
        }


        public void MenuAlugarLivro()
        {
            Console.WriteLine("\n\nQual título gostaria de alugar?");
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

            LivrosAlugados livroAlugado = new LivrosAlugados(nomeUsuario, sobrenomeUsuario, alugarTitulo, alugarAutor);
            livrosAlugados.AdicionarLivroAlugado(livroAlugado);

            foreach (Livro livro in livro.acervoLivros)
            {
                if (alugarTitulo.Equals(livro.Titulo) && alugarAutor.Equals(livro.Autor))
                {
                    livro.Copias -= 1;
                    break;
                }
            }

            MenuGeral();
        }


        public void MenuDevolverLivro()
        {
            Console.WriteLine("\n\nQual título será devolvido?");
            string devolverTitulo = Console.ReadLine();
            Console.WriteLine("Qual autor do livro?");
            string devolverAutor = Console.ReadLine();
            Console.WriteLine("Qual primeiro nome do usuário está devolvendo?");
            string devolverUsuarioNome = Console.ReadLine();
            Console.WriteLine("Qual sobrenome do usuário está devolvendo?");
            string devolverUsuarioSobrenome = Console.ReadLine();

            livrosAlugados.DevolverLivro(devolverTitulo, devolverAutor, devolverUsuarioNome, devolverUsuarioSobrenome);
            foreach (Livro livro in livro.acervoLivros)
            {
                if (devolverTitulo.Equals(livro.Titulo) && devolverAutor.Equals(livro.Autor))
                {
                    livro.Copias++;
                    break;
                }
            }
            MenuGeral();
        }


            public void MenuMostrarTodosLivros()
            {
                Console.WriteLine("\n\nLIVROS DO ACERVO:");
                livro.MostrarLivros();
                MenuGeral();
            }


            public void MenuMostrarTodosLivrosAlugados()
            {
                livrosAlugados.MostrarLivrosAlugados();
                MenuGeral();
            }
        }
    }
