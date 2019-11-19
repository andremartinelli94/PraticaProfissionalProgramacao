using Newtonsoft.Json;
using ProjetoEmpresa.Entidades.Pedidos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjetoEmpresa.Arquivos.Pedidos
{
    class JsonPedidos
    {
        public Boolean salvarArquivoJSonPedido(List<Pedido> listPedidos)
        {
            string json = JsonConvert.SerializeObject(listPedidos, Formatting.Indented);

            //write string to file
            File.WriteAllText(@"./pedidos.json", json);
            return true;
        }

        public List<Pedido> lerArquivoJSonPedido()
        {
            string jsonFilePath = @"./pedidos.json";
            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);

                List<Pedido> lista = JsonConvert.DeserializeObject<List<Pedido>>(json);
                return lista;
            }
            return null;
        }
    }
}
