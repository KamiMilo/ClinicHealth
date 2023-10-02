using Api_healthclinic.Domains;

namespace Api_healthclinic.Interfaces
{
    public interface IEspecialidadeRepository
    {
        public void Cadastrar(Especialidade Especialidade);

        public List<Especialidade> Listar();

        public void Atualizar(Guid id, Especialidade especialidade);

        public void Deletar(Guid id);
  
    }
}
