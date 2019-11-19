using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmpresa.Entidades.Vendas
{
    public class Clientes
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string EstadoCivil { get; set; }
        public string DataNascimento { get; set; }
        public string Nacionalidade { get; set; }
        public string Naturalidade { get; set; }
        public string UFNaturalidade { get; set; }
        public string DataCadastro { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Municipio { get; set; }
        public string Bairro { get; set; }
        public string UFEndereco { get; set; }
        public string CEP { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
    }
}
