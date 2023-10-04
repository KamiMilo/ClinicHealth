using Api_healthclinic.Domains;

namespace Api_healthclinic.Interfaces
{
    public interface IProntuarioRepository
    {
        /// <summary>
        /// Método para Cadastrar um Prontúario.
        /// </summary>
        /// <param name="novoProntuario"></param>
        public void Cadastrar(Prontuario novoProntuario);

        /// <summary>
        /// Método para listar Prontúarios.
        /// </summary>
        /// <returns></returns>
        public List<Prontuario> Listar();

        /// <summary>
        /// Método para buscar paciente, passando seu id pelo corpo da aquisição.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Paciente</returns>
        public Prontuario BuscarporId(Guid id);

        /// <summary>
        /// Método paa deletar um paciente, passando seu id pelo corpo da aquisição.
        /// </summary>
        /// <param name="id"></param>
        public void Delete(Guid id);
    }
}
