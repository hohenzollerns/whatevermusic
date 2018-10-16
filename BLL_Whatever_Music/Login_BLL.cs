using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Whatever_Music;
using DAL_Whatever_Music;

namespace BLL_Whatever_Music
{
    public class Login_BLL
    {
        public static string ValidarLogin (Login_DTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.usuario))
            {
                return "Campo login vazio";
            }
            if (string.IsNullOrWhiteSpace(obj.senha))
            {
                return "Campo senha vazio";
            }
            if (string.IsNullOrWhiteSpace(obj.CSenha))
            {
                return "Campo confirmar senha vazio";
            }
            if (obj.senha != obj.CSenha)
            {
                return "Senhas diferentes";
            }
            return Login_DAL.ValidarLogin(obj);
        }
    }
}
