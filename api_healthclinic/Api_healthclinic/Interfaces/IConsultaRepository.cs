using Api_healthclinic.Domains;

namespace Api_healthclinic.Interfaces
{
    public interface IConsultaRepository
    {
        public void Cadastrar(Consulta novoConsulta);

        public List<Consulta> Listar();

        public List<Consulta> ListarPaciente(Guid id);

        public List<Consulta> ListarMedico(Guid id);

        public void Atualizar(Guid id ,Consulta consulta);

        public void Deletar(Guid id);

        public Consulta BuscarPorId(Guid id);
    }
}
