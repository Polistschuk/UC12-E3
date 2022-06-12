using ChapterBE3.Models;
using Microsoft.EntityFrameworkCore;

namespace ChapterBE3.Contexts
{
    public class ChapterContext : DbContext
    {
        public  ChapterContext()
        {
        }
        public ChapterContext(DbContextOptions<ChapterContext> options) : base(options)
        {
        }
        //vamos utilizar esse método para configurar o banco de dados
        protected override void
        OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //cada provedor tem sua sintaxe para especificação
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-P894BOF\\SQLEXPRESS; initial catalog = Chapter; Integrated Security = true");
                //em vez de user id/pass, pode se usar caso de erro em /api/livro Integrated Security = true");, User Id = sa; Password = 1"
            }
        }
        // dbset representa as entidades que serão utilizadas nas operações de leitura, criação, atualização e deleção
        public DbSet<Livro> Livros { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
