using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeBiblioteca
{
    internal class Livro
    {
        private string Titulo;
        private string Autor;
        private DateTime DataPublicacao;
        private byte Copias;
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
            acervoLivros.Add(livro);
        }


        public void RemoverLivro(string titulo, string autor, byte quantidadeRemovida)
        {
            foreach (Livro livro in acervoLivros)
            {
                if (titulo.Equals(livro.Titulo) && autor.Equals(livro.Autor) && livro.Copias > quantidadeRemovida)
                {
                    livro.Copias -= quantidadeRemovida;
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
                Console.WriteLine(dadosDoLivro + "\n");
            }
            
        }
        
    }
}
