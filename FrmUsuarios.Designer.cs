namespace UsuariosMVC
{
  partial class FrmUsuarios
  {
    /// <summary>
    /// Variável de designer necessária.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpar os recursos que estão sendo usados.
    /// </summary>
    /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código gerado pelo Windows Form Designer

    /// <summary>
    /// Método necessário para suporte ao Designer - não modifique 
    /// o conteúdo deste método com o editor de código.
    /// </summary>
    private void InitializeComponent()
    {
            this.btnExcluir = new System.Windows.Forms.Button();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.grbSex = new System.Windows.Forms.GroupBox();
            this.rdFeminino = new System.Windows.Forms.RadioButton();
            this.rdMasculino = new System.Windows.Forms.RadioButton();
            this.txtSetor = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.grdUsuarios = new System.Windows.Forms.DataGridView();
            this.Numeracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SobreNome_table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo_table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento_table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDetails.SuspendLayout();
            this.grbSex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(855, 68);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(129, 28);
            this.btnExcluir.TabIndex = 37;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.Excluir);
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.grbSex);
            this.grpDetails.Controls.Add(this.txtSetor);
            this.grpDetails.Controls.Add(this.lblDepartment);
            this.grpDetails.Controls.Add(this.txtID);
            this.grpDetails.Controls.Add(this.lblID);
            this.grpDetails.Controls.Add(this.txtSobrenome);
            this.grpDetails.Controls.Add(this.lblLastName);
            this.grpDetails.Controls.Add(this.txtNome);
            this.grpDetails.Controls.Add(this.lblFirstName);
            this.grpDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpDetails.Location = new System.Drawing.Point(16, 7);
            this.grpDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDetails.Size = new System.Drawing.Size(819, 177);
            this.grpDetails.TabIndex = 39;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Registrar Novo Usuário";
            // 
            // grbSex
            // 
            this.grbSex.Controls.Add(this.rdFeminino);
            this.grbSex.Controls.Add(this.rdMasculino);
            this.grbSex.ForeColor = System.Drawing.SystemColors.MenuText;
            this.grbSex.Location = new System.Drawing.Point(13, 97);
            this.grbSex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbSex.Name = "grbSex";
            this.grbSex.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbSex.Size = new System.Drawing.Size(347, 66);
            this.grbSex.TabIndex = 29;
            this.grbSex.TabStop = false;
            this.grbSex.Text = "Sexo";
            // 
            // rdFeminino
            // 
            this.rdFeminino.Location = new System.Drawing.Point(203, 23);
            this.rdFeminino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdFeminino.Name = "rdFeminino";
            this.rdFeminino.Size = new System.Drawing.Size(136, 30);
            this.rdFeminino.TabIndex = 5;
            this.rdFeminino.Text = "Feminino";
            // 
            // rdMasculino
            // 
            this.rdMasculino.Checked = true;
            this.rdMasculino.Location = new System.Drawing.Point(43, 23);
            this.rdMasculino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdMasculino.Name = "rdMasculino";
            this.rdMasculino.Size = new System.Drawing.Size(99, 30);
            this.rdMasculino.TabIndex = 4;
            this.rdMasculino.TabStop = true;
            this.rdMasculino.Text = "Masculino";
            // 
            // txtSetor
            // 
            this.txtSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetor.Location = new System.Drawing.Point(539, 22);
            this.txtSetor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSetor.Name = "txtSetor";
            this.txtSetor.Size = new System.Drawing.Size(271, 26);
            this.txtSetor.TabIndex = 27;
            // 
            // lblDepartment
            // 
            this.lblDepartment.Location = new System.Drawing.Point(423, 23);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(119, 21);
            this.lblDepartment.TabIndex = 28;
            this.lblDepartment.Text = "Departamento:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(69, 25);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(289, 26);
            this.txtID.TabIndex = 5;
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(39, 25);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(29, 25);
            this.lblID.TabIndex = 25;
            this.lblID.Text = "ID:";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrenome.Location = new System.Drawing.Point(539, 66);
            this.txtSobrenome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(271, 26);
            this.txtSobrenome.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(436, 69);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(95, 18);
            this.lblLastName.TabIndex = 23;
            this.lblLastName.Text = "Sobrenome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(69, 62);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(291, 26);
            this.txtNome.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(11, 66);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 22);
            this.lblFirstName.TabIndex = 19;
            this.lblFirstName.Text = "Nome:";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(855, 105);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(129, 28);
            this.btnNovo.TabIndex = 36;
            this.btnNovo.Text = "&Novo ";
            this.btnNovo.Click += new System.EventHandler(this.NewUser);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(855, 32);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(129, 28);
            this.btnGravar.TabIndex = 38;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.Click += new System.EventHandler(this.GravarUsuarios);
            // 
            // grdUsuarios
            // 
            this.grdUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numeracao,
            this.ID_table,
            this.Nome_table,
            this.SobreNome_table,
            this.Sexo_table,
            this.Departamento_table});
            this.grdUsuarios.Location = new System.Drawing.Point(12, 191);
            this.grdUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdUsuarios.Name = "grdUsuarios";
            this.grdUsuarios.RowHeadersWidth = 51;
            this.grdUsuarios.RowTemplate.Height = 24;
            this.grdUsuarios.Size = new System.Drawing.Size(972, 362);
            this.grdUsuarios.TabIndex = 40;
            this.grdUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RetornaId);
            // 
            // Numeracao
            // 
            this.Numeracao.HeaderText = "N°";
            this.Numeracao.MinimumWidth = 6;
            this.Numeracao.Name = "Numeracao";
            this.Numeracao.Width = 50;
            // 
            // ID_table
            // 
            this.ID_table.HeaderText = "ID";
            this.ID_table.MinimumWidth = 6;
            this.ID_table.Name = "ID_table";
            this.ID_table.Width = 50;
            // 
            // Nome_table
            // 
            this.Nome_table.HeaderText = "Nome";
            this.Nome_table.MinimumWidth = 6;
            this.Nome_table.Name = "Nome_table";
            this.Nome_table.Width = 150;
            // 
            // SobreNome_table
            // 
            this.SobreNome_table.HeaderText = "SobreNome";
            this.SobreNome_table.MinimumWidth = 6;
            this.SobreNome_table.Name = "SobreNome_table";
            this.SobreNome_table.Width = 150;
            // 
            // Sexo_table
            // 
            this.Sexo_table.HeaderText = "Sexo";
            this.Sexo_table.MinimumWidth = 6;
            this.Sexo_table.Name = "Sexo_table";
            this.Sexo_table.Width = 50;
            // 
            // Departamento_table
            // 
            this.Departamento_table.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Departamento_table.HeaderText = "Departamento";
            this.Departamento_table.MinimumWidth = 6;
            this.Departamento_table.Name = "Departamento_table";
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 565);
            this.Controls.Add(this.grdUsuarios);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnGravar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmUsuarios";
            this.Text = "Usuários Ativos";
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.grbSex.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion
    internal System.Windows.Forms.Button btnExcluir;
    internal System.Windows.Forms.GroupBox grpDetails;
    private System.Windows.Forms.GroupBox grbSex;
    internal System.Windows.Forms.RadioButton rdFeminino;
    internal System.Windows.Forms.RadioButton rdMasculino;
    internal System.Windows.Forms.TextBox txtSetor;
    internal System.Windows.Forms.Label lblDepartment;
    internal System.Windows.Forms.TextBox txtID;
    internal System.Windows.Forms.Label lblID;
    internal System.Windows.Forms.TextBox txtSobrenome;
    internal System.Windows.Forms.Label lblLastName;
    internal System.Windows.Forms.TextBox txtNome;
    internal System.Windows.Forms.Label lblFirstName;
    internal System.Windows.Forms.Button btnNovo;
    internal System.Windows.Forms.Button btnGravar;
    private System.Windows.Forms.DataGridView grdUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numeracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn SobreNome_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento_table;
    }
}

