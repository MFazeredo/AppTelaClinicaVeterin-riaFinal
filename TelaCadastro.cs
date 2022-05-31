using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTelaClinicaVeterinária
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
            Limpar();
            Listar();
        }

        private BffUsuario BffUsuario = new BffUsuario();
        private void btnInserir_Click(object sender, EventArgs e)
        {
            BffUsuario.objEntidadeUsuario.Nome = tstNome.Text;
            BffUsuario.objEntidadeUsuario.Email = tstEmail.Text;
            BffUsuario.objEntidadeUsuario.Senha = tstSenha.Text;
            BffUsuario.objEntidadeUsuario.ConfSenha = tstConfSenha.Text;
            BffUsuario.objEntidadeUsuario.Endereco = tstEndereco.Text;
            BffUsuario.objEntidadeUsuario.Telefone = tstTelefone.Text;
            BffUsuario.objEntidadeUsuario.Pet = tstPEt.Text;
            BffUsuario.objEntidadeUsuario.Id = txtId.Text == "" ? null : int.Parse(txtId.Text);

            if (BffUsuario.objEntidadeUsuario.Id == null)
            {
                try
                {
                    if (BffUsuario.inserir())
                    {
                        Limpar();
                        Listar();
                        MessageBox.Show("Usuario inserido com sucesso");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao inserir registro. Erro: " + ex.Message.ToString());
                }
            }
            else
            {
                try
                {
                    if (BffUsuario.alterar())
                    {
                        Limpar();
                        Listar();
                        MessageBox.Show("Usuario alterado com sucesso");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao alterar registro. Erro: " + ex.Message.ToString());
                }
            }            
        }

        private void btnVerSenha_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void TxtListar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            try
            {
                dgListar.Columns.Clear();
                dgListar.DataSource = BffUsuario.Listar();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Falha ao listar registro. Erro: " + ex.Message.ToString());
            }
        }

        private void dgListar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgListar.SelectedRows != null)
            { 
                int id = int.Parse(dgListar.SelectedRows[0].Cells[0].Value.ToString());
                CarregarEdicao(id);
            }
        }

        private void CarregarEdicao(int id)
        {
            EntidadeUsuario objEntidadeUsuario = BffUsuario.Listar(id);

            txtId.Text = objEntidadeUsuario.Id.ToString();
            tstNome.Text = objEntidadeUsuario.Nome;
            tstEmail.Text = objEntidadeUsuario.Email;
            tstSenha.Text = objEntidadeUsuario.Senha;
            tstConfSenha.Text = objEntidadeUsuario.ConfSenha;
            tstEndereco.Text = objEntidadeUsuario.Endereco;
            tstTelefone.Text = objEntidadeUsuario.Telefone;
            tstPEt.Text = objEntidadeUsuario.Pet;
        }

        private void Limpar()
        {
            txtId.Text = "";
            tstNome.Text = "";
            tstEmail.Text = "";
            tstSenha.Text = "";
            tstConfSenha.Text = "";
            tstEndereco.Text = "";
            tstTelefone.Text = "";
            tstPEt.Text = "";
        }

        private void txtExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgListar.SelectedRows != null)
                {
                    int id = int.Parse(dgListar.SelectedRows[0].Cells[0].Value.ToString());
                    BffUsuario.Excluir(id);
                    Listar();
                    Limpar();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Falha ao excluir registro. Erro: " + ex.Message.ToString());
            }
        }
    }
}
