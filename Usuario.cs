using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosMVC
{
    public class Usuario
    {
        private string id {  get; set; }
        private string nome { get; set; }
        private string sobrenome { get; set; }
        private string setor { get; set; }
        private char genero { get; set; }

        public Usuario(string id, string nome, string sobrenome, string setor, char genero)
        {
            this.id = id;
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.setor = setor;
            this.genero = genero;
        }
        public string Id
        {
            get{ return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string SobreNome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }
        public string Setor
        {
            get { return setor; }
            set { setor = value; }
        }
        public char Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public Usuario() { }

    }
}
