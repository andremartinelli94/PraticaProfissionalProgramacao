using ProjetoEmpresa.Entidades.Vendas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmpresa.DAO.Vendas
{
    class DAOClientes
    {
        private List<Clientes> listClientes = new List<Clientes>();

        public int getTotal()
        {
            return listClientes.Count;
        }

        public void addCliente(Clientes cliente)
        {
            listClientes.Add(cliente);
        }

        public Clientes findCliente(int id)
        {
            return listClientes.Find(x => x.IdCliente == id);
        }

        internal List<Clientes> getAllClientes()
        {
            return listClientes;
        }

        internal void setListaDeClientes(List<Clientes> lista)
        {
            if (lista != null)
                listClientes.AddRange(lista);
        }
    }
}
