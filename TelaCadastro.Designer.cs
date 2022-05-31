
namespace AppTelaClinicaVeterinária
{
    partial class TelaCadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.Label();
            this.txtNomePet = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtExcluir = new System.Windows.Forms.Button();
            this.TxtListar = new System.Windows.Forms.Button();
            this.dgListar = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomePet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tstNome = new System.Windows.Forms.TextBox();
            this.tstEmail = new System.Windows.Forms.TextBox();
            this.tstSenha = new System.Windows.Forms.TextBox();
            this.tstConfSenha = new System.Windows.Forms.TextBox();
            this.tstEndereco = new System.Windows.Forms.TextBox();
            this.tstPEt = new System.Windows.Forms.TextBox();
            this.lbTel = new System.Windows.Forms.Label();
            this.tstTelefone = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgListar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.Location = new System.Drawing.Point(715, 85);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(96, 15);
            this.txtNome.TabIndex = 0;
            this.txtNome.Text = "Nome Completo";
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(496, 19);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(36, 15);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Text = "Email";
            // 
            // txtSenha
            // 
            this.txtSenha.AutoSize = true;
            this.txtSenha.Location = new System.Drawing.Point(250, 85);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(39, 15);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.Text = "Senha";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.AutoSize = true;
            this.txtConfirmarSenha.Location = new System.Drawing.Point(223, 156);
            this.txtConfirmarSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(96, 15);
            this.txtConfirmarSenha.TabIndex = 3;
            this.txtConfirmarSenha.Text = "Confirmar Senha";
            // 
            // txtEndereco
            // 
            this.txtEndereco.AutoSize = true;
            this.txtEndereco.Location = new System.Drawing.Point(732, 156);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(56, 15);
            this.txtEndereco.TabIndex = 4;
            this.txtEndereco.Text = "Endereço";
            // 
            // txtNomePet
            // 
            this.txtNomePet.AutoSize = true;
            this.txtNomePet.Location = new System.Drawing.Point(230, 225);
            this.txtNomePet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtNomePet.Name = "txtNomePet";
            this.txtNomePet.Size = new System.Drawing.Size(77, 15);
            this.txtNomePet.TabIndex = 6;
            this.txtNomePet.Text = "Nome do Pet";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(161, 304);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 14;
            this.btnInserir.Text = "Salvar";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtExcluir
            // 
            this.txtExcluir.Location = new System.Drawing.Point(480, 303);
            this.txtExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.txtExcluir.Name = "txtExcluir";
            this.txtExcluir.Size = new System.Drawing.Size(75, 23);
            this.txtExcluir.TabIndex = 15;
            this.txtExcluir.Text = "Excluir";
            this.txtExcluir.UseVisualStyleBackColor = true;
            this.txtExcluir.Click += new System.EventHandler(this.txtExcluir_Click);
            // 
            // TxtListar
            // 
            this.TxtListar.Location = new System.Drawing.Point(645, 304);
            this.TxtListar.Margin = new System.Windows.Forms.Padding(2);
            this.TxtListar.Name = "TxtListar";
            this.TxtListar.Size = new System.Drawing.Size(75, 23);
            this.TxtListar.TabIndex = 17;
            this.TxtListar.Text = "Listar";
            this.TxtListar.UseVisualStyleBackColor = true;
            this.TxtListar.Click += new System.EventHandler(this.TxtListar_Click);
            // 
            // dgListar
            // 
            this.dgListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Email,
            this.Endereço,
            this.Telefone,
            this.NomePet});
            this.dgListar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgListar.Location = new System.Drawing.Point(154, 332);
            this.dgListar.Margin = new System.Windows.Forms.Padding(2);
            this.dgListar.Name = "dgListar";
            this.dgListar.ReadOnly = true;
            this.dgListar.RowTemplate.Height = 25;
            this.dgListar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgListar.Size = new System.Drawing.Size(722, 104);
            this.dgListar.TabIndex = 19;
            this.dgListar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListar_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 113;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 135;
            // 
            // Endereço
            // 
            this.Endereço.HeaderText = "Endereço";
            this.Endereço.Name = "Endereço";
            this.Endereço.ReadOnly = true;
            this.Endereço.Width = 150;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Width = 120;
            // 
            // NomePet
            // 
            this.NomePet.HeaderText = "Nome do Pet";
            this.NomePet.Name = "NomePet";
            this.NomePet.ReadOnly = true;
            this.NomePet.Width = 112;
            // 
            // tstNome
            // 
            this.tstNome.Location = new System.Drawing.Point(646, 113);
            this.tstNome.Margin = new System.Windows.Forms.Padding(2);
            this.tstNome.Name = "tstNome";
            this.tstNome.Size = new System.Drawing.Size(230, 23);
            this.tstNome.TabIndex = 29;
            // 
            // tstEmail
            // 
            this.tstEmail.Location = new System.Drawing.Point(381, 47);
            this.tstEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tstEmail.Name = "tstEmail";
            this.tstEmail.Size = new System.Drawing.Size(282, 23);
            this.tstEmail.TabIndex = 30;
            // 
            // tstSenha
            // 
            this.tstSenha.Location = new System.Drawing.Point(154, 113);
            this.tstSenha.Margin = new System.Windows.Forms.Padding(2);
            this.tstSenha.Name = "tstSenha";
            this.tstSenha.PasswordChar = '*';
            this.tstSenha.Size = new System.Drawing.Size(233, 23);
            this.tstSenha.TabIndex = 31;
            // 
            // tstConfSenha
            // 
            this.tstConfSenha.Location = new System.Drawing.Point(154, 184);
            this.tstConfSenha.Margin = new System.Windows.Forms.Padding(2);
            this.tstConfSenha.Name = "tstConfSenha";
            this.tstConfSenha.PasswordChar = '*';
            this.tstConfSenha.Size = new System.Drawing.Size(233, 23);
            this.tstConfSenha.TabIndex = 32;
            // 
            // tstEndereco
            // 
            this.tstEndereco.Location = new System.Drawing.Point(646, 184);
            this.tstEndereco.Margin = new System.Windows.Forms.Padding(2);
            this.tstEndereco.Name = "tstEndereco";
            this.tstEndereco.Size = new System.Drawing.Size(230, 23);
            this.tstEndereco.TabIndex = 33;
            // 
            // tstPEt
            // 
            this.tstPEt.Location = new System.Drawing.Point(154, 253);
            this.tstPEt.Margin = new System.Windows.Forms.Padding(2);
            this.tstPEt.Name = "tstPEt";
            this.tstPEt.Size = new System.Drawing.Size(233, 23);
            this.tstPEt.TabIndex = 34;
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Location = new System.Drawing.Point(736, 225);
            this.lbTel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(51, 15);
            this.lbTel.TabIndex = 35;
            this.lbTel.Text = "Telefone";
            // 
            // tstTelefone
            // 
            this.tstTelefone.Location = new System.Drawing.Point(646, 253);
            this.tstTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.tstTelefone.Name = "tstTelefone";
            this.tstTelefone.Size = new System.Drawing.Size(230, 23);
            this.tstTelefone.TabIndex = 36;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(319, 303);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 37;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnVerSenha_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(815, 304);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(61, 23);
            this.txtId.TabIndex = 38;
            this.txtId.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(793, 308);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 15);
            this.lblId.TabIndex = 39;
            this.lblId.Text = "ID";
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(230)))), ((int)(((byte)(226)))));
            this.BackgroundImage = global::AppTelaClinicaVeterinária.Properties.Resources.R;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1029, 440);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.tstTelefone);
            this.Controls.Add(this.lbTel);
            this.Controls.Add(this.tstPEt);
            this.Controls.Add(this.tstEndereco);
            this.Controls.Add(this.tstConfSenha);
            this.Controls.Add(this.tstSenha);
            this.Controls.Add(this.tstEmail);
            this.Controls.Add(this.tstNome);
            this.Controls.Add(this.dgListar);
            this.Controls.Add(this.TxtListar);
            this.Controls.Add(this.txtExcluir);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtNomePet);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtConfirmarSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "TelaCadastro";
            this.Text = "Cadastro de Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.dgListar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label txtSenha;
        private System.Windows.Forms.Label txtConfirmarSenha;
        private System.Windows.Forms.Label txtEndereco;
        private System.Windows.Forms.Label txtNomePet;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button txtExcluir;
        private System.Windows.Forms.Button TxtListar;
        private System.Windows.Forms.DataGridView dgListar;
        private System.Windows.Forms.TextBox tstNome;
        private System.Windows.Forms.TextBox tstEmail;
        private System.Windows.Forms.TextBox tstSenha;
        private System.Windows.Forms.TextBox tstConfSenha;
        private System.Windows.Forms.TextBox tstEndereco;
        private System.Windows.Forms.TextBox tstPEt;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.TextBox tstTelefone;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereço;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePet;
    }
}

