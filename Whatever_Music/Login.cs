using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_Whatever_Music;
using BLL_Whatever_Music;


namespace Whatever_Music
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Login_DTO obj = new Login_DTO();
                obj.usuario = txtLogin.Text;
                obj.senha = txtSenha.Text;
                obj.CSenha = txtCSenha.Text;
                string texto;
                texto = Login_BLL.ValidarLogin(obj);
                if (texto == "Sucesso")
                {
                    this.Hide();
                    Inicio tela = new Inicio();
                    tela.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(texto);
                }
            }
            catch
            {
                MessageBox.Show("Login ou senha inválidos");
            }
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
