using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsuariosMVC
{
    public partial class FrmUsuarios : Form, IView
    {
        Controller controller;
        public FrmUsuarios()
        {
            InitializeComponent();
        }
        public void SetController(Controller controller_)
        {
            this.controller = controller_;
        }
        public string Id
        {
            get { return txtID.Text; }
            set { txtID.Text = value; }
        }
        public string Nome
        {
            get { return this.txtNome.Text; }
            set { this.txtNome.Text = value; }
        }
        public string Sobrenome
        {
            get { return this.txtSobrenome.Text; }
            set { this.txtSobrenome.Text = value; }
        }
        public string Setor
        {
            get { return this.txtSetor.Text; }
            set { this.txtSetor.Text = value; }
        }
        public RadioButton Feminino
        {
            get { return rdFeminino; }
            set { rdFeminino = value; }
        }
        public RadioButton Masculino
        {
            get
            {
                return rdMasculino;
            }
            set { rdMasculino = value; }
        }
        public DataGridView Table
        {
            get { return grdUsuarios; }
            set { grdUsuarios = value; }
        }

        private void GravarUsuarios(object sender, EventArgs e)
        {
            controller.Gravar();
        }

        private void RetornaId(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                controller.RetornarId((grdUsuarios.Rows[e.RowIndex].Cells[1].Value).ToString());
            }
        }

        private void Excluir(object sender, EventArgs e)
        {
            controller.ExcluirUsuario();
        }

        private void NewUser(object sender, EventArgs e)
        {
            controller.Novo();
        }
    }
}
