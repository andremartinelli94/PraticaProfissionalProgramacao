using ProjetoEmpresa.Arquivos.Fornecedores;
using ProjetoEmpresa.DAO.Fornecedores;
using ProjetoEmpresa.Entidades.Fornecedores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmpresa.Controller.Fornecedores
{
    class ControlFornecedor
    {
        private DAOFornecedor daoFornecedor = new DAOFornecedor();

        public void carregaDadosDoArquivoJson()
        {

            List<Fornecedor> lista = (new JsonFornecedor()).lerArquivoJSonFornecedor();
            daoFornecedor.setListaFornecedores(lista);
        }

        public void salvar()
        {
            new JsonFornecedor().salvarArquivoJSonFornecedor(daoFornecedor.getAllFornecedor());
        }

        public void incluir(Fornecedor fornecedor)
        {
            daoFornecedor.AddFornecedor(fornecedor);
        }

        public int quantidadeTotal()
        {
            return daoFornecedor.getTotal();
        }

        public Fornecedor pesquisar(string buscar)
        {
            Fornecedor fornecedor = null;
            fornecedor = daoFornecedor.findFornecedorNome(buscar);
            return fornecedor;
        }

        public void mostraResultadoPesquisa(Fornecedor fornecedor)
        {
            if (fornecedor != null)
            {

            }

            else
            {
                Console.WriteLine("Fornecedor não encontrado!");
            }

        }
    }
}
