using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Whatever_Music;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;


namespace DAL_Whatever_Music
{
    public class Cadastro_DAL
    {
        public static string Cadastrar(Cadastro_DTO obj)
        {
            try
            {
                string sql = "INSERT INTO tb_usuario (nome, email, telefone, cpf, rg, sexo, dia, mes, ano, tipo, cep, uf, rua," +
                    "numero, bairro, cidade, comp, usuariof, senhaf) VALUES (@nome, @email, @telefone, @cpf, @rg, @sexo, @dia, @mes, @ano, @tipo, @cep, @uf, @rua," +
                    "@numero, @bairro, @cidade, @comp, @usuariof, @senhaf)";
                MySqlCommand cm = new MySqlCommand(sql, Conexao.Conectar());

                cm.Parameters.AddWithValue("@nome", obj.nome);
                cm.Parameters.AddWithValue("@email", obj.email);
                cm.Parameters.AddWithValue("@telefone", obj.telefone);
                cm.Parameters.AddWithValue("@cpf", obj.cpf);
                cm.Parameters.AddWithValue("@rg", obj.rg);
                cm.Parameters.AddWithValue("@sexo", obj.sexo);
                cm.Parameters.AddWithValue("@dia", obj.dia);
                cm.Parameters.AddWithValue("@mes", obj.mes);
                cm.Parameters.AddWithValue("@ano", obj.ano);
                cm.Parameters.AddWithValue("@tipo", obj.tipo);
                cm.Parameters.AddWithValue("@cep", obj.cep);
                cm.Parameters.AddWithValue("@uf", obj.uf);
                cm.Parameters.AddWithValue("@rua", obj.rua);
                cm.Parameters.AddWithValue("@numero", obj.numero);
                cm.Parameters.AddWithValue("@bairro", obj.bairro);
                cm.Parameters.AddWithValue("@cidade", obj.cidade);
                cm.Parameters.AddWithValue("@comp", obj.comp);
                cm.Parameters.AddWithValue("@usuariof", obj.usuariof);
                cm.Parameters.AddWithValue("@senhaf", obj.senhaf);

                cm.ExecuteNonQuery();

                return "Sucesso";
            }
            catch (Exception ex)
            {
                throw new Exception("Problemas na conexão!" + ex.Message);
            }
            finally
            {
                if (Conexao.Conectar().State != System.Data.ConnectionState.Closed)
                {
                    Conexao.Conectar().Close();
                }
            }
        }

        public static Cadastro_DTO Buscar(string cpf)
        {
            try
            {
                Cadastro_DTO obj = new Cadastro_DTO();
                string script = "SELECT * FROM tb_usuario WHERE cpf = @cpf";
                MySqlCommand cm = new MySqlCommand(script, Conexao.Conectar());
                cm.Parameters.AddWithValue("@cpf", cpf);

                MySqlDataReader dados = cm.ExecuteReader();

                while (dados.Read())
                {
                    if (dados.HasRows)
                    {
                        obj.codf = int.Parse(dados["codf"].ToString());
                        obj.nome = dados["nome"].ToString();
                    }
                }
                throw new Exception("CPF não encontrado");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Problemas na conexão");
            }
            finally
            {
                if (Conexao.Conectar().State!= ConnectionState.Closed)
                {
                    Conexao.Conectar().Close();
                }
            }
        }

        public static bool TestarCPF (string cpf)
        {
            try
            {
                string script = "SELECT * FROM Funcionario WHERE cpf = @cpf";
                MySqlCommand cm = new MySqlCommand(script, Conexao.Conectar());
                cm.Parameters.AddWithValue("@cpf", cpf);

                MySqlDataReader dados = cm.ExecuteReader();
                
                while (dados.Read())
                {
                    if (dados.HasRows)
                    {
                        return true;
                    }
                }
                return false;
            }

            catch
            {
                throw new Exception("Problemas na conexão!");
            }

            finally
            {
                if (Conexao.Conectar().State != ConnectionState.Closed)
                {
                    Conexao.Conectar().Close();
                }
            }
        }
    }
}
