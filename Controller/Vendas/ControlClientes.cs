using ProjetoEmpresa.Arquivos.Vendas;
using ProjetoEmpresa.DAO.Vendas;
using ProjetoEmpresa.Entidades.Vendas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmpresa.Controller.Vendas
{
    class ControlClientes
    {
        private DAOClientes daoClientes = new DAOClientes();

        public void carregaDadosDoArquivoJSon()
        {
            List<Clientes> lista = (new JsonVendas()).lerArquivoJSon();
            daoClientes.setListaDeClientes(lista);
        }

        public void salvar()
        {
            new JsonVendas().salvarArquivoJSon(daoClientes.getAllClientes());
        }

        public void incluir(Clientes cliente)
        {
            daoClientes.addCliente(cliente);
        }

        public int QuantidadeTotaldeClientes()
        {
            return daoClientes.getTotal();
        }

        public Clientes pesquisar(int buscar)
        {
            Clientes cliente = null;
            cliente = daoClientes.findCliente(buscar);
            return cliente;
        }
    
    }
}
