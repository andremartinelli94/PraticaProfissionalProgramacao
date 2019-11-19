using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoEmpresa.Entidades.Caixa;

namespace ProjetoEmpresa.DAO.Caixa
{
    class DAONotaFiscal
    {
        private List<NotaFiscal> listCaixa = new List<NotaFiscal>();

        public int getTotal()
        {
            return listCaixa.Count;
        }

        public void addnota(NotaFiscal nf)
        {
            listCaixa.Add(nf);
        }

        internal List<NotaFiscal> listaGeral()
        {
            return listCaixa;
        }

        internal void setLista(List<NotaFiscal> lista)
        {
            if (lista != null)
                listCaixa.AddRange(lista);
        }

        public void ordenarListaDecrescente()
        {
            listCaixa = listCaixa.OrderByDescending(x => x.CodigoProduto).ToList();
        }

    }
}
