using System.Text.Json.Serialization;

namespace WebApiAutor_Livros.Models
{
    // É a classe que vai ser mapeada e vai servir como base para a tabela "Autor"
    public class AutorModel
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Sobrenome {  get; set; } =  string.Empty;

        // Diretiva que impede que a lista "Livros" seja mostrada no swagger e que não precise passar os livros na hora de criar um autor
        [JsonIgnore]

        // Cada autor pode ter vários livros cadastrados
        public ICollection <LivroModel> Livros { get; set; }
    }
}
