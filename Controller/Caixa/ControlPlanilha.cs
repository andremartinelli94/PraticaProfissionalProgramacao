using System.Collections.Generic;
using ProjetoEmpresa.Arquivos.Caixa;
using ProjetoEmpresa.DAO.Caixa;
using ProjetoEmpresa.Entidades.Caixa;
namespace ProjetoEmpresa.Controller.Caixa
{
    public class ControlPlanilha
    {
        private DAOPlanilha daoPlanilha = new DAOPlanilha();

        public void carregaDadosDoArquivoJSon()
        {
            List<Planilha> lista = (new JsonPlanilha()).lerArquivoJSonPlanilha();
            daoPlanilha.setLista(lista);
        }
        public void salvar()
        {
            new JsonPlanilha().salvarArquivoJSonPlanilha(daoPlanilha.listaGeral());
        }

        public void incluir(Planilha dados)
        {
            daoPlanilha.addnota(dados);
        }

        public void ordenaLista()
        {
            daoPlanilha.ordenarListaCategoria();
        }

        public List<Planilha> listadgv()
        {
            return daoPlanilha.listaGeral();
        }
    }
}