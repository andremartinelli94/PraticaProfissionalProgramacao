using System;
using System.Collections.Generic;
using System.IO;
using ProjetoEmpresa.Entidades.Caixa;
using Newtonsoft.Json;

namespace ProjetoEmpresa.Arquivos.Caixa
{
    class JsonPlanilha
    {
        public Boolean salvarArquivoJSonPlanilha(List<Planilha> list)
        {
            string json = JsonConvert.SerializeObject(list, Formatting.Indented);

            //write string to file
            File.WriteAllText(@"./planilha.json", json);
            return true;
        }

        public List<Planilha> lerArquivoJSonPlanilha()
        {
            string jsonFilePath = @"./planilha.json";
            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);

                List<Planilha> lista = JsonConvert.DeserializeObject<List<Planilha>>(json);
                return lista;
            }
            return null;
        }
    }
}
