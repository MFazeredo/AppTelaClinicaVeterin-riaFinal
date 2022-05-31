using System;
using System.Collections.Generic;
using System.Text;

namespace AppTelaClinicaVeterinária
{
    class BffUsuario
    {
        public EntidadeUsuario objEntidadeUsuario = new EntidadeUsuario();
        private BackEndBFFUsuario BackEndBFFUsuario = new BackEndBFFUsuario();

        public bool inserir()
        {
            try
            {
                return BackEndBFFUsuario.inserir(objEntidadeUsuario.Nome, objEntidadeUsuario.Email, objEntidadeUsuario.Senha, objEntidadeUsuario.ConfSenha, objEntidadeUsuario.Endereco, objEntidadeUsuario.Telefone, objEntidadeUsuario.Pet);
            }
            catch
            {
                throw;
            }
        }

        public bool alterar()
        {
            try
            {
                return BackEndBFFUsuario.AlterarUsuario(objEntidadeUsuario.Id.Value, objEntidadeUsuario.Nome, objEntidadeUsuario.Email, objEntidadeUsuario.Senha, objEntidadeUsuario.ConfSenha, objEntidadeUsuario.Endereco, objEntidadeUsuario.Telefone, objEntidadeUsuario.Pet);
            }
            catch
            {
                throw;
            }
        }

        public bool Excluir(int id)
        {
            try
            {
                return BackEndBFFUsuario.Excluir(id);
            }
            catch
            {
                throw;
            }
        }

        public List<EntidadeUsuario> Listar()
        {
            try 
            {
                return BackEndBFFUsuario.Listar();
            }
            catch
            {
                throw;
            }
        }

        public EntidadeUsuario Listar(int id)
        {
            try 
            {
                return BackEndBFFUsuario.Listar(id);
            }
            catch
            {
                throw;
            }
        }
    }
}
