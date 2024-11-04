using AutoMapper;
using WebApiAutor_Livros.DTO.Autor;
using WebApiAutor_Livros.Models;

namespace WebApiAutor_Livros.Services.AutoMapper.Autor
{
    public class AutoMappingForCreation : Profile
    {
        public AutoMappingForCreation()
        {
            DtoToModel();
        }

        public void DtoToModel()
        {
            CreateMap<AutorCriacaoDto, AutorModel>();
        }
    }
}
