using Microsoft.EntityFrameworkCore;
using orcamentor.api.Model;

namespace orcamentor.api.Infra.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) {}

        public DbSet<Contato> Contatos { get; set; }
        
        //Exemplo de relacionamento 1 - 1
        public DbSet<Endereco> Endereco { get; set; }
        
        public DbSet<Produto> Produto { get; set; }
        
        //Exemplo de relacionamento 1 - N
        public DbSet<Categoria> Categoria { get; set; }
        
        
        //Exemplo de relacionamento n - n entre aluno e curso
        public DbSet<AlunoBlu> AlunosBlu { get; set; }
        public DbSet<Curso> Cursos { get; set; }
    }

    public class AppCarruxDbContext : DbContext
    {
        public AppCarruxDbContext(DbContextOptions<AppCarruxDbContext> options) : base(options) { }

        public DbSet<Carro> Carros { get; set; }
    }
}
