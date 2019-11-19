using Newtonsoft.Json;
using ProjetoEmpresa.Entidades.Fornecedores;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmpresa.Arquivos.Fornecedores
{
    class JsonFornecedor
    {
        public Boolean salvarArquivoJSonFornecedor(List<Fornecedor> listFornecedor)
        {
            string json = JsonConvert.SerializeObject(listFornecedor, Formatting.Indented);

            //write string to file
            File.WriteAllText(@"./fornecedor.json", json);
            return true;
        }

        public List<Fornecedor> lerArquivoJSonFornecedor()
        {
            string jsonFilePath = @"./fornecedor.json";
            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);

                List<Fornecedor> lista = JsonConvert.DeserializeObject<List<Fornecedor>>(json);
                return lista;
            }
            return null;
        }
    }
}
