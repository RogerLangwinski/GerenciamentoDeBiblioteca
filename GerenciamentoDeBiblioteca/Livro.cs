using System;
using System.Collections.Generic;


namespace GerenciamentoDeBiblioteca
{
    internal class Livro
    {
        internal string Titulo;
        internal string Autor;
        internal DateTime DataPublicacao;
        internal byte Copias;
        List<Livro> acervoLivros = new List<Livro>();
        LivrosAlugados livroAlugado = new LivrosAlugados();



        public Livro()
        {
        }

        public Livro(string titulo, string autor, DateTime dataPublicacao, byte copias)
        {
            Titulo = titulo;
            Autor = autor;
            DataPublicacao = dataPublicacao;
            Copias = copias;
        }



        public void AdicionarLivro(string titulo, string autor, DateTime dataPublicacao, byte copias)
        {
            Livro livro = new Livro(titulo, autor, dataPublicacao, copias);

            if (acervoLivros.Count > 0)
            {
                foreach (Livro x in acervoLivros)
                {
                    if (titulo.Equals(x.Titulo))
                    {
                        Console.WriteLine("Livro já existe no acervo. Nenhum livro adicionado.\n"); ;
                        break;
                    }
                    else
                    {
                        acervoLivros.Add(livro);
                        Console.WriteLine($"\nLivro {titulo} adicionado.\n");
                        break;
                    }
                }
            }
            else
            {
                acervoLivros.Add(livro);
                Console.WriteLine($"\nLivro {titulo} adicionado.\n");
            }
        }


        public void RemoverLivro(string titulo, string autor, DateTime dataDePublicacao, byte quantidadeRemovida)
        {
            foreach (Livro livro in acervoLivros)
            {
                if (titulo.Equals(livro.Titulo) && autor.Equals(livro.Autor) && livro.Copias > quantidadeRemovida)
                {
                    livro.Copias -= quantidadeRemovida;
                    break;
                }
            }
        }


        public void ConsultarLivro(string titulo)
        {
            bool nenhumLivroEncontrado = true;

            foreach (Livro livro in acervoLivros)
            {
                if (titulo.Equals(livro.Titulo))
                {
                    nenhumLivroEncontrado = false;

                    if (livro.Copias > 0)
                    {
                        Console.WriteLine($"Livro disponível. Quantidade: {livro.Copias} cópias.");
                    }
                    else
                    {
                        Console.WriteLine("Livro não tem cópias disponíveis.");
                    }
                }
                else continue;
            }

            if (nenhumLivroEncontrado == true)
            {
                Console.WriteLine("Livro não existe no acervo.");
            }

        }

        /* TRECHO DE CÓDIGO INUTILIZADO APÓS AJUDA DO ITAMAR MENCIONADA NA CLASSE MENU
        public void EmprestarLivro(string titulo, string autor, Usuario usuario)
        {
            livroAlugado.nome = usuario.Nome;
            livroAlugado.sobrenome = usuario.SobreNome;
            livroAlugado.titulo = titulo;
            livroAlugado.autor = autor;
            livroAlugado.AdicionarLivroAlugado(livroAlugado);


            bool existeUsuario = usuario.VerificaUsuario(usuario.Nome, usuario.SobreNome);

            if (existeUsuario == true)
            {
                foreach (Livro livro in acervoLivros)
                {
                    if (titulo.Equals(livro.Titulo) && autor.Equals(livro.Autor))
                    {
                        LivrosAlugados livroAlugado = new LivrosAlugados(usuario.Nome, usuario.SobreNome, titulo, autor);
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else
            {
                LivrosAlugados livroAlugado = new LivrosAlugados(usuario.Nome, usuario.SobreNome, titulo, autor);
            }
        }*/



        public void MostrarLivros()
        {
            foreach (Livro livro in acervoLivros)
            {
                string dadosDoLivro = "TÍTULO: "
                   + livro.Titulo
                   + ", "
                   + "AUTOR: "
                   + livro.Autor
                   + ", "
                   + "COPIAS: "
                   + livro.Copias
                   + ", "
                   + "DATA DE PUBLICAÇÃO: "
                   + livro.DataPublicacao.ToString("d");
                Console.WriteLine(dadosDoLivro);
            }

        }

    }
}
