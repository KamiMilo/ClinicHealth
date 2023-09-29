using Api_healthclinic.Domains;

namespace Api_healthclinic.Interfaces
{
    public interface IMedicoRepository
    {
        public void Cadastrar(Medico Medico);

        public List<Medico> Listar();

        public void Atualizar(Guid id);

        public void Deletar(Guid id);

    }
}
