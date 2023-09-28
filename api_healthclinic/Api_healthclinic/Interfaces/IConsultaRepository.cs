using Api_healthclinic.Domains;

namespace Api_healthclinic.Interfaces
{
    public interface IConsultaRepository
    {
        public void Cadastrar(Consulta novoConsulta);

        public List<Consulta> Listar();

        public List<Consulta> ListarMinhas(Guid id ,Consulta consulta);

        public void Atualizar(Guid id);

        public void Deletar(Guid id);

        public void BuscarPorId(Guid id);
    }
}
