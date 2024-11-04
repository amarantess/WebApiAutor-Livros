using WebApiAutor_Livros.DTO.Vinculos;
using WebApiAutor_Livros.Models;

namespace WebApiAutor_Livros.DTO.Livro
{
    public class LivroCriacaoDto
    {
        public string Titulo { get; set; }
        public AutorVinculoDto Autor { get; set; }
    }
}
