using System.Text.Json;

namespace GerenciadorBiblioteca
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public int AnoPublicacao { get; set; }

        public static void Cadastrar(List<Livro> livros)
        {
            var livro = new Livro();
            
            Console.Write("Informe o título do livro: ");
            livro.Titulo = Console.ReadLine()!;
           
            Console.Write("Informe o id do livro: ");
            livro.Id = int.Parse(Console.ReadLine()!);
            
            Console.Write("Informe o autor do livro: ");
            livro.Autor = Console.ReadLine()!;
           
            Console.Write("Informe o ISBN do livro: ");
            livro.ISBN = Console.ReadLine()!;
            
            Console.Write("Informe o ano de publicação do livro: ");
            livro.AnoPublicacao = int.Parse(Console.ReadLine()!);

            livros.Add(livro);

            Console.WriteLine("\nLivro cadastrado com sucesso!");
            Console.WriteLine("\nPressione qualquer tecla para voltar para o menu.");
            Console.ReadKey();
        }

        public static void Listar(List<Livro> livros)
        {
            Console.WriteLine("\nLivros cadastrados:\n");

            foreach (var livro in livros)
            {
                Console.WriteLine(JsonSerializer.Serialize(livro));
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar para o menu.");
            Console.ReadKey();
        }

        public static void ConsultarPorId(List<Livro> livros)
        {
            Console.Write("\nDigite o id do livro: ");
            var idInformado = Console.ReadLine()!;

            var livro = BuscarLivro(livros, idInformado);

            if (livro == null)
            {
                Console.WriteLine("\nLivro não encontrado.");
            }
            else
            {
                Console.WriteLine(JsonSerializer.Serialize(livro));
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar para o menu.");
            Console.ReadKey();
        }

        public static void RemoverPorId(List<Livro> livros)
        {
            Console.Write("\nDigite o id do livro que deseja remover: ");
            var idInformado = Console.ReadLine()!;

            var livro = BuscarLivro(livros, idInformado);

            if (livro == null)
            {
                Console.WriteLine("\nLivro não encontrado.");
            }
            else
            {
                livros.Remove(livro);

                Console.WriteLine("\nLivro removido com sucesso!");
            }
            
            Console.WriteLine("\nPressione qualquer tecla para voltar para o menu.");
            Console.ReadKey();
        }

        private static Livro BuscarLivro(List<Livro> livros, string idInformado)
        {
            return livros.Find(l => l.Id == int.Parse(idInformado));
        }
    }
}
