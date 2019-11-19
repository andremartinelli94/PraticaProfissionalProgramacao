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
    public partial class frm_cadastro : Form
    {
        public frm_cadastro()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            const string message1 = " Seu cadastro foi realizado com sucesso!";
            const string caption2 = " Cadastre-se";
            MessageBox.Show(message1, caption2, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            limparTextBoxes(this.Controls);
            limparComboBox(this.Controls);
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
            const string message1 = " A atualização foi realizada com sucesso!";
            const string caption2 = " Atualizar";
            MessageBox.Show(message1, caption2, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limparTextBoxes(this.Controls);
            limparComboBox(this.Controls);
        }

        private void frm_cadastro_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            const string message1 = " Seu cadastro foi realizado com sucesso!";
            const string caption2 = " Cadastre-se";
            MessageBox.Show(message1, caption2, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            limparTextBoxes(this.Controls);
            limparComboBox(this.Controls);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            limparTextBoxes(this.Controls);
            limparComboBox(this.Controls);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            const string message1 = " A atualização foi realizada com sucesso!";
            const string caption2 = " Atualizar";
            MessageBox.Show(message1, caption2, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
