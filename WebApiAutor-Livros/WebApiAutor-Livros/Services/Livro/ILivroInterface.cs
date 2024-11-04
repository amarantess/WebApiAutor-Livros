using WebApiAutor_Livros.Models;

namespace WebApiAutor_Livros.Services.Livro
{
    public interface ILivroInterface
    {
        // Método que irá responder uma lista de todos os livros cadastrados
        Task<ResponseModel<List<LivroModel>>> ListarLivros();

        // Método que irá responder a busca de um livro por ID
        Task<ResponseModel<LivroModel>> BuscarLivroPorId(int idLivro);

        // Método que irá responder a busca de um (ou mais) livro pelo ID do autor
        Task<ResponseModel<List<LivroModel>>> BuscarLivroPorIdAutor(int idAutor);

    }
}
