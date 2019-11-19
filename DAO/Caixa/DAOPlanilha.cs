using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoEmpresa.Entidades.Caixa;

namespace ProjetoEmpresa.DAO.Caixa
{
    class DAOPlanilha
    {
        private List<Planilha> list = new List<Planilha>();

        public void addnota(Planilha nf)
        {
            list.Add(nf);
        }

        internal List<Planilha> listaGeral()
        {
            return list;
        }

        internal void setLista(List<Planilha> lista)
        {
            if (lista != null)
                list.AddRange(lista);
        }

        public void ordenarListaCategoria()
        {
            list = list.OrderByDescending(x => x.Categoria).ToList();
        }
    }
}
