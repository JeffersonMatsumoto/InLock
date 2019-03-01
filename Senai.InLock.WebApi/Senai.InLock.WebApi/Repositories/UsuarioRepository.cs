using Senai.InLock.WebApi.Domains;
using Senai.InLock.WebApi.Interfaces;
using System;
using System.Data.SqlClient;

namespace Senai.InLock.WebApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private string StringConexao = "Data Source=.\\SqlExpress; initial catalog=InLock_Games_Manha; user id=sa; pwd=132";

        public UsuarioDomain BuscarEmailSenha(string email, string senha)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string QuerySelect = "SELECT UsuarioId, Email, Senha, TipoUsuario FROM USUARIOS " +
                                                         "WHERE Email = @EMAIL AND Senha = @SENHA";

                using (SqlCommand cmd = new SqlCommand(QuerySelect, con))
                {
                    cmd.Parameters.AddWithValue("@EMAIL", email);
                    cmd.Parameters.AddWithValue("@SENHA", senha);

                    con.Open();

                    SqlDataReader sdr = cmd.ExecuteReader();

                    if (sdr.HasRows)
                    {
                        UsuarioDomain usuario = new UsuarioDomain();

                        while (sdr.Read())
                        {
                            usuario.UsuarioId = Convert.ToInt32(sdr["UsuarioId"]);
                            usuario.Email = sdr["Email"].ToString();
                            usuario.TipoUsuario = sdr["TipoUsuario"].ToString();
                        }
                        return usuario;
                    }
                }
                return null;
            }
        }
    }
}
