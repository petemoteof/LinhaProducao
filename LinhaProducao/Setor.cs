using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhaDeProducao
{
    internal class Setor : Conexao
    {
        public int id;
        public int id_empresa;
        public string nome;
        public int id_responsavel;
        public DateTime data_cadastro;

        public List<Setor> GetListaSetor()
        {
            List<Setor> setores = new List<Setor>();

            try
            {
                OpenConnection();

                string query = "SELECT * FROM setores;";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Setor novoSetor = new Setor();

                            novoSetor.id = Convert.ToInt32(reader.GetString("id"));
                            novoSetor.nome = reader.GetString("nome");
                            novoSetor.id_empresa = Convert.ToInt32(reader.GetString("id_empresa"));
                            novoSetor.id_responsavel = Convert.ToInt32(reader.GetString("id_responsavel"));
                            novoSetor.data_cadastro = DateTime.Parse(reader.GetString("data_cadastro"));

                            setores.Add(novoSetor);
                        }

                    }

                }

                CloseConnection();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            return setores;
        }
        public bool Insert()
        {

            try
            {

                string query = "INSERT INTO `setores` (`nome`, `id_empresa`,`id_responsavel`) VALUES (@nome, @id_empresa,@id_responsavel);";

                MySqlParameter[] param = new MySqlParameter[]
                {
                new MySqlParameter("@nome", this.nome),
                new MySqlParameter("@id_empresa", this.id_empresa),
                new MySqlParameter("@id_responsavel", this.id_responsavel),
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