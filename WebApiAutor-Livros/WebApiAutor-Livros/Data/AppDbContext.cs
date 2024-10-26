using Microsoft.EntityFrameworkCore;
using WebApiAutor_Livros.Models;

namespace WebApiAutor_Livros.Data
{
    // É a classe responsável por entrar em contato com o banco de dados
    public class AppDbContext : DbContext
    {
        // O construtor recebe algumas informações e opções para fazer a conexão
        // O construtor recebe como parâmetro as informações do banco(qual o banco, string de conexão) e repassa o DbContext Base
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Vamos dizer quais modelos vão ser usados para a criação das tabelas, a classe entre <> vai dizer qual a forma que a tabela será criada
        // Irá criar a tabela "Autores" usando como base as propriedades da classe "AutorModel"
        public DbSet<AutorModel> Autores { get; set; }
        public DbSet<LivroModel> Livros { get; set; }

    }
}
