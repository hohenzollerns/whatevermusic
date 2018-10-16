using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whatever_Music
{
    public partial class Produto : Form
    {
        public Produto()
        {
            InitializeComponent();
        }

        private void btnCadF_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadF funcionario = new CadF();
            funcionario.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vendas funcionario = new Vendas();
            funcionario.ShowDialog();
            this.Close();
        }

        private void txtInicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio funcionario = new Inicio();
            funcionario.ShowDialog();
            this.Close();
        }
    }
}
