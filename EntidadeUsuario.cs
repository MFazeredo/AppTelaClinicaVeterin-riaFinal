using System;
using System.Collections.Generic;
using System.Text;

namespace AppTelaClinicaVeterinária
{
    public class EntidadeUsuario
    {
        private int? id;
        private string nome;
        private string email;
        private string senha;
        private string confSenha;
        private string endereco;
        private string telefone;
        private string pet;

        public int? Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
        public string ConfSenha { get => confSenha; set => confSenha = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Pet { get => pet; set => pet = value; }


    }
}
