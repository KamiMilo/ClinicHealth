using Api_healthclinic.Domains;

namespace Api_healthclinic.Interfaces
{
    public interface IPacienteRepository
    {
        public void Cadastrar(Paciente Paciente);

        public List<Paciente> Listar();

        public void Atualizar(Guid id, Paciente paciente);

        public void Deletar(Guid id);

    }
}
