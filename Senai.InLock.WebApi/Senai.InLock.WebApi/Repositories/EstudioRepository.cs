using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Senai.InLock.WebApi.Domains;
using Senai.InLock.WebApi.Interfaces;

namespace Senai.InLock.WebApi.Repositories
{
    public class EstudioRepository : IEstudioRepository
    {
        private string StringConexao = "Data Source=.\\SqlExpress; initial catalog=InLock_Games_Manha; user id=sa; pwd=132";

        public List<EstudioDomain> Listar()
        {
            string listar = @"SELECT EstudioId, NomeEstudio FROM ESTUDIOS";

            List<EstudioDomain> estudios = new List<EstudioDomain>();

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(listar, con))
                {
                    SqlDataReader sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        EstudioDomain estudio = new EstudioDomain
                        {
                            EstudioId = Convert.ToInt32(sdr["EstudioId"]),
                            NomeEstudio = sdr["NomeEstudio"].ToString()
                        };
                        estudios.Add(estudio);
                    }
                }
            }
            return estudios;
        }
    }
}
