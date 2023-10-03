using Api_healthclinic.Contexts;
using Api_healthclinic.Domains;
using Api_healthclinic.Interfaces;

namespace Api_healthclinic.Repositories
{
    public class ProntuarioRepository : IProntuarioRepository
    {
        private readonly HealthContext ctx;

        public ProntuarioRepository()
        {
            ctx = new HealthContext();
        }


        public Prontuario BuscarporId(Guid id   )
        {
            return ctx.Prontuario.FirstOrDefault(u => u.IdProntuario == id);
           
        }

        public void Cadastrar(Prontuario novoProntuario)
        {
            novoProntuario.IdProntuario = Guid.NewGuid();

            ctx.Prontuario.Add(novoProntuario);

            ctx.SaveChanges();
        }

        public void Delete(Guid id)
        {
            Prontuario prontuarioBuscado = ctx.Prontuario.Find(id);

            ctx.Prontuario.Remove(prontuarioBuscado);

            ctx.SaveChanges();
        }

        public List<Prontuario> Listar()
        {
            return ctx.Prontuario.ToList();
        }
    }
}
