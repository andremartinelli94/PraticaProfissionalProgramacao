using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using ProjetoEmpresa.Entidades.Caixa;


namespace ProjetoEmpresa.Arquivos.Caixa
{
    class JsonCaixa
    {
        public Boolean salvarArquivoJSonPedido(List<NotaFiscal> listPedidos)
        {
            string json = JsonConvert.SerializeObject(listPedidos, Formatting.Indented);

            //write string to file
            File.WriteAllText(@"./caixa.json", json);
            return true;
        }

        public List<NotaFiscal> lerArquivoJSonPedido()
        {
            string jsonFilePath = @"./caixa.json";
            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);

                List<NotaFiscal> lista = JsonConvert.DeserializeObject<List<NotaFiscal>>(json);
                return lista;
            }
            return null;
        }
    }
}
