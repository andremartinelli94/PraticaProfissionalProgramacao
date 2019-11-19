using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmpresa.Entidades.Empregados
{
    public class Funcionario
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string Filhos { get; set; }
        public int QntFilhos { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string OrgaoEmissor { get; set; }
        public string OrgaoEmissorUF { get; set; }
        public string EstadoCivil { get; set; }
        public string CTPS { get; set; }
        public string Serie { get; set; }
        public string CNH { get; set; }
        public string Categoria { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string UFEndereco { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string DataAdmissao { get; set; }
        public string Escolaridade { get; set; }
        public string SalarioBase { get; set; }
        public string Cargo { get; set; }
        public string Beneficios { get; set; }
    }
}
