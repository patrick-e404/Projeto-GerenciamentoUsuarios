using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosMVC
{
    public  class ListaUsuario
    {

        private static List<Usuario> usuariosList = new List<Usuario>();
        public List<Usuario> usuarios
        {
            get
            {
                return usuariosList;
            }
        }

        public void Gravar(Usuario dados)
        {
            usuariosList.Add(dados);
        }

        public bool Validacao(string id)
        {
            bool existencia = false;
            foreach (Usuario obj in usuariosList)
            {
                if (obj.Id == id)
                {
                    existencia = true;
                }
            }
            return existencia;
        }

        public bool QntLista()
        {
            return usuariosList.Count > 0;
        }

        public void Editar(Usuario novos_dados)
        {
            foreach (Usuario obj in usuariosList)
            {
                if (obj.Id == novos_dados.Id)
                {
                    obj.Nome = novos_dados.Nome;
                    obj.SobreNome = novos_dados.SobreNome;
                    obj.Setor = novos_dados.Setor;
                    obj.Genero = novos_dados.Genero;
                }
            }
        }

        public void Excluir(string id)
        {
            Usuario user_ = null;
            foreach (Usuario obj in usuariosList)
            {
                if (obj.Id == id)
                {
                    user_ = obj;
                }
            }
            usuariosList.Remove(user_);
        }
    }
}

