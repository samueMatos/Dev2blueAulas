using System.Text;
using Microsoft.AspNetCore.Mvc;
using orcamentor.api.Model;
using orcamentor.api.Model.Repository.Interfaces;

namespace orcamentor.api.Controllers
{

    [ApiController]
    public class ContatosController : ControllerBase
    {
        private readonly IContatoRepository _repository;
        private readonly ICarroRepository _repositoryCarros;

        public ContatosController(IContatoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("api/contatos")]
        public IActionResult GetContatos()
        {
            try
            {
                var carrinhos = _repository.Listar().Result;
                return Ok(carrinhos);

            }
            catch (Exception e)
            {
                return Unauthorized();
            }
        }
        
        [HttpPost("api/contatos")]
        public  IActionResult Salvar(Contato contato)
        {
            try
            {

            var lRusltoSalvarCOntato =  _repository.Salvar(contato).Result;
            return Ok(lRusltoSalvarCOntato);
            
            }
            catch (Exception error)
            {
                return ValidationProblem(new ValidationProblemDetails(){Detail = error.Message});
            }
        }
    }
}
