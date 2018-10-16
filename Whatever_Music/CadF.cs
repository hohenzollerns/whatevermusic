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
    public partial class CadF : Form
    {
        public CadF()
        {
            InitializeComponent();
        }

        private void CadF_Load(object sender, EventArgs e)
        {

        }

        private void btnCadF_Click(object sender, EventArgs e)
        {
            try
            {
                Cadastro_DTO obj = new Cadastro_DTO();
                obj.nome = txtNome.Text;
                obj.email = txtEmail.Text;
                obj.telefone = txtTel.Text;
                obj.cpf = txtCPF.Text;
                obj.rg = txtRG.Text;
                obj.sexo = txtSexo.Text;
                obj.dia = txtDia.Text;
                obj.mes = txtMes.Text;
                obj.ano = txtAno.Text;
                obj.tipo = txtTipo.Text;
                obj.cep = txtCEP.Text;
                obj.uf = txtUF.Text;
                obj.rua = txtRua.Text;
                obj.numero = txtNum.Text;
                obj.bairro = txtBairro.Text;
                obj.cidade = txtCidade.Text;
                obj.comp = txtComp.Text;
                obj.usuariof = txtFUsuario.Text;
                obj.senhaf = txtFSenha.Text;

                string texto;
                texto = Cadastro_BLL.ValidarCadastro(obj);
                if (texto == "Sucesso")
                {
                    this.Hide();
                    CadF telaF = new CadF();
                    MessageBox.Show("Cadastro feito com sucesso");
                    telaF.ShowDialog();
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

        private void btnLimpF_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadF telaF = new CadF();
            telaF.ShowDialog();
        }

        private void btnVoltarF_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio tela = new Inicio();
            tela.ShowDialog();
        }
    }
}
