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
                        Console.WriteLine($"Livro {titulo} adicionado.\n");
                        break;
                    }
                }
            }
            else
            {
                acervoLivros.Add(livro);
                Console.WriteLine($"Livro {titulo} adicionado.\n");
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
                   + livro.Copias;
                Console.WriteLine(dadosDoLivro);
            }

        }

    }
}
