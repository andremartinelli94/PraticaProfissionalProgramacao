using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoEmpresa.Entidades;
using ProjetoEmpresa.Controller;


namespace ProjetoEmpresa.DAO.dao_produtos
{
    class dao_produtos
    {
        private List<Produtos> listaProdutos = new List<Produtos>();
        
        internal List<Produtos> getAllProdutos()
        {
            return listaProdutos;
        }
        public void addProdutos(Produtos produtos)
        {
            listaProdutos.Add(produtos);
        } 
        internal void setListaProdutos(List<Produtos> lista)
        {
            if (lista != null)
                listaProdutos.AddRange(lista);
        }
        
        internal List<Produtos> getlist()
        {
            return listaProdutos;
        }
        public Produtos findProdutoCodigo(int id)
        {
            return listaProdutos.Find(x => x.CodigoProd == id);
        }

        public void remove (Produtos produtos)
        {
            listaProdutos.Remove(produtos);
        }
        



    }
}
