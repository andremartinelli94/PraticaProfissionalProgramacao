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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limparTextBoxes(Control.ControlCollection controles)
        {
            //Faz um laço para todos os controles passados no parâmetro
            foreach (Control ctrl in controles)
            {
                //Se o contorle for um TextBox...
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                }
            }
        }

        private void limparComboBox(Control.ControlCollection controles)
        {
            //Faz um laço para todos os controles passados no parâmetro
            foreach (Control ctrl in controles)
            {
                //Se o contorle for um TextBox...
                if (ctrl is ComboBox)
                {
                    ((ComboBox)(ctrl)).Text = String.Empty;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_cadastro frm = new frm_cadastro();
            frm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_menu frm4 = new frm_menu();
            frm4.Show();

            limparTextBoxes(this.Controls);
            limparComboBox(this.Controls);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_menu frm4 = new frm_menu();
            frm4.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            frm_menu frm4 = new frm_menu();
            frm4.Show();

            limparTextBoxes(this.Controls);
            limparComboBox(this.Controls);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_cadastro frm = new frm_cadastro();
            frm.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void limpaTextBoxes(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                }
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "storeimports" && textBox2.Text == "123456")
            {
                frm_menu frm = new frm_menu();
                frm.Show();
                limpaTextBoxes(this.Controls);
                this.Visible = false;
            }
            else
            {
                const string message2 = "Login ou senha invalidos";
                const string information = " Atenção";
                MessageBox.Show(message2, information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpaTextBoxes(this.Controls);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frm_cadastro frm = new frm_cadastro();
            frm.Show();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }
    }
}
