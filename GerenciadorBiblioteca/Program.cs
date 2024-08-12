using GerenciadorBiblioteca;

var execute = true;
var livros = new List<Livro>();

while (execute)
{
    Console.Clear();
    Console.WriteLine("*** Gerenciador de Biblioteca ***");
    Console.WriteLine("1.Cadastrar um livro");
    Console.WriteLine("2.Consultar todos os livros");
    Console.WriteLine("3.Consultar um livro");
    Console.WriteLine("4.Remover um livro");
    Console.WriteLine("5.Sair");

    Console.Write("\nEscolha uma das opções: ");
    var opcaoEscolhida = Console.ReadLine()!;

    switch (opcaoEscolhida)
    {
        case "1":
            Livro.Cadastrar(livros);
            break;
        case "2":
            Livro.Listar(livros);
            break;
        case "3":
            Livro.ConsultarPorId(livros);
            break;
        case "4":
            Livro.RemoverPorId(livros);
            break;
        case "5":
            execute = false;
            break;
        default:
            Console.WriteLine("Opção inválida. Pressione qualquer tecla para voltar para o menu.");
            Console.ReadKey();
            break;
    }
}
