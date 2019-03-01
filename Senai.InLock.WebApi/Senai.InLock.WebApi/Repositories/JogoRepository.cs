using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Senai.InLock.WebApi.Domains;
using Senai.InLock.WebApi.Interfaces;

namespace Senai.InLock.WebApi.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        private string StringConexao = "Data Source=.\\SqlExpress; initial catalog=InLock_Games_Manha; user id=sa; pwd=132";

        public void Cadastrar(JogoDomain jogo)
        {
            string cadastrar = @"INSERT INTO JOGOS(NomeJogo, Descricao, DataLancamento, Valor, EstudioId)
                                VALUES (@NOME, @DESC, @DATA, @VALOR, @ID_ESTUDIO)";

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(cadastrar, con))
                {
                    cmd.Parameters.AddWithValue("@NOME", jogo.NomeJogo);
                    cmd.Parameters.AddWithValue("@DESC", jogo.Descricao);
                    cmd.Parameters.AddWithValue("@DATA", jogo.DataLancamento);
                    cmd.Parameters.AddWithValue("@VALOR", jogo.Valor);
                    cmd.Parameters.AddWithValue("@ID_ESTUDIO", jogo.EstudioId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<JogoDomain> Listar()
        {
            string listar = @"SELECT JOGOS.NomeJogo, ESTUDIOS.* FROM JOGOS INNER JOIN ESTUDIOS ON JOGOS.EstudioId = ESTUDIOS.EstudioId";

            List<JogoDomain> jogos = new List<JogoDomain>();

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(listar, con))
                {
                    SqlDataReader sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        JogoDomain jogo = new JogoDomain
                        {
                            JogoId = Convert.ToInt32(sdr["JogoId"]),
                            NomeJogo = sdr["NomeJogo"].ToString(),
                            Descricao = sdr["Descricao"].ToString(),
                            DataLancamento = Convert.ToDateTime(sdr["DataLancamento"]),
                            Valor = Convert.ToDecimal(sdr["Valor"]),
                                Estudio = new EstudioDomain
                                {
                                    EstudioId = Convert.ToInt32(sdr["EstudioId"]),
                                    NomeEstudio = sdr["NomeEstudio"].ToString()
                                },
                        };
                        jogos.Add(jogo);
                    }
                }
            }
            return jogos;
        }
    }
}
