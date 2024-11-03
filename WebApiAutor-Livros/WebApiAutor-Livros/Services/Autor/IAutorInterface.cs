using WebApiAutor_Livros.DTO.Autor;
using WebApiAutor_Livros.Models;

namespace WebApiAutor_Livros.Services.Autor
{
    // A interface se comunica com o Controller e contém os métodos que a classe "AutorService" irá utilizar
    public interface IAutorInterface
    {
        // Método que irá responder uma lista de todos os autores cadastrados
        Task<ResponseModel<List<AutorModel>>> ListarAutores();

        // Método que irá responder a busca de um autor por ID
        Task<ResponseModel<AutorModel>> BuscarAutorPorId(int idAutor);

        // Método que irá responder a busca de um autor pelo ID do livro
        Task<ResponseModel<AutorModel>> BuscarAutorPorIdLivro(int idLivro);

        // Método que irá criar um novo autor
        Task<ResponseModel<List<AutorModel>>> CriarAutor(AutorCriacaoDto autorCriacaoDto);

        // Método que irá editar um autor
        Task<ResponseModel<List<AutorModel>>> EditarAutor(AutorEdicaoDto autorEdicaoDto);

        // Método que irá excluir um autor
        Task<ResponseModel<List<AutorModel>>> ExcluirAutor(int idAutor);
    }
}
