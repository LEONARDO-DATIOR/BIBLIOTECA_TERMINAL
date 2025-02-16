using System.Globalization;

class Program
{
    
    static void Main()
    {
        List<Livros> listaLivros = new List<Livros>();
        listaLivros = ManipulaArquivo.RetornaLivrosArquivo();

        string opcao;
        do {
            Console.WriteLine("Escolha alguma opcao: ");
            Console.WriteLine("C - Cadastras\nE - Exibir\nB - Buscar\nD - Deletar\nS - Sair\n");
            opcao = Console.ReadLine();

            switch (opcao.ToUpper()) {
                case "C":
                    listaLivros = cadastrarLivro(listaLivros);
                    break;
                case "E":
                    foreach (Livros livro in listaLivros) {
                        Console.WriteLine(livro);
                    }
                    break;
                case "B":
                    buscarLivros(listaLivros);
                    break;
                case "D":
                    break;
                case "S":
                    break;
            } 

        } while (opcao.ToUpper() != "S");
    }

    public static List<Livros> cadastrarLivro(List<Livros> listaLivros) {
        Console.Clear();
        Console.WriteLine("Digite os dados do livro: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Data de lancamento: ");
        DateTime dataLancamento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

        Livros livro = new Livros(nome, dataLancamento);
        listaLivros.Add(livro);
        ManipulaArquivo.SalvaDadosLivros(listaLivros);
        return listaLivros;
    }

    public static List<Livros> buscarLivros(List<Livros> listaLivros) {
        List<Livros> listaLivrosEncontrados;
        
        Console.Clear();
        Console.Write("Digite o nome do livro que deseja encontrar: ");
        string nomeLivro = Console.ReadLine();

        listaLivrosEncontrados = listaLivros.Where(livro => livro.Nome.ToUpper() == nomeLivro.ToUpper()).ToList();

        foreach (Livros livro in listaLivrosEncontrados) {
            Console.WriteLine(livro);
        }

        return listaLivrosEncontrados;         
    }


}


