using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiAutor_Livros.DTO.Livro;
using WebApiAutor_Livros.Models;
using WebApiAutor_Livros.Services.Autor;
using WebApiAutor_Livros.Services.Livro;

namespace WebApiAutor_Livros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        // O Construtor recebe  como parâmetro as informações da interface e guarda na váriavel "_autorInterface" e pode usar os métodos
        private readonly ILivroInterface _livroInterface;
        public LivroController(ILivroInterface livroInterface)
        {
            _livroInterface = livroInterface;
        }

        [HttpGet("ListarLivros")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> ListarAutores()
        {
            var livros = await _livroInterface.ListarLivros();
            return Ok(livros);
        }


        [HttpGet("BuscarLivroPorId/{IdLivro}")]
        public async Task<ActionResult<ResponseModel<LivroModel>>> BuscarLivroPorId(int IdLivro)
        {
            var livro = await _livroInterface.BuscarLivroPorId(IdLivro);
            return Ok(livro);
        }


        [HttpGet("BuscarLivroPorIdAutor/{idAutor}")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> BuscarLivroPorIdAutor(int idAutor)
        {
            var livro = await _livroInterface.BuscarLivroPorIdAutor(idAutor);
            return Ok(livro);
        }


        [HttpPost("CriarLivro")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> CriarLivro(LivroCriacaoDto livroCriacaoDto)
        {
            var livro =  await _livroInterface.CriarLivro(livroCriacaoDto);
            return Ok(livro);
        }
    }
}
