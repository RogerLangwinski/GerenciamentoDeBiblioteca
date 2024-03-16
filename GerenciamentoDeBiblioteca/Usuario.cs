using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeBiblioteca
{
    class Usuario
    {        
        internal string Nome;
        internal string SobreNome;
        internal List<Usuario> listaDeUsuarios = new List<Usuario>();
        internal List<Livro> livrosAlugados = new List<Livro>();



        public Usuario(string nome, string sobreNome)
        {
            Usuario usuario = new Usuario(nome, sobreNome);
            usuario.Nome = nome;
            usuario.SobreNome = sobreNome;
            listaDeUsuarios.Add(usuario);
        }


        
    }
}
