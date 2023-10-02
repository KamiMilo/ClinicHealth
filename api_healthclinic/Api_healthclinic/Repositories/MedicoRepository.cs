using Api_healthclinic.Contexts;
using Api_healthclinic.Domains;
using Api_healthclinic.Interfaces;

namespace Api_healthclinic.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        private readonly HealthContext ctx;

        public MedicoRepository()
        {
            ctx = new HealthContext();
        }

        public void Atualizar(Guid id, Medico medico)
        {
             Medico medicoBuscado = ctx.Medico.Find(id);

            if (medicoBuscado != null)
            {
                medicoBuscado.Nome = medico.Nome;
                medicoBuscado.DatadeNascimento = medico.DatadeNascimento;
                medicoBuscado.Crm = medico.Crm;
            }

            ctx.Medico.Update(medicoBuscado);
            ctx.SaveChanges();
        }

        public void Cadastrar(Medico Medico)
        {
            Medico.IdMedico = Guid.NewGuid();

            ctx.Medico.Add(Medico);

            ctx.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Medico medicoBuscado = ctx.Medico.Find(id);

            ctx.Medico.Remove(medicoBuscado);

            ctx.SaveChanges();
        }

        public List<Medico> Listar()
        {
            return ctx.Medico .ToList();
        }
    }
}
