using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoEmpresa.Arquivos.Caixa;
using ProjetoEmpresa.DAO.Caixa;
using ProjetoEmpresa.Entidades.Caixa;

namespace ProjetoEmpresa.Controller.Caixa
{
    public class ControlNotaFiscal
    {
        private DAONotaFiscal daoNF = new DAONotaFiscal();

        public void carregaDadosDoArquivoJSon()
        {
            List<NotaFiscal> lista = (new JsonCaixa()).lerArquivoJSonPedido();
            daoNF.setLista(lista);
        }

        public void salvar()
        {
            new JsonCaixa().salvarArquivoJSonPedido(daoNF.listaGeral());
        }

        public void incluir(NotaFiscal nf)
        {
            daoNF.addnota(nf);
        }

        public int QuantidadeTotal()
        {
            return daoNF.getTotal();
        }

        public void ordenaLista()
        {
            daoNF.ordenarListaDecrescente();
        }

        public List<NotaFiscal> listadgv()
        {
            return daoNF.listaGeral();
        }
    }
}
