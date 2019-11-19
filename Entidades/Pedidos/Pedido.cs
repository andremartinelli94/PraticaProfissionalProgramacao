using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmpresa.Entidades.Pedidos
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public string Funcionario { get; set; }
        public string Cargo { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public string NomeProduto { get; set; }
        public string Categoria { get; set; }
        public string DataCadastro { get; set; }
    }
}
