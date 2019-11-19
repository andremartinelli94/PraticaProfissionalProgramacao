using ProjetoEmpresa.View.Caixa;
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
namespace ProjetoEmpresa
{
    public partial class frm_caixa : Form
    {
        ControlNotaFiscal controlNF = new ControlNotaFiscal();
        public int Total()
        {
            return controlNF.QuantidadeTotal();
        }
        public frm_caixa()
        {
            InitializeComponent();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public NotaFiscal inserirNF()
        {
            int valor = Total() + 1;
            NotaFiscal nf = new NotaFiscal();
            nf.CodigoProduto = Convert.ToString(valor);
            nf.NumeroNotaFiscal = txtNumNotaFiscal.Text;
            nf.Nome = txtNomeCliente.Text;
            nf.Endereco = txtRua.Text;
            nf.RazaoSocial = txtRazaoSocial.Text;
            nf.Valor = txtValor.Text;
            return nf;
        }
        private void frm_caixa_Load(object sender, EventArgs e)
        {
            controlNF.carregaDadosDoArquivoJSon();
            int valor = Total();
            txtCodProd.Text = Convert.ToString(valor + 1);
        }
        private void buttonGerarNotaFiscal_Click(object sender, EventArgs e)
        {
            controlNF.incluir(inserirNF());
            controlNF.ordenaLista();
            dgvCaixa.DataSource = controlNF.listadgv();
            controlNF.salvar();
            MessageBox.Show("Nota gerada com sucesso!", "Caixa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            int valor = Total();
            txtCodProd.Text = Convert.ToString(valor + 1);

            txtNomeCliente.Clear();
            txtCodProd.Clear();
            txtRua.Clear();
            txtRazaoSocial.Clear();
            txtValor.Clear();

        }
        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Clear();
            txtCodProd.Clear();
            txtRua.Clear();
            txtRazaoSocial.Clear();
            txtValor.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_planinha frm = new frm_planinha();
            frm.Show();
            this.Close();
        }

        private void dgvCaixa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
