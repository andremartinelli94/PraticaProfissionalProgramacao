using ProjetoEmpresa.Arquivos.Empregados;
using ProjetoEmpresa.DAO.Empregados;
using ProjetoEmpresa.Entidades.Empregados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmpresa.Controller.Empregados
{
    class ControlEmpregados
    {
        private DAOEmpregados daoEmpregados = new DAOEmpregados();

        public void carregaDadosDoArquivoJSon()
        {
            List<Funcionario> lista = (new JsonEmpregados()).lerArquivoJSon();
            daoEmpregados.setListaDeEmpregados(lista);
        }

        public void salvar()
        {
            new JsonEmpregados().salvarArquivoJSon(daoEmpregados.getAllEmpregados());
        }

        public void incluir(Funcionario empregado)
        {
            daoEmpregados.addCliente(empregado);
        }

        public int QuantidadeTotaldeEmpregados()
        {
            return daoEmpregados.getTotal();
        }
    }
}
