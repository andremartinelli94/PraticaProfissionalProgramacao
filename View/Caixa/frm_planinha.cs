using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoEmpresa.Controller.Caixa;
using ProjetoEmpresa.Entidades.Caixa;

namespace ProjetoEmpresa.View.Caixa
{
    public partial class frm_planinha : Form
    {
        ControlPlanilha controlPlanilha = new ControlPlanilha();
        public frm_planinha()
        {
            InitializeComponent();
        }
        public Planilha inserir()
        {
            Planilha dados = new Planilha();
            dados.Categoria = cmbCategoria.Text;
            dados.Data = txtData.Text;
            dados.Valor = txtValor.Text;
            return dados;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            controlPlanilha.incluir(inserir());
            controlPlanilha.ordenaLista();
            dgvPlanilha.DataSource = controlPlanilha.listadgv();
            controlPlanilha.salvar();
            MessageBox.Show("Cadastrado com sucesso!", "Planilha", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frm_planinha_Load(object sender, EventArgs e)
        {
            controlPlanilha.carregaDadosDoArquivoJSon();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtValor.Clear();
            txtData.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_caixa frm = new frm_caixa();
            frm.Show();
            this.Close();
        }
    }
}
