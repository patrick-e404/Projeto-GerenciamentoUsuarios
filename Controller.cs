using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsuariosMVC
{
    public class Controller
    {
        IView usuariosView;
        ListaUsuario usuariosModel;
        public Controller(IView usuariosView, ListaUsuario usuariosModel)
        {
            this.usuariosView = usuariosView;
            this.usuariosModel = usuariosModel;
            usuariosView.SetController(this); 
            AtualizaTable();
        }
        public void Gravar()
        {
            if (Nulo() == true)
            {

                if (usuariosModel.Validacao(usuariosView.Id) != true)
                {
                    usuariosModel.Gravar(new Usuario(usuariosView.Id, usuariosView.Nome, usuariosView.Sobrenome, usuariosView.Setor, (usuariosView.Masculino.Checked) ? 'M' : 'F'));
                    Clear();
                }
                else
                {
                    DialogResult result = MessageBox.Show($"Você está alterando informações do usuario: {usuariosView.Id}?", "Desejar prosseguir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        usuariosModel.Editar(new Usuario(usuariosView.Id, usuariosView.Nome, usuariosView.Sobrenome, usuariosView.Setor, (usuariosView.Masculino.Checked) ? 'M' : 'F'));
                        Clear();
                    }
                }
                AtualizaTable();
                TableEnabled();
            }
        }
        public void ExcluirUsuario()
        {
            if (Nulo())
            {
                DialogResult result = MessageBox.Show("Deseja excluir o usuário este usuario?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    usuariosModel.Excluir(usuariosView.Id);
                    Clear();
                }
                AtualizaTable();
                TableEnabled();
            }
        }
        public void Novo()
        {
            if (Nulo() != true)
            {
                Clear();
            }
        }
        public void AtualizaTable()
        {
            usuariosView.Table.Rows.Clear();
            int i = 1; //contador
            foreach (Usuario obj in usuariosModel.usuarios)
            {
                usuariosView.Table.Rows.Add(i,obj.Id, obj.Nome, obj.SobreNome, obj.Genero, obj.Setor);
                i++;
            }
        }
        private bool Nulo()
        {
            if (!string.IsNullOrEmpty(usuariosView.Id) && !string.IsNullOrEmpty(usuariosView.Nome) && !string.IsNullOrEmpty(usuariosView.Sobrenome) && !string.IsNullOrEmpty(usuariosView.Setor))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Valide todos os campos", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public void RetornarId(string id)
        {
            AtualizaTable();
            foreach (Usuario obj in usuariosModel.usuarios)
            {
                if (obj.Id == id)
                {
                    usuariosView.Id = id;
                    usuariosView.Nome = obj.Nome;
                    usuariosView.Sobrenome = obj.SobreNome;
                    usuariosView.Setor = obj.Setor;
                    if (obj.Genero == 'F')
                    {
                        usuariosView.Feminino.Checked = true;
                    }
                    else
                    {
                        usuariosView.Masculino.Checked = true;
                    }
                }
            }
        }
        public void Clear()
        {
            usuariosView.Id = string.Empty;
            usuariosView.Nome = string.Empty;
            usuariosView.Sobrenome = string.Empty;
            usuariosView.Setor = string.Empty;
        }
        private void TableEnabled()
        {
            if (usuariosModel.QntLista() == false)
            {
                usuariosView.Table.Enabled = false;
            }
            else
            {
                usuariosView.Table.Enabled = true;
            }
        }
        public void Leave()
        {
            if (usuariosView.Id != string.Empty)
            {
                foreach (Usuario obj in usuariosModel.usuarios)
                {
                    if (obj.Id == usuariosView.Id)
                    {
                        usuariosView.Nome = obj.Nome;
                        usuariosView.Sobrenome = obj.SobreNome;
                        usuariosView.Setor = obj.Setor;
                        if (obj.Genero == 'F')
                        {
                            usuariosView.Feminino.Checked = true;
                        }
                        else
                        {
                            usuariosView.Masculino.Checked = true;
                        }
                    }
                }
            }
        }
    }
}