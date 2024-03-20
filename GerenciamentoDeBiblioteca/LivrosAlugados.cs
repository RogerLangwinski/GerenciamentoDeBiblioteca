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
            Console.WriteLine(livroAlugado.nome + " " + livroAlugado.sobrenome + " " + livroAlugado.titulo + " " + livroAlugado.autor);
        }


        public void MostrarLivrosAlugados()
        {
            foreach (LivrosAlugados livroAlugado in livrosAlugados)
            {
                string dadosDoAluguel = "\nUsuario: "
                   + livroAlugado.nome 
                   + " " 
                   + livroAlugado.sobrenome
                   +"\nLivros alugados: "
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
