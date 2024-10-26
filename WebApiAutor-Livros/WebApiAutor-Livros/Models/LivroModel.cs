namespace WebApiAutor_Livros.Models
{
    // É a classe que vai ser mapeada e vai servir como base para a tabela "Livros"
    public class LivroModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }

        // Cada livro tem um autor específico
        public AutorModel Autor { get; set; }
    }
}
