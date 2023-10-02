using Api_healthclinic.Domains;

namespace Api_healthclinic.Interfaces
{
    public interface IMedicoRepository
    {
        public void Cadastrar(Medico Medico);

        public List<Medico> Listar();

        public void Atualizar(Guid id, Medico medico);

        public void Deletar(Guid id);

    }
}
