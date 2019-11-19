using ProjetoEmpresa.Controller.Vendas;
using ProjetoEmpresa.Entidades.Vendas;
using ProjetoEmpresa.View.Vendas;
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
    public partial class frm_vendas : Form
    {
        ControlClientes controlclientes = new ControlClientes();

        public int Total()
        {
            return controlclientes.QuantidadeTotaldeClientes();
        }

        public frm_vendas()
        {
            InitializeComponent();
        }

        public Clientes inserirClientes()
        {
            int valor = Total();
            Clientes clientes = new Clientes();
            clientes.IdCliente = valor + 1;
            clientes.Nome = txtNome.Text;
            clientes.Sexo = cboSexo.Text;
            clientes.CPF = mskCPF.Text;
            clientes.RG = mskRG.Text;
            clientes.EstadoCivil = cboEstCiv.Text;
            clientes.DataNascimento = mskNascimento.Text;
            clientes.Nacionalidade = txtNacionalidade.Text;
            clientes.Naturalidade = txtNaturalidade.Text;
            clientes.UFNaturalidade = cboUFNaturalidade.Text;
            clientes.DataCadastro = mskCadastro.Text;
            clientes.Endereco = txtEndereco.Text;
            clientes.Numero = Convert.ToInt32(nud_Numero.Text);
            clientes.Complemento = txtComplemento.Text;
            clientes.Municipio = txtMunicipio.Text;
            clientes.Bairro = txtBairro.Text;
            clientes.UFEndereco = cboUFEndereco.Text;
            clientes.CEP = mskCEP.Text;
            clientes.Telefone = mskTelefone.Text;
            clientes.Celular = mskCelular.Text;
            clientes.Email = txtEmail.Text;

            return clientes;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LimparCampos()
        {
            txtNome.Clear();
            cboSexo.ResetText();
            mskCPF.Clear();
            mskRG.Clear();
            cboEstCiv.ResetText();
            mskNascimento.Clear();
            txtNacionalidade.Clear();
            txtNaturalidade.Clear();
            cboUFNaturalidade.ResetText();
            mskCadastro.Clear();
            txtEndereco.Clear();
            nud_Numero.Text = "0";
            txtComplemento.Clear();
            txtMunicipio.Clear();
            txtBairro.Clear();
            cboUFEndereco.ResetText();
            mskCEP.Clear();
            mskTelefone.Clear();
            mskCelular.Clear();
            txtEmail.Clear();
        }

        private void btn_MenuPesquisa_Click_1(object sender, EventArgs e)
        {
            frm_pesquisa frm = new frm_pesquisa();
            frm.Show();
            this.Close();
        }

        private void frm_vendas_Load_1(object sender, EventArgs e)
        {
            controlclientes.carregaDadosDoArquivoJSon();
            int valor = Total();
            txtQtdRegistros.Text = Convert.ToString(valor);
            txtCodigo.Text = Convert.ToString(valor + 1);
        }

        private void btnADD_Click_1(object sender, EventArgs e)
        {
            controlclientes.incluir(inserirClientes());
            controlclientes.salvar();
            MessageBox.Show("Cliente inserido com sucesso!", "Cadastro realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparCampos();
            int valor = Total();
            txtQtdRegistros.Text = Convert.ToString(valor);
            txtCodigo.Text = Convert.ToString(valor + 1);
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void txtQtdRegistros_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtNacionalidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMunicipio_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskCelular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNaturalidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtComplemento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskCadastro_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskRG_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
