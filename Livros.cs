using System.Globalization;

public class Livros {
    // ATRIBUTO
    private string _nome;
    private DateTime _dataLancamento;

    // PROPRIEDADES
    public string Nome {
        get { return _nome; }
        set { _nome = value; }
    }

    public DateTime DataLancamento {
        get { return _dataLancamento; }
        set { _dataLancamento = value; }
    }

    // CONSTRUTORES
    public Livros() { }

    public Livros(string nome) {
        _nome = nome;
    }

    public Livros(string nome, DateTime dataLancamento) {
        _nome = nome;
        _dataLancamento = dataLancamento;
    }


    // TOSTRING
    public override string ToString() {
        return "O livro - " + _nome + " foi lancado em " + _dataLancamento;
    }

    // METODOS
    public List<Livros> CadastrarLivros(List<Livros> listaLivros) {
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

    public List<Livros> BuscarLivros(List<Livros> listaLivros) {
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

    // public List<Livros> AtualizarLivros(List<Livros> listaLivros) {

    // }

    public List<Livros> DeletarLivros(List<Livros> listaLivros) {
         Console.Clear();
        Console.WriteLine("Digite o nome do livro que deseja deletar: ");
        string nomeDeletar = Console.ReadLine();
        bool existe = listaLivros.Any(Livro => Livro.Nome == nomeDeletar);
        if (existe) {
            listaLivros.RemoveAll(livro => livro.Nome == nomeDeletar);      
            Console.WriteLine("Livro deletado com sucesso!");
            ManipulaArquivo.SalvaDadosLivros(listaLivros);
        } else {
            Console.WriteLine("Livro não encontrado!");
        }

        return listaLivros;
    }


}