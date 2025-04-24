using System.ComponentModel.DataAnnotations;

namespace orcamentor.api.Model;

public class Produto
{
    [Key]
    public int Id { get; set; }

    public string Nome { get; set; }

    public decimal Preco { get; set; }
    
    public int CategoriaId { get; set; }

    public Categoria Categoria { get; set; }
    
}

public class Categoria
{
    [Key]
    public int Id { get; set; }

    public string Nome { get; set; }


    public List<Produto> Produtos { get; set; }
}