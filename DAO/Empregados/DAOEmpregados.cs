using ProjetoEmpresa.Entidades.Empregados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmpresa.DAO.Empregados
{
    class DAOEmpregados
    {
        private List<Funcionario> listEmpregados = new List<Funcionario>();

        public int getTotal()
        {
            return listEmpregados.Count;
        }

        public void addCliente(Funcionario empregados)
        {
            listEmpregados.Add(empregados);
        }

        internal List<Funcionario> getAllEmpregados()
        {
            return listEmpregados;
        }

        internal void setListaDeEmpregados(List<Funcionario> lista)
        {
            if (lista != null)
                listEmpregados.AddRange(lista);
        }
    }
}
