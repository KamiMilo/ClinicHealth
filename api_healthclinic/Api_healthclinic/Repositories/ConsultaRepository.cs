using Api_healthclinic.Contexts;
using Api_healthclinic.Domains;
using Api_healthclinic.Interfaces;
using System.Collections.Generic;

namespace Api_healthclinic.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        private readonly HealthContext ctx;

        public ConsultaRepository()
        {
            ctx = new HealthContext();
        }
   
        public void Cadastrar(Consulta novoConsulta)
        {
            novoConsulta.IdConsulta = Guid.NewGuid();

            ctx.Consulta.Add(novoConsulta);

            ctx.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Consulta TipousuarioBuscado = ctx.Consulta.Find(id);

            ctx.Consulta.Remove(TipousuarioBuscado);

            ctx.SaveChanges();
        }

        public List<Consulta> Listar()
        {
            return ctx.Consulta.ToList();
        }


        public Consulta BuscarPorId(Guid id)
        {
            Consulta consulta = ctx.Consulta.Find(id);

            return consulta;
        }

        public List<Consulta> ListarPaciente(Guid id)
        {
            List<Consulta> consultasPorPaciente = new List<Consulta>();
            Consulta consultas = ctx.Consulta.Find(id);
                     
             consultasPorPaciente.Add(consultas);
            

            return consultasPorPaciente.ToList();
        }

        public List<Consulta> ListarMedico(Guid id)
        {
            List<Consulta> consultasPorMedico = new List<Consulta>();
            Consulta consultas = ctx.Consulta.Find(id);

            consultasPorMedico.Add(consultas);
            
            return consultasPorMedico.ToList();

        }

        public void Atualizar(Guid id, Consulta consulta)
        {
            Consulta consultaBuscada = ctx.Consulta.Find(id);

            if (consultaBuscada != null)
            {
                consultaBuscada.DataDaConsulta = consulta.DataDaConsulta;
                consultaBuscada.Descricao = consulta.Descricao;
                consultaBuscada.HoraConsulta=consulta.HoraConsulta;
            }

            ctx.Consulta.Update(consultaBuscada);
            ctx.SaveChanges();
        }
    }
}
