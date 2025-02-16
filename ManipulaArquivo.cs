using System.Text.Json;

public class ManipulaArquivo() {

    public static string caminhoArquivoLivros = @"C:\Users\leona\Documents\estudos\c#\TesteDotNet\bin\Debug\testeTexto.json";

    public static void SalvaDadosLivros(List<Livros> listaLivros) {
        string json = JsonSerializer.Serialize(listaLivros, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(caminhoArquivoLivros, string.Empty);
        File.WriteAllText(caminhoArquivoLivros, json);
        Console.WriteLine("SALVANDO LIVROS NO ARQUIVO.");

    } 

    public static List<Livros> RetornaLivrosArquivo() {
        bool existeArquivo = File.Exists(caminhoArquivoLivros);

        List<Livros> listaLivros = new List<Livros>();
        if (!existeArquivo) {
            return listaLivros;
        } else {
            Console.WriteLine("TESTEEEE");
            string json = File.ReadAllText(caminhoArquivoLivros);
            Console.WriteLine(json);
            listaLivros = JsonSerializer.Deserialize<List<Livros>>(json) ?? new List<Livros>();
            return listaLivros;
        }
    }

}