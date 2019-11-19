using ProjetoEmpresa.Controller.Vendas;
using ProjetoEmpresa.Entidades.Vendas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEmpresa.View.Vendas
{
    public partial class frm_pesquisa : Form
    {
        ControlClientes controlclientes = new ControlClientes();

        public frm_pesquisa()
        {
            InitializeComponent();
        }

        private void frm_pesquisa_Load(object sender, EventArgs e)
        {
            controlclientes.carregaDadosDoArquivoJSon();
            btnNovaPesquisa.Visible = false;
        }

        private void mostraResultadoPesquisa(Clientes cliente)
        {
            if (cliente != null)
            {
                txtCodigo.Text = Convert.ToString(cliente.IdCliente);
                txtNome.Text = cliente.Nome;
                txtSexo.Text = cliente.Sexo;
                txtCPF.Text = cliente.CPF;
                txtRG.Text = cliente.RG;
                txtEstCiv.Text = cliente.EstadoCivil;
                txtNascimento.Text = cliente.DataNascimento;
                txtNacionalidade.Text = cliente.Nacionalidade;
                txtNaturalidade.Text = cliente.Naturalidade;
                txtUFNaturalidade.Text = cliente.UFNaturalidade;
                txtCadastro.Text = cliente.DataCadastro;
                txtEndereco.Text = cliente.Endereco;
                txtNumero.Text = Convert.ToString(cliente.Numero);
                txtComplemento.Text = cliente.Complemento;
                txtMunicipio.Text = cliente.Municipio;
                txtBairro.Text = cliente.Bairro;
                txtUFEndereco.Text = cliente.UFEndereco;
                txtCEP.Text = cliente.CEP;
                txtTelefone.Text = cliente.Telefone;
                txtCelular.Text = cliente.Celular;
                txtEmail.Text = cliente.Email;
            }
            else
            {
                MessageBox.Show("Registro de cliente não encontrado!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LimparCampos()
        {
            txtBuscar.Clear();
            txtCodigo.Clear();
            txtNome.Clear();
            txtSexo.Clear();
            txtCPF.Clear();
            txtRG.Clear();
            txtEstCiv.Clear();
            txtNascimento.Clear();
            txtNacionalidade.Clear();
            txtNaturalidade.Clear();
            txtUFNaturalidade.Clear();
            txtCadastro.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtMunicipio.Clear();
            txtBairro.Clear();
            txtUFEndereco.Clear();
            txtCEP.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtEmail.Clear();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_MenuCadastro_Click(object sender, EventArgs e)
        {
            frm_vendas frm = new frm_vendas();
            frm.Show();
            this.Close();
        }

        private void btnFind_Click_1(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                Clientes cliente = controlclientes.pesquisar(Convert.ToInt32(txtBuscar.Text));
                mostraResultadoPesquisa(cliente);
                if (cliente != null)
                {
                    btnFind.Visible = false;
                    btnNovaPesquisa.Visible = true;
                }
            }
        }

        private void btnNovaPesquisa_Click_1(object sender, EventArgs e)
        {
            LimparCampos();
            btnNovaPesquisa.Visible = false;
            btnFind.Visible = true;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
