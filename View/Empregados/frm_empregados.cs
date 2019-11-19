using ProjetoEmpresa.Controller.Empregados;
using ProjetoEmpresa.Entidades.Empregados;
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
    public partial class frm_empregados : Form
    {
        ControlEmpregados controlempregados = new ControlEmpregados();
        public frm_empregados()
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

        private void frm_empregados_Load(object sender, EventArgs e)
        {
            controlempregados.carregaDadosDoArquivoJSon();
            int valor = Total();
            txtCodigo.Text = Convert.ToString(valor + 1);
        }
        

        public int Total()
        {
            return controlempregados.QuantidadeTotaldeEmpregados();
        }

        public Funcionario InserirEmpregado()
        {
            int valor = Total();
            Funcionario empregado = new Funcionario();
            empregado.Matricula = valor + 1;
            empregado.Nome = txtNome.Text;
            empregado.DataNascimento = mskNascimento.Text;
            empregado.Sexo = cboSexo.Text;
            empregado.Filhos = cboFilhos.Text;
            empregado.QntFilhos = Convert.ToInt32(nud_Filhos.Text);
            empregado.CPF = mskCPF.Text;
            empregado.RG = mskRG.Text;
            empregado.OrgaoEmissor = txtOrgaoEmissor.Text;
            empregado.OrgaoEmissorUF = cboUFOrgaoEmissor.Text;
            empregado.EstadoCivil = cboEstCiv.Text;
            empregado.CTPS = mskCTPS.Text;
            empregado.Serie = mskSerie.Text;
            empregado.CNH = mskCNH.Text;
            empregado.Categoria = cboCategoria.Text;
            empregado.CEP = mskCEP.Text;
            empregado.Endereco = txtEndereco.Text;
            empregado.Numero = Convert.ToInt32(nud_Numero.Text);
            empregado.Complemento = txtComplemento.Text;
            empregado.Bairro = txtBairro.Text;
            empregado.Municipio = txtMunicipio.Text;
            empregado.UFEndereco = cboUFEndereco.Text;
            empregado.Telefone = mskTelefone.Text;
            empregado.Celular = mskCelular.Text;
            empregado.Email = txtEmail.Text;
            empregado.DataAdmissao = mskAdmissao.Text;
            empregado.Escolaridade = cboEscolaridade.Text;
            empregado.SalarioBase = mskSalario.Text;
            empregado.Cargo = txtCargo.Text;
            empregado.Beneficios = cboBeneficios.Text;
            return empregado;
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            mskNascimento.Clear();
            cboSexo.ResetText();
            cboFilhos.ResetText();
            nud_Filhos.Text = "0";
            mskCPF.Clear();
            mskRG.Clear();
            txtOrgaoEmissor.Clear();
            cboUFOrgaoEmissor.ResetText();
            cboEstCiv.ResetText();
            mskCTPS.Clear();
            mskSerie.Clear();
            mskCNH.Clear();
            cboCategoria.ResetText();
            mskCEP.Clear();
            txtEndereco.Clear();
            nud_Numero.Text = "0";
            txtComplemento.Clear();
            txtBairro.Clear();
            txtMunicipio.Clear();
            cboUFEndereco.ResetText();
            mskTelefone.Clear();
            mskCelular.Clear();
            txtEmail.Clear();
            mskAdmissao.Clear();
            cboEscolaridade.ResetText();
            mskSalario.Clear();
            txtCargo.Clear();
            cboBeneficios.ResetText();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnADD_Click_1(object sender, EventArgs e)
        {
            controlempregados.incluir(InserirEmpregado());
            controlempregados.salvar();
            MessageBox.Show("Empregado cadastrado com sucesso!", "Cadastro realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparCampos();
            int valor = Total();
            txtCodigo.Text = Convert.ToString(valor + 1);
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
