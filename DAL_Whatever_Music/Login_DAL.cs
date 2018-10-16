using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Whatever_Music;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace DAL_Whatever_Music
{
    public class Login_DAL
    {
        public static string ValidarLogin(Login_DTO obj)
        {
            try
            {
                string script = "SELECT * FROM tb_usuario WHERE usuariof = @usuariof AND senhaf = @senhaf";
                MySqlCommand cm = new MySqlCommand(script, Conexao.Conectar());
                cm.Parameters.AddWithValue("@usuariof", obj.usuario);
                cm.Parameters.AddWithValue("@senhaf", obj.senha);

                MySqlDataReader dados = cm.ExecuteReader();

                while (dados.Read())
                {
                    if (dados.HasRows)
                    {
                        return "Sucesso";
                    }
                }
                return "Usuário ou senha inválidos";
            }
            catch
            {
                throw new Exception("Problemas na conexão!");
            }
        }
    }
}
