using Api_healthclinic.Domains;

namespace Api_healthclinic.Interfaces
{
    public interface IProntuarioRepository
    {
        public void Cadastrar(Prontuario novoProntuario);

        public List<Prontuario> ListarMeus(Guid id);

        public void BuscarporId(int id);

        public void Delete(Guid id);
    }
}
