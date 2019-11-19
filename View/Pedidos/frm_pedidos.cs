using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoEmpresa.Controller.Pedidos;
using ProjetoEmpresa.DAO.Pedidos;
using ProjetoEmpresa.Entidades;
using ProjetoEmpresa.Entidades.Pedidos;

namespace ProjetoEmpresa
{
    public partial class frm_pedidos : Form
    {
        ControlPedido controlPedidos = new ControlPedido();
        public frm_pedidos()
        {
            InitializeComponent();
        }

        private void frm_pedidos_Load(object sender, EventArgs e)
        {
            int valor = total();
            txtRegistros.Text = Convert.ToString(valor);
            txtCodigo.Text = Convert.ToString(valor + 1);
            DAOPedido daoPedidos = new DAOPedido();
            controlPedidos.carregaDadosDoArquivoJson();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaControles();
        }

        private void btnCadastroPedido_Click(object sender, EventArgs e)
        {
            controlPedidos.incluir(InserirPedidos());
            controlPedidos.salvar();
            MessageBox.Show("Pedido cadastrado com sucesso!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            limpaControles();
            int valor = total();
            txtRegistros.Text = Convert.ToString(valor);
            txtCodigo.Text = Convert.ToString(valor + 1);
        }

        private void btnPesquisarPedido_Click(object sender, EventArgs e)
        {
            if (txtPesquisa.Text != "")
            {
                Pedido pedido = controlPedidos.pesquisar(txtPesquisa.Text);
                mostraResultadoPesquisa(pedido);
            }

            else
            {
                MessageBox.Show("Informe um Nome!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public int total()
        {
            return controlPedidos.quantidadeTotal();
        }

        public Pedido InserirPedidos()
        {

            int valor = total();
            Pedido pedidos = new Pedido();
            pedidos.IdPedido = valor + 1;
            pedidos.Funcionario = txtFuncionario.Text;
            pedidos.Cargo = txtCargo.Text;
            pedidos.Quantidade = Convert.ToInt32(nudQtd.Value);
            pedidos.Preco = Convert.ToInt32(nudPreco.Value);
            pedidos.NomeProduto = txtProduto.Text;
            pedidos.Categoria = txtCategoria.Text;
            pedidos.DataCadastro = Convert.ToString(mskData.Text);
            return pedidos;
        }

        private void limpaControles()
        {
            txtFuncionario.Text = " ";
            txtCargo.Text = " ";
            txtFornecedor.Text = " ";
            txtProduto.Text = " ";
            txtCategoria.Text = " ";
            txtPesquisa.Text = " ";
            nudQtd.Value = 0;
            nudPreco.Value = 0;
            mskData.Text = " ";
        }

        private void mostraResultadoPesquisa(Pedido pedido)
        {
            txtCodigo.Text = Convert.ToString(pedido.IdPedido);
            txtFuncionario.Text = pedido.Funcionario;
            txtCargo.Text = pedido.Cargo;
            nudQtd.Text = Convert.ToString(pedido.Quantidade);
            nudPreco.Text = Convert.ToString(pedido.Preco);
            txtProduto.Text = pedido.NomeProduto;
            mskData.Text = pedido.DataCadastro;
            txtCategoria.Text = pedido.Categoria;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
