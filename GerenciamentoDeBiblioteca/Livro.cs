using System;
using System.Collections.Generic;


namespace GerenciamentoDeBiblioteca
{
    internal class Livro
    {
        internal string Titulo;
        internal string Autor;
        internal short AnoPublicacao;
        internal byte Copias;
        public List<Livro> acervoLivros = new List<Livro>();        



        public Livro()
        {
        }

        public Livro(string titulo, string autor, short anoPublicacao, byte copias)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anoPublicacao;
            Copias = copias;
        }



        public void AdicionarLivro(string titulo, string autor, short anoPublicacao, byte copias)
        {
            Livro livro = new Livro(titulo, autor, anoPublicacao, copias);

            if (acervoLivros.Count > 0)
            {
                foreach (Livro x in acervoLivros)
                {
                    if (titulo.Equals(x.Titulo))
                    {
                        Console.WriteLine("\n\nLivro já existe no acervo. Nenhum livro adicionado.\n"); ;
                        break;
                    }
                    else
                    {
                        acervoLivros.Add(livro);
                        Console.WriteLine($"\n\nLivro {titulo} adicionado.\n");
                        break;
                    }
                }
            }
            else
            {
                acervoLivros.Add(livro);
                Console.WriteLine($"\n\nLivro {titulo} adicionado.\n");
            }
        }


        public void RemoverLivro(string titulo, string autor, short anoDePublicacao, byte quantidadeRemovida)
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
                        Console.WriteLine($"\n\nLivro disponível. Quantidade: {livro.Copias} cópias.");
                    }
                    else
                    {
                        Console.WriteLine("\n\nLivro não tem cópias disponíveis.");
                    }
                }
                else continue;
            }

            if (nenhumLivroEncontrado == true)
            {
                Console.WriteLine("\n\nLivro não existe no acervo.");
            }

        }
              

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
                   + "ANO DE PUBLICAÇÃO: "
                   + livro.AnoPublicacao.ToString("d");
                Console.WriteLine(dadosDoLivro);
            }

        }

    }
}
