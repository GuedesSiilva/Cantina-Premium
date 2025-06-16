using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;


namespace Cantina_Premium
{
    public static class Persistencia
    {
        public static void SalvarLista<T>(List<T> lista, string caminhoArquivo)
        {
            var json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(caminhoArquivo, json);
        }

        public static List<T> CarregarLista<T>(string caminhoArquivo)
        {
            if (!File.Exists(caminhoArquivo))
                return new List<T>();

            var json = File.ReadAllText(caminhoArquivo);
            return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
        }
    }
    public class Usuario
    { public string Nome { get; set; }
        public string Senha { get; set; }
    }
    public static class UsuarioGlobal
    {
        public static List<Usuario> Usuarios = new List<Usuario>();
        public static string UsuarioLogado { get; set; }
    }
}
