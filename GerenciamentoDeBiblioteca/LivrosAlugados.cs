using System;
using System.Collections.Generic;

namespace GerenciamentoDeBiblioteca
{
    class LivrosAlugados
    {
        internal List<LivrosAlugados> livrosAlugados = new List<LivrosAlugados>();
        internal string nome;
        internal string sobrenome;
        internal string titulo;
        internal string autor;
        public Livro livro = new Livro();

        public LivrosAlugados()
        {
        }

        public LivrosAlugados(string nome, string sobrenome, string titulo, string autor)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.titulo = titulo;
            this.autor = autor;
        }

        public void AdicionarLivroAlugado(LivrosAlugados livroAlugado)
        {
            livrosAlugados.Add(livroAlugado);
        }


        public void DevolverLivro(string titulo, string autor, string usuarioNome, string usuarioSobrenome)
        {
            foreach (LivrosAlugados livroAlugado in livrosAlugados)
            {
                if (titulo.Equals(livroAlugado.titulo) && autor.Equals(livroAlugado.autor) && usuarioNome.Equals(livroAlugado.nome) && usuarioSobrenome.Equals(livroAlugado.sobrenome))
                {
                    livrosAlugados.Remove(livroAlugado);                  
                    break;
                }
            }
        }


        public void MostrarLivrosAlugados()
        {
            foreach (LivrosAlugados livroAlugado in livrosAlugados)
            {
                string dadosDoAluguel = "Usuario: "
                   + livroAlugado.nome
                   + " "
                   + livroAlugado.sobrenome
                   + "\nLivros alugados: "
                   + "TÍTULO: "
                   + livroAlugado.titulo
                   + ", "
                   + "AUTOR: "
                   + livroAlugado.autor;
                Console.WriteLine(dadosDoAluguel);
            }
        }

    }
}
