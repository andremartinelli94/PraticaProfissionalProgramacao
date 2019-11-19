using ProjetoEmpresa.Arquivos.Pedidos;
using ProjetoEmpresa.DAO.Pedidos;
using ProjetoEmpresa.Entidades.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmpresa.Controller.Pedidos
{
    class ControlPedido
    {
        private DAOPedido daoPedidos = new DAOPedido();

        public void carregaDadosDoArquivoJson()
        {

            List<Pedido> lista = (new JsonPedidos()).lerArquivoJSonPedido();
            daoPedidos.setListaPedidos(lista);
        }

        public void salvar()
        {
            new JsonPedidos().salvarArquivoJSonPedido(daoPedidos.getAllPedidos());
        }

        public void incluir(Pedido pedido)
        {
            daoPedidos.AddPedidos(pedido);
        }

        public int quantidadeTotal()
        {
            return daoPedidos.getTotal();
        }

        public Pedido pesquisar(string buscar)
        {
            Pedido pedido = null;
            pedido = daoPedidos.findPedidoNome(buscar);
            return pedido;
        }

        public void mostraResultadoPesquisa(Pedido pedido)
        {
            if (pedido != null)
            {

            }

            else
            {
                Console.WriteLine("Pedido não encontrado!");
            }

        }
    }
}
