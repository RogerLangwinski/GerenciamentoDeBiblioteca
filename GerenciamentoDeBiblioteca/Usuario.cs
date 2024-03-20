using System;
using System.Collections.Generic;


namespace GerenciamentoDeBiblioteca
{
    class Usuario
    {        
        internal string Nome;
        internal string SobreNome;
        internal List<Usuario> listaDeUsuarios = new List<Usuario>();

        public Usuario()
        {
        }

        public Usuario(string nome, string sobreNome)
        {            
            Nome = nome;
            SobreNome = sobreNome;            
        }


        public void AdicionarUsuario(Usuario usuario)
        {
            listaDeUsuarios.Add(usuario);
        }



        public bool VerificaUsuario(string nome, string sobrenome)
        {
            bool usuarioEncontrado = false;

            foreach (Usuario usuario in listaDeUsuarios)
            {
                if (nome.Equals(usuario.Nome) && sobrenome.Equals(usuario.SobreNome))
                {
                    usuarioEncontrado = true;
                    break;
                }
                else continue;
            }
            if (usuarioEncontrado == true) return true;
            else return false;
        }        
    }
}
