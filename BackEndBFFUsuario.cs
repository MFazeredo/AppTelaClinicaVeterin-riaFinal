using System;
using System.Collections.Generic;
using System.Text;

namespace AppTelaClinicaVeterinária
{
    class BackEndBFFUsuario
    {

        private BfDados objDados = new BfDados();

        public bool inserir(string nome, string email, string senha, string confSenha, string endereco, string telefone, string pet)
        {
            try
            {
                return objDados.inserirUsuario(nome, email, senha, confSenha, endereco, telefone, pet);
            }
            catch
            {
                throw;
            }
        }

        public List<EntidadeUsuario> Listar()
        {
            return objDados.Listar();
        }
        public EntidadeUsuario Listar(int id)
        {
            return objDados.Listar(id);
        }

        public bool AlterarUsuario(int Id, string nome, string email, string senha, string confSenha, string endereco, string telefone, string pet)
        {
            return objDados.AlterarUsuario(Id, nome, email, senha, confSenha, endereco, telefone, pet);
        }

        public bool Excluir(int id)
        {
            return objDados.Excluir(id);
        }
    }
}
