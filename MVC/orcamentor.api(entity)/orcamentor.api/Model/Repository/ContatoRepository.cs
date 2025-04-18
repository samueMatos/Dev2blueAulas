using Microsoft.EntityFrameworkCore;
using orcamentor.api.Controllers.Objects;
using orcamentor.api.Infra.Data;
using orcamentor.api.Model.Repository.Interfaces;

namespace orcamentor.api.Model.Repository
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly AppDbContext _appDbContext;

        public ContatoRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Contato>> Listar()
        {
            return await _appDbContext.Contatos.ToListAsync();
        }
        
        public async Task<Contato> Login( LoginRequest loginRequest)
        {
           var login= await _appDbContext.Contatos.FirstOrDefaultAsync(a=>a.Email == loginRequest.email);
        
           if (login==null)
           {
               throw new Exception("Usuário ou senha invalido!");
           }

           return login;
        }

        public async Task<Contato?> BuscarPorId(int id)
        {
            return await _appDbContext.Contatos.FindAsync();
        }

        public async Task<Contato> Salvar(Contato contato)
        {
            try
            {
                #region  ValidarDados

                if (contato.Numero.Length < 10 || contato.Numero.Length > 16)
                {
                    throw new Exception("Telefone invalido!");
                }
                

                #endregion
                
                
                
                
                if (contato.Id > 0)
                {
                    var contatoEditar = _appDbContext.Contatos.FirstOrDefault(a => a.Id == contato.Id);

                    if (contatoEditar == null)
                    {
                        throw new Exception("Contato não encontrado!");
                    }
                    
                    contatoEditar.Email = contato.Email;
                    contatoEditar.Nome = contato.Nome;
                    contatoEditar.Numero = contato.Numero;
                }
                else
                {
                    _appDbContext.Contatos.Add(contato);
                }
                
               
                await _appDbContext.SaveChangesAsync();

                return contato;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }

    public class CarroRepository : ICarroRepository
    {
        private readonly AppCarruxDbContext _appCarruxDbContext;

        public CarroRepository(AppCarruxDbContext appDbContext)
        {
            _appCarruxDbContext = appDbContext;
        }

        public List<Carro> Listar()
        {
            try
            {
                return _appCarruxDbContext.Carros.ToList();
            }
            catch (Exception e)
            {

                throw new Exception("Erro ao processar dados ");
            }
            
           
        }

        public async Task<Carro?> BuscarPorId(int id)
        {
            return await _appCarruxDbContext.Carros.FindAsync();
        }

        public async Task Salvar(Carro contato)
        {
            _appCarruxDbContext.Carros.Add(contato);
            await _appCarruxDbContext.SaveChangesAsync();
        }
    }
}
