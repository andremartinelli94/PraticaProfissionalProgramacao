using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ProjetoEmpresa.Entidades;

namespace ProjetoEmpresa.Arquivos
{
    class JsonProdutos
    {
        public Boolean salvarArquivosJSon(List<Produtos> listprodutos)
        {
            string json = JsonConvert.SerializeObject(listprodutos, Formatting.Indented);
            File.WriteAllText(@"./Prods.json", json);
            return true;
            
        }
        public List<Produtos> lerArquivoJSon()
        {
            string jsonFilePath = @"./Prods.json";
            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);

                List<Produtos> list = JsonConvert.DeserializeObject<List<Produtos>>(json);
                return list;
            }
            return null;
        }
    }
}
