using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Whatever_Music;
using DAL_Whatever_Music;

namespace BLL_Whatever_Music
{
    public class Cadastro_BLL
    {
        public static string ValidarCadastro(Cadastro_DTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.nome))
            {
                return "Campo nome vazio!";
            }

            if (string.IsNullOrWhiteSpace(obj.email))
            {
                return "Campo email vazio!";
            }

            try
            {
                Int64.Parse(obj.telefone);
            }
            catch
            {
                return "Campo telefone deve ser um numero inteiro!";
            }
            if (string.IsNullOrWhiteSpace(obj.telefone))
            {
                return "Campo telefone vazio!";
            }

            try
            {
                Int64.Parse(obj.cpf);
            }
            catch
            {
                return "Campo CPF deve ser um numero inteiro!";
            }
            if (string.IsNullOrWhiteSpace(obj.cpf))
            {
                return "Campo CPF vazio!";
            }
            bool teste_cpf = Cadastro_DAL.TestarCPF(obj.cpf);
            if (teste_cpf==true)
            {
                return "CPF já foi cadastrado";
            }

            if (string.IsNullOrWhiteSpace(obj.rg))
            {
                return "Campo rg vazio!";
            }

            if (string.IsNullOrWhiteSpace(obj.sexo))
            {
                return "Escolha um sexo";
            }

            if (string.IsNullOrWhiteSpace(obj.dia))
            {
                return "Escolha um dia";
            }

            if (string.IsNullOrWhiteSpace(obj.mes))
            {
                return "Escolha um mes";
            }

            try
            {
                Int64.Parse(obj.ano);
            }
            catch
            {
                return "Campo ano deve ser um numero inteiro!";
            }
            if (string.IsNullOrWhiteSpace(obj.ano))
            {
                return "Campo ano vazio!";
            }

            if (string.IsNullOrWhiteSpace(obj.tipo))
            {
                return "Escolha um tipo";
            }

            try
            {
                Int64.Parse(obj.cep);
            }
            catch
            {
                return "Campo cep deve ser um numero inteiro!";
            }
            if (string.IsNullOrWhiteSpace(obj.cep))
            {
                return "Campo CEP vazio!";
            }

            if (string.IsNullOrWhiteSpace(obj.uf))
            {
                return "Escolha uma unidade federativa";
            }

            if (string.IsNullOrWhiteSpace(obj.rua))
            {
                return "Campo rua vazio!";
            }

            try
            {
                Int64.Parse(obj.numero);
            }
            catch
            {
                return "Campo numero deve ser um numero inteiro!";
            }
            if (string.IsNullOrWhiteSpace(obj.numero))
            {
                return "Campo numero vazio!";
            }

            if (string.IsNullOrWhiteSpace(obj.bairro))
            {
                return "Campo bairro vazio!";
            }

            if (string.IsNullOrWhiteSpace(obj.cidade))
            {
                return "Campo cidade vazio!";
            }

            if (string.IsNullOrWhiteSpace(obj.usuariof))
            {
                return "Campo usuario vazio!";
            }

            if (string.IsNullOrWhiteSpace(obj.senhaf))
            {
                return "Campo senha vazio!";
            }

            return Cadastro_DAL.Cadastrar(obj);
        }

        public Cadastro_DTO ValidarBusca (string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
            {
                throw new Exception("Campo CPF vazio!");
            }
            return Cadastro_DAL.Buscar(cpf);
        }
    }
}
