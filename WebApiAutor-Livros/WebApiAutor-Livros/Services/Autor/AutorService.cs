using Microsoft.EntityFrameworkCore;
using WebApiAutor_Livros.Data;
using WebApiAutor_Livros.Models;

namespace WebApiAutor_Livros.Services.Autor
{
    // A classe implementa os métodos que estão na interface
    public class AutorService : IAutorInterface
    {
        // O construtor recebe as informações do  banco de dados como parâmetro e passa para a variavel "_context"
        private readonly AppDbContext _context;
        public AutorService(AppDbContext context)
        {
            _context = context;
        }

        // Métodos da interface
        public Task<ResponseModel<AutorModel>> BuscarAutorPorId(int idAutor)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<AutorModel>> BuscarAutorPorIdLivro(int idLivro)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseModel<List<AutorModel>>> ListarAutores()
        {
            ResponseModel<List<AutorModel>> resposta = new ResponseModel<List<AutorModel>>();
            try
            {

                var autores = await _context.Autores.ToListAsync();

                resposta.Dados = autores;
                resposta.Mensagem = "Todos os autores foram coletados!";

                return resposta;

            }
            catch (Exception ex)
            {
                resposta.Mensagem = ex.Message;
                resposta.Status = false;
                return resposta;
            }
        }

    }
}
