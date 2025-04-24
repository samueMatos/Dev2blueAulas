using System.ComponentModel.DataAnnotations;

namespace orcamentor.api.Model
{
    public class Contato
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Numero { get; set; }
        
        [Required]
        public string Senha { get; set; }
        
        public Endereco Endereco { get; set; }
    }

    public class Endereco
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Rua { get; set; }

        [Required]
        public string Estado { get; set; }
        
        [Required]
        public string Cidade { get; set; }
        
        public int  ContatoId { get; set; }
        
        public Contato Contato { get; set; }
        
    }
    
    
    
    
    
    

    public class Carro
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public int Ano { get; set; }

        [Required]
        public string Placa { get; set; }

        [Required]
        public long Marca { get; set; }
    }
}
