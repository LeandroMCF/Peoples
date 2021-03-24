using Peoples_Senai_Manhã.Domains;
using Peoples_Senai_Manhã.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Peoples_Senai_Manhã.Repositories
{
    public class PeopleRepository : IPeoples
    {
        private string conexao = "Data Source=DESKTOP-LFIP8ID; initial catalog=Peoples; integrated security=true";

        public void AtualizarIdCorpo(PeoplesDomain novoPeople)
        {
            throw new NotImplementedException();
        }

        public void AtualizarIdUrl(int Id, PeoplesDomain novoPeople)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(PeoplesDomain novoPeople)
        {
            using (SqlConnection con = new SqlConnection(conexao))
            {
                string Cadastrando = "INSERT INTO Funcionarios (Nome, Sobrenome) VALUES ('" + novoPeople.Nome + "', '" + novoPeople.SobreNome + "')";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(Cadastrando, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public PeoplesDomain ListarUserId(int id)
        {
            throw new NotImplementedException();
        }

        public List<PeoplesDomain> ListarUsers()
        {
            List<PeoplesDomain> lista = new List<PeoplesDomain>();

            using (SqlConnection con = new SqlConnection(conexao))
            {
                string listar = "SELECT IdFuncionarios, Nome, Sobrenome FROM Funcionarios";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(listar, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        PeoplesDomain people = new PeoplesDomain()
                        {
                            IdFuncionarios = Convert.ToInt32(rdr[0]),
                            Nome = rdr[1].ToString(),
                            SobreNome = rdr[2].ToString(),
                        };

                        lista.Add(people);
                    }
                }

                return lista;
            }
        }
    }
}
