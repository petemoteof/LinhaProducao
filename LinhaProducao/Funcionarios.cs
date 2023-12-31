﻿using LinhaProducao;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Funcionario : Conexao
    {

        public int                  id;
        public int          id_empresa;
        public string             nome;
        private string           senha;
        public string            email;
        public bool     logado = false;
        private int              nivel;
        public DateTime  data_cadastro;

        public void SetSenha(string senha)
        {
            this.senha = senha;
        }

        public string GetSenha()
        {
            //this.senha = BCrypt.Net.BCrypt.HashPassword(senha, BCrypt.Net.BCrypt.GenerateSalt());
            
            this.senha = senha;

            return this.senha;
        }
        public void SetNivel(int nivel)
        {
            this.nivel = nivel;
        }

        public int GetNivel()
        {
            return this.nivel;
        }

        public List<Funcionario> GetListaFuncionario()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            try
            {
                OpenConnection();

                string query = "SELECT * FROM funcionarios;";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Funcionario novoFuncionario = new Funcionario();

                            novoFuncionario.id                      = Convert.ToInt32(reader.GetString("id"));
                            novoFuncionario.id_empresa      = Convert.ToInt32(reader.GetString("id_empresa"));
                            novoFuncionario.nome                                   = reader.GetString("nome");
                            novoFuncionario.email                                 = reader.GetString("email");
                            novoFuncionario.data_cadastro = DateTime.Parse(reader.GetString("data_cadastro"));

                            novoFuncionario.SetSenha(reader.GetString("senha"));
                            novoFuncionario.SetNivel(Convert.ToInt32(reader.GetString("nivel")));

                            funcionarios.Add(novoFuncionario);
                        }

                    }

                }

                CloseConnection();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            return funcionarios;
        }

        public Funcionario GetFuncionarioPorEmailESenha()
        { 
        
                Funcionario funcionarios = new Funcionario();

            

            try
            {
                OpenConnection();

                string query = "SELECT * FROM funcionarios WHERE email = '"+this.email+"' AND senha = '"+this.senha+"';";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            this.id = Convert.ToInt32(reader.GetString("id"));
                            this.nome = reader.GetString("nome");
                            this.email = reader.GetString("email");
                            this.nivel = Convert.ToInt32(reader.GetString("nivel"));

                            this.logado = true;
                            
                        }

                    }

                }

                CloseConnection();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            return this;
        
        }

        public bool Insert()
        {

            try
            {

                string query = "INSERT INTO `funcionarios` (`id_empresa`, `nome`, `email`, `senha`, `nivel`) VALUES (@id_empresa, @nome, @email, @senha, @nivel);";

                MySqlParameter[] param = new MySqlParameter[]
                {
                new MySqlParameter("@id_empresa", this.id_empresa),
                new MySqlParameter("@nome", this.nome),
                new MySqlParameter("@email", this.email),
                new MySqlParameter("@senha", this.senha),
                new MySqlParameter("@nivel", this.nivel),
                };

                this.ExecuteQueryWithParameters(query, param);

                return true;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

        }
    }
}