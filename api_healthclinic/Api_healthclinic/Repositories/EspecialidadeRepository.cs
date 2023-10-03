using Api_healthclinic.Contexts;
using Api_healthclinic.Domains;
using Api_healthclinic.Interfaces;

namespace Api_healthclinic.Repositories
{
    public class EspecialidadeRepository : IEspecialidadeRepository
    {
        private readonly HealthContext ctx;

        public EspecialidadeRepository()
        {
            ctx = new HealthContext();
        }

        public void Atualizar(Guid id, Especialidade especialidade)
        {
            Especialidade especialidadeBuscada = ctx.Especialidade.Find(id);

            if (especialidadeBuscada != null)
            {
                especialidadeBuscada.EspecialidadeNome = especialidade.EspecialidadeNome;

            }
                ctx.Especialidade.Update(especialidadeBuscada);
                ctx.SaveChanges();
        }

        public void Cadastrar(Especialidade Especialidade)
        {
            Especialidade.IdEspecialidade = Guid.NewGuid();
            ctx.Especialidade.Add(Especialidade);
            ctx.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Especialidade especialidade = ctx.Especialidade.Find(id);

            ctx.Especialidade.Remove(especialidade);

            ctx.SaveChanges();
        }

        public List<Especialidade> Listar()
        {
           return ctx.Especialidade.ToList();
        }
    }
}
