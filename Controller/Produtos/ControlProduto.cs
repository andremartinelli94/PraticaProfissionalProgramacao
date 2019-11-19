using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoEmpresa.DAO.dao_produtos;
using ProjetoEmpresa.Entidades;
using ProjetoEmpresa;
using ProjetoEmpresa.Arquivos;
using System.Windows.Forms;


namespace ProjetoEmpresa.Controller
{
    class ControlProduto
    {
        private dao_produtos daoProduto = new dao_produtos();

        public void salvar()
        {
            new JsonProdutos().salvarArquivosJSon(daoProduto.getAllProdutos());
        }
        public void salvar2()
        {
            new JsonProdutos().salvarArquivosJSon(daoProduto.getAllProdutos());
        }

        public void incluir(Produtos produtos)
        {
            daoProduto.addProdutos(produtos);
        }
        public void Excluir(Produtos produtos)
        {
            daoProduto.remove(produtos);
        }
        public void carregaDadosDoArquivoJSon()
        {
            List<Produtos> lista = (new JsonProdutos()).lerArquivoJSon();
            daoProduto.setListaProdutos(lista);
            
        }

        public void limparTextBoxes(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                }
                else if (ctrl is MaskedTextBox)
                {
                    ((MaskedTextBox)(ctrl)).Text = String.Empty;
                }
            }
        }
        public Produtos pesqCodigo(int id)
        {
            Produtos pesq2 = null;
            pesq2 = daoProduto.findProdutoCodigo(id);
            return pesq2;
        }

    }
}
