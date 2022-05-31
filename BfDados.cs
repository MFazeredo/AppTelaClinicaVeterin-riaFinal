using System.Data.SqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace AppTelaClinicaVeterinária
{
    public class BfDados
    {
        SqlCommand cmd;

        public bool inserirUsuario(string nome, string email, string senha, string confSenha, string endereco, string telefone, string pet)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-1IVLBK2;Initial Catalog=clinicaPet;Integrated Security=True");
                cmd = new SqlCommand("INSERT INTO tbUsuario(nome, email, senha, confSenha, endereco, telefone, pet) VALUES (@nome, @email, @senha, @confSenha, @endereco, @telefone, @pet)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@confSenha", confSenha);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@pet", pet);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
                throw;
            }
        }
        public bool AlterarUsuario(int Id, string nome, string email, string senha, string confSenha, string endereco, string telefone, string pet)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-1IVLBK2;Initial Catalog=clinicaPet;Integrated Security=True");
                cmd = new SqlCommand("update tbUsuario " +
                    " set nome = @nome, " +
                    " email = @email, " +
                    " senha = @senha, " +
                    " confSenha = @confSenha, " +
                    " endereco = @endereco, " + 
                    " telefone = @telefone, pet = @pet where id = @id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@confSenha", confSenha);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@pet", pet);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
                throw;
            }
        }

        public List<EntidadeUsuario> Listar()
        {
            try {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-1IVLBK2;Initial Catalog=clinicaPet;Integrated Security=True");
                cmd = new SqlCommand("select * from tbusuario order by nome", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                List<EntidadeUsuario> usuarios = new List<EntidadeUsuario>();

                while (reader.Read())
                {
                    usuarios.Add(new EntidadeUsuario
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        Nome = reader["nome"].ToString(),
                        Senha = reader["senha"].ToString(),
                        ConfSenha = reader["confsenha"].ToString(),
                        Email = reader["email"].ToString(),
                        Endereco = reader["endereco"].ToString(),
                        Telefone = reader["telefone"].ToString(),
                        Pet = reader["pet"].ToString()

                    });
                }

                con.Close();
                return usuarios;
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
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-1IVLBK2;Initial Catalog=clinicaPet;Integrated Security=True");
                cmd = new SqlCommand("select * from tbusuario where id = @id", con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                List<EntidadeUsuario> usuarios = new List<EntidadeUsuario>();

                while (reader.Read())
                {
                    usuarios.Add(new EntidadeUsuario
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        Nome = reader["nome"].ToString(),
                        Senha = reader["senha"].ToString(),
                        ConfSenha = reader["confsenha"].ToString(),
                        Email = reader["email"].ToString(),
                        Endereco = reader["endereco"].ToString(),
                        Telefone = reader["telefone"].ToString(),
                        Pet = reader["pet"].ToString()

                    });
                }

                con.Close();
                return usuarios.FirstOrDefault();
            }
            catch
            {
                throw;
            }
        }

        public bool Excluir(int id)
        {
            try { 
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-1IVLBK2;Initial Catalog=clinicaPet;Integrated Security=True");
                cmd = new SqlCommand("delete from tbusuario where id = @id", con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
                throw;
            }
        }
    }
}
