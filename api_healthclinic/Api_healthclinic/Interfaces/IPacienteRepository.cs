using Api_healthclinic.Domains;

namespace Api_healthclinic.Interfaces
{
    public interface IPacienteRepository
    {
        public void Cadastrar(Paciente Paciente);

        public List<Paciente> Listar();

        public void Atualizar(Guid id);

        public void Deletar(Guid id);

    }
}
