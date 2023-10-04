using Api_healthclinic.Contexts;
using Api_healthclinic.Domains;
using Api_healthclinic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api_healthclinic.Repositories
{
    public class ClinicaRepository : IClinicaRepository
    {
        private readonly HealthContext ctx;

        public ClinicaRepository()
        {
            ctx = new HealthContext();
        }

        public void Cadastrar(Clinica novoClinica)
        {
 
            novoClinica.IdClinica = Guid.NewGuid();
            ctx.Clinica.Add(novoClinica);

            ctx.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Clinica ClinicaBuscada = ctx.Clinica.Find(id);

            ctx.Clinica.Remove(ClinicaBuscada);

            ctx.SaveChanges();
        }

        public List<Clinica> Listar()
        {
            return ctx.Clinica.ToList();
        }
    }
}
