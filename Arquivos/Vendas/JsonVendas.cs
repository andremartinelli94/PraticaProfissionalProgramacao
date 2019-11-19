using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using ProjetoEmpresa.Entidades.Vendas;

namespace ProjetoEmpresa.Arquivos.Vendas
{
    class JsonVendas
    {
        public Boolean salvarArquivoJSon(List<Clientes> listClientes)
        {
            string json = JsonConvert.SerializeObject(listClientes, Formatting.Indented);

            //write string to file
            File.WriteAllText(@"./clientes.json", json);
            return true;
        }

        public List<Clientes> lerArquivoJSon()
        {
            string jsonFilePath = @"./clientes.json";
            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);

                List<Clientes> lista = JsonConvert.DeserializeObject<List<Clientes>>(json);
                return lista;
            }
            return null;
        }
    }
}
