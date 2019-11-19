using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEmpresa
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_caixa frm = new frm_caixa();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frm_departamentos frm3 = new frm_departamentos();
            frm3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_fornecedores frm2 = new frm_fornecedores();
            frm2.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            frm_vendas frm5 = new frm_vendas();
            frm5.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_empregados frm6 = new frm_empregados();
            frm6.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frm_pedidos frm4 = new frm_pedidos();
            frm4.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            frm_produtos frm7 = new frm_produtos();
            frm7.Show();
            this.Visible = false;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            frm_manutencao frm8 = new frm_manutencao();
            frm8.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            frm_clientes frm9 = new frm_clientes();
            frm9.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
