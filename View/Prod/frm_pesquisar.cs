using ProjetoEmpresa.Controller;
using ProjetoEmpresa.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEmpresa.View.Prod
{
    public partial class frm_pesquisar : Form
    {
        ControlProduto controlProduto = new ControlProduto();

        public frm_pesquisar()
        {
            InitializeComponent();
        }

        private void frm_pesquisar_Load(object sender, EventArgs e)
        {
            controlProduto.carregaDadosDoArquivoJSon();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_MenuCadastro_Click(object sender, EventArgs e)
        {
            frm_produtos prod = new frm_produtos();
            prod.Show();
            this.Visible = false;
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            if (txt_pesquisar.Text != "")
            {
                Produtos produtos = controlProduto.pesqCodigo(Convert.ToInt32(txt_pesquisar.Text));
                mostraResultadosPesq(produtos);
                
            }
        }
        private void mostraResultadosPesq(Produtos produtos)
        {
            if(produtos != null)
            {
                txt_codigoprod.Text = Convert.ToString(produtos.CodigoProd);
                txt_itens.Text = Convert.ToString(produtos.ItensProd);
                txt_quantidadeprod.Text = Convert.ToString(produtos.QuantidadeProd);
                txt_pesoliq.Text = Convert.ToString(produtos.PesoLiqProd);
                txt_pesobru.Text = Convert.ToString(produtos.PesoProd);
                txt_largura.Text = Convert.ToString (produtos.LarguraProd);
                txt_altura.Text = Convert.ToString(produtos.AlturaProd);
                txt_precoprod.Text = Convert.ToString(produtos.PrecoProd);
                txt_produtora.Text = Convert.ToString(produtos.ProdutoraProduto);
                txt_nomeproduto.Text = Convert.ToString(produtos.NomeProduto);
                txt_cargofunci.Text = Convert.ToString(produtos.CargoFunci);
                txt_categoria.Text = Convert.ToString(produtos.Categoria);
                txt_transpotadora.Text = Convert.ToString(produtos.Transpotadora);
                txt_data.Text = Convert.ToString(produtos.Data);
            }
            else
            {
                MessageBox.Show("Produto não encontrado!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Limpa()
        {
            txt_altura.Clear();
            txt_cargofunci.Clear();
            txt_categoria.Clear();
            txt_codigoprod.Clear();
            txt_data.Clear();
            txt_itens.Clear();
            txt_largura.Clear();
            txt_nomeproduto.Clear();
            txt_pesobru.Clear();
            txt_pesoliq.Clear();
            txt_precoprod.Clear();
            txt_produtora.Clear();
            txt_quantidadeprod.Clear();
            txt_transpotadora.Clear();
            txt_pesquisar.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Limpa();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (txt_pesquisar.Text != "")
            {
                Produtos produtos = controlProduto.pesqCodigo(Convert.ToInt32(txt_pesquisar.Text));
                if (produtos != null)
                {
                    DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esse produto ?", "ALERTA", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        controlProduto.Excluir(produtos);
                        Limpa();
                    }
     
                }
                else
                {
                    MessageBox.Show("Produto não encontrado ou já excluido !!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            controlProduto.salvar2();
            MessageBox.Show("Salvo com sucesso", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
