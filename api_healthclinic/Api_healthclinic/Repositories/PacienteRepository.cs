using Api_healthclinic.Contexts;
using Api_healthclinic.Domains;
using Api_healthclinic.Interfaces;

namespace Api_healthclinic.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly HealthContext ctx;

        public PacienteRepository()
        {
            ctx = new HealthContext();
        }
        public void Atualizar(Guid id, Paciente paciente)
        {
            Paciente pacienteBuscado = ctx.Paciente.Find(id);

            if (pacienteBuscado != null)
            {
                pacienteBuscado.Nome = paciente.Nome;
                pacienteBuscado.Cpf = paciente.Cpf;
                pacienteBuscado.Telefone = paciente.Telefone;
                pacienteBuscado.DataDeNascimento = paciente.DataDeNascimento;
            }

            ctx.Paciente.Update(pacienteBuscado);
            ctx.SaveChanges();
        }

        public void Cadastrar(Paciente Paciente)
        {
            Paciente.IdPaciente = Guid.NewGuid();

            ctx.Paciente.Add(Paciente);

            ctx.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Paciente pacienteBuscado = ctx.Paciente.Find(id);

            ctx.Paciente.Remove(pacienteBuscado);

            ctx.SaveChanges();
        }

        public List<Paciente> Listar()
        {
            return ctx.Paciente.ToList();
        }
    }
}
