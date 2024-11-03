using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiAutor_Livros.DTO.Autor;
using WebApiAutor_Livros.Models;
using WebApiAutor_Livros.Services.Autor;

namespace WebApiAutor_Livros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        // O Construtor recebe  como parâmetro as informações da interface e guarda na váriavel "_autorInterface" e pode usar os métodos
        private readonly IAutorInterface _autorInterface;
        public AutorController(IAutorInterface autorInterface)
        {
            _autorInterface = autorInterface;
        }

        // Criando o endpoint de tipo GET
        [HttpGet("ListarAutores")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> ListarAutores()
        {
            var autores = await _autorInterface.ListarAutores();
            return Ok(autores);
        }


        [HttpGet("BuscarAutorPorId/{idAutor}")]
        public async Task<ActionResult<ResponseModel<AutorModel>>> BuscarAutorPorId(int idAutor)
        {
            var autor = await _autorInterface.BuscarAutorPorId(idAutor);
            return Ok(autor);
        }


        [HttpGet("BuscarAutorPorIdLivro/{idLivro}")]
        public async Task<ActionResult<ResponseModel<AutorModel>>> BuscarAutorPorIdLivro(int idLivro)
        {
            var autor = await _autorInterface.BuscarAutorPorIdLivro(idLivro);
            return Ok(autor);
        }


        [HttpPost("CriarAutor")]
        public async Task<ActionResult<ResponseModel<AutorModel>>> CriarAutor(AutorCriacaoDto autorCriacaoDto)
        {
            var autores = await _autorInterface.CriarAutor(autorCriacaoDto);
            return Ok(autores);
        }


        [HttpPut("EditarAutor")]
        public async Task<ActionResult<ResponseModel<AutorModel>>> EditarAutor(AutorEdicaoDto autorEdicaoDto)
        {
            var autores = await _autorInterface.EditarAutor(autorEdicaoDto);
            return Ok(autores);
        }


        [HttpDelete("ExcluirAutor/{idAutor}")]
        public async Task<ActionResult<ResponseModel<AutorModel>>> ExcluirAutor(int idAutor)
        {
            var autor = await _autorInterface.ExcluirAutor(idAutor);
            return Ok(autor);
        }
    }
}
