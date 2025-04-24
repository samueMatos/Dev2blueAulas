using System.ComponentModel.DataAnnotations;

namespace orcamentor.api.Model;

public class Curso
{
    [Key]
    public int Id { get; set; }

    public string Nome { get; set; }
    
    public List<AlunoBlu> AlunosBlu { get; set; }
}


public class AlunoBlu
{
    [Key]
    public int Id { get; set; }

    public string Nome { get; set; }
    
    public List<Curso> Cursos { get; set; }
 }