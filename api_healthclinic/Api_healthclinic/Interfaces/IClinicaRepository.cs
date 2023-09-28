using Api_healthclinic.Domains;

namespace Api_healthclinic.Interfaces
{
    public interface IClinicaRepository
    {
        public void Cadastrar(Clinica novoClinica);

        public List<Clinica> Listar();

        public void Deletar(Guid id);
    }
}
