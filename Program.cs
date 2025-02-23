using System.Globalization;

class Program
{
    
    static void Main()
    {
        List<Livros> listaLivros = new List<Livros>();
        listaLivros = ManipulaArquivo.RetornaLivrosArquivo();

        string opcao;
        do {
            Console.WriteLine("\n------------------\nEscolha alguma opcao: ");
            Console.WriteLine("C - Cadastras\nE - Exibir\nA - Alterar\nB - Buscar\nD - Deletar\nS - Sair\n");
            opcao = Console.ReadLine();
            Livros Livro = new Livros();
            switch (opcao.ToUpper()) {
                case "C":
                    listaLivros = Livro.CadastrarLivros(listaLivros);
                    break;
                case "E":
                    foreach (Livros livro in listaLivros) {
                        Console.WriteLine(livro);
                    }
                    break;
                case "A":
                    Livro.AtualizarLivros(listaLivros);
                    break;
                case "B":
                    listaLivros = Livro.BuscarLivros(listaLivros);
                    break;
                case "D":
                    listaLivros = Livro.DeletarLivros(listaLivros);
                    break;
                case "S":
                    break;
            } 

        } while (opcao.ToUpper() != "S");
    }


}


