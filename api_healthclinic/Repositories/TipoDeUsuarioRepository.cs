using Api_healthclinic.Contexts;
using Api_healthclinic.Domains;
using Api_healthclinic.Interfaces;

namespace Api_healthclinic.Repositories
{
    public class TipoDeUsuarioRepository : ITipoDeUsuarioRepository
    {
        private readonly HealthContext ctx;

        public TipoDeUsuarioRepository() 
        { 
            ctx = new HealthContext();
        }
        public void Cadastrar(TipoUsuario novoTipo)
        {
            novoTipo.IdTipoUsuario = Guid.NewGuid();

            ctx.TipoUsuario.Add(novoTipo);

            ctx.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            TipoUsuario TipousuarioBuscado = ctx.TipoUsuario.Find(id);

            ctx.TipoUsuario.Remove(TipousuarioBuscado);

            ctx.SaveChanges();

        }

        public List<TipoUsuario> Listar()
        {
            return ctx.TipoUsuario.ToList();
        }
    }
}
