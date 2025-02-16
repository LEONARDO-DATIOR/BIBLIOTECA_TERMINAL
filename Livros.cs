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


}