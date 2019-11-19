using ProjetoEmpresa.Entidades.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmpresa.DAO.Pedidos
{
    class DAOPedido
    {

        private List<Pedido> listaPedidos = new List<Pedido>();
        private List<Pedido> listaPedido;

        public int getTotal()
        {
            return listaPedidos.Count;
        }

        public void AddPedidos(Pedido pedido)
        {
            listaPedidos.Add(pedido);
        }

        internal List<Pedido> getAllPedidos()
        {
            return listaPedido;
        }

        public Pedido findPedidoNome(string nome)
        {
            return listaPedidos.Find(x => x.NomeProduto.Contains(nome));
        }

        internal void setListaPedidos(List<Pedido> lista)
        {
            if (lista != null)
                listaPedidos.AddRange(lista);

        }
    }
}
