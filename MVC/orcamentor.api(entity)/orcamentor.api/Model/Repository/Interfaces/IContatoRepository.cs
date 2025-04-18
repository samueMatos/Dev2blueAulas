using orcamentor.api.Controllers.Objects;

namespace orcamentor.api.Model.Repository.Interfaces
{
    public interface IContatoRepository
    {
        Task<List<Contato>> Listar();
        Task<Contato> BuscarPorId(int id);
        Task<Contato> Login(LoginRequest loginRequest);
        Task<Contato> Salvar(Contato contato);
    }

    public interface ICarroRepository
    {
        List<Carro> Listar();
        Task<Carro> BuscarPorId(int id);

        Task Salvar(Carro contato);
    }
}
