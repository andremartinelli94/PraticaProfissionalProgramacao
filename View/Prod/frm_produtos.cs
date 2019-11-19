using System;
using System.Windows.Forms;
using ProjetoEmpresa.Entidades;
using ProjetoEmpresa.Controller;
using ProjetoEmpresa.View.Prod;

namespace ProjetoEmpresa
{
    public partial class frm_produtos : Form
    {
        ControlProduto controlProduto = new ControlProduto();

        public frm_produtos()
        {
            InitializeComponent();
            ControlProduto car = new ControlProduto();
            car.carregaDadosDoArquivoJSon();
        }
        public Produtos inserirProdutos()
        {
            Produtos produtos = new Produtos();

            produtos.CodigoProd = Convert.ToInt32(txt_codigoprod.Text);
            produtos.ItensProd = Convert.ToInt32(txt_itens.Text);
            produtos.QuantidadeProd = Convert.ToInt32(txt_quantidadeprod.Text);
            produtos.PesoLiqProd = Convert.ToDouble(txt_pesoliq.Text);
            produtos.PesoProd = Convert.ToDouble(txt_pesobru.Text);
            produtos.LarguraProd = Convert.ToDouble(txt_largura.Text);
            produtos.AlturaProd = Convert.ToDouble(txt_altura.Text);
            produtos.PrecoProd = Convert.ToDouble(txt_precoprod.Text);
            produtos.ProdutoraProduto = txt_produtora.Text;
            produtos.NomeProduto = txt_nomeproduto.Text;
            produtos.CargoFunci = txt_cargofunci.Text;
            produtos.Categoria = txt_categoria.Text;
            produtos.Transpotadora = txt_transpotadora.Text;
            produtos.Data = txt_data.Text;

            return produtos;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            controlProduto.incluir(inserirProdutos());
            controlProduto.salvar();
            MessageBox.Show("Salvo com sucesso", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ControlProduto limpar = new ControlProduto();
            limpar.limparTextBoxes(this.Controls);
        }

        private void GridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ControlProduto prod = new ControlProduto();
            prod.carregaDadosDoArquivoJSon();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            frm_pesquisar pesq = new frm_pesquisar();
            pesq.Show();
            this.Visible = false;
        }

        private void frm_produtos_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
