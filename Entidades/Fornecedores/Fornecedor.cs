using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmpresa.Entidades.Fornecedores
{
    public class Fornecedor
    {
        public int IdFornecedor { get; set; }
        public string NomeFornecedor { get; set; }
        public string NomeProdutoFornecedor { get; set; }
        public string Categoria { get; set; }
        public string Cnpj { get; set; }
        public string DataCadastro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
    }
}
