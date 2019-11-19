using ProjetoEmpresa.Entidades.Fornecedores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmpresa.DAO.Fornecedores
{
    class DAOFornecedor
    {

        private List<Fornecedor> listaFornecedores = new List<Fornecedor>();

        public int getTotal()
        {
            return listaFornecedores.Count;
        }

        public void AddFornecedor(Fornecedor fornecedor)
        {
            listaFornecedores.Add(fornecedor);
        }

        internal List<Fornecedor> getAllFornecedor()
        {
            return listaFornecedores;
        }

        public Fornecedor findFornecedorNome(string nome)
        {
            return listaFornecedores.Find(x => x.NomeFornecedor.Contains(nome));
        }

        internal void setListaFornecedores(List<Fornecedor> lista)
        {
            if (lista != null)
                listaFornecedores.AddRange(lista);

        }

    }
}
