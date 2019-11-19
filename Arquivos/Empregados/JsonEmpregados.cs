using Newtonsoft.Json;
using ProjetoEmpresa.Entidades.Empregados;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmpresa.Arquivos.Empregados
{
    class JsonEmpregados
    {
        public Boolean salvarArquivoJSon(List<Funcionario> listEmpregados)
        {
            string json = JsonConvert.SerializeObject(listEmpregados, Formatting.Indented);

            //write string to file
            File.WriteAllText(@"./empregados.json", json);
            return true;
        }

        public List<Funcionario> lerArquivoJSon()
        {
            string jsonFilePath = @"./empregados.json";
            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);

                List<Funcionario> lista = JsonConvert.DeserializeObject<List<Funcionario>>(json);
                return lista;
            }
            return null;
        }
    }
}
