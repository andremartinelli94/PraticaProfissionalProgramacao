using ProjetoEmpresa.Controller.Fornecedores;
using ProjetoEmpresa.DAO.Fornecedores;
using ProjetoEmpresa.Entidades.Fornecedores;
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
    public partial class frm_fornecedores : Form
    {
        ControlFornecedor controlFornecedor = new ControlFornecedor();
        public frm_fornecedores()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_fornecedores_Load(object sender, EventArgs e)
        {
            int valor = total();
            txtRegistros.Text = Convert.ToString(valor);
            txtCodigoFornecedor.Text = Convert.ToString(valor + 1);
            DAOFornecedor daoFonecedor = new DAOFornecedor();
            controlFornecedor.carregaDadosDoArquivoJson();
        }
        private void btnPesquisarPedido_Click_1(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            limpaControles();
        }

        private void btnCadastroFornecedor_Click_1(object sender, EventArgs e)
        {
            controlFornecedor.incluir(InserirFornecedor());
            controlFornecedor.salvar();
            MessageBox.Show("Fornecedor cadastrado com sucesso!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            limpaControles();
            int valor = total();
            txtRegistros.Text = Convert.ToString(valor);
            txtCodigoFornecedor.Text = Convert.ToString(valor + 1);
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        public int total()
        {
            return controlFornecedor.quantidadeTotal();
        }

        public Fornecedor InserirFornecedor()
        {
            int valor = total();
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.IdFornecedor = valor + 1;
            fornecedor.NomeFornecedor = txtFornecedor.Text;
            fornecedor.NomeProdutoFornecedor = txtProdutoFornecido.Text;
            fornecedor.Categoria = txtCategoria.Text;
            fornecedor.Cnpj = txtCNPJ.Text;
            fornecedor.Cidade = txtCidade.Text;
            fornecedor.Estado = txtEstado.Text;
            fornecedor.Pais = txtPais.Text;

            return fornecedor;
        }

        public void limpaControles()
        {
            txtPesquisa.Text = " ";
            mskData.Text = " ";
            txtFornecedor.Text = " ";
            txtProdutoFornecido.Text = " ";
            txtCategoria.Text = " ";
            txtCNPJ.Text = " ";
            txtCidade.Text = " ";
            txtEstado.Text = " ";
            txtPais.Text = " ";
        }

        private void mostraResultadoPesquisa(Fornecedor fornecedor)
        {
            txtCodigoFornecedor.Text = Convert.ToString(fornecedor.IdFornecedor);
            mskData.Text = fornecedor.DataCadastro;
            txtFornecedor.Text = fornecedor.NomeFornecedor;
            txtProdutoFornecido.Text = fornecedor.NomeProdutoFornecedor;
            txtCategoria.Text = fornecedor.Categoria;
            txtCNPJ.Text = fornecedor.Cnpj;
            txtCidade.Text = fornecedor.Cidade;
            txtEstado.Text = fornecedor.Estado;
            txtPais.Text = fornecedor.Pais;
        }

        private void Pesquisar()
        {
            if (txtPesquisa.Text != "")
            {
                Fornecedor fornecedor = controlFornecedor.pesquisar(txtPesquisa.Text);
                mostraResultadoPesquisa(fornecedor);
            }

            else
            {
                MessageBox.Show("Informe um Nome!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
