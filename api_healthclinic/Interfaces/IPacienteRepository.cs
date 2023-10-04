using Api_healthclinic.Domains;

namespace Api_healthclinic.Interfaces
{
    public interface IPacienteRepository
    {
        /// <summary>
        ///  Método para Cadastrar um novo paciente.
        /// </summary>
        /// <param name="Paciente"></param>
        public void Cadastrar(Paciente Paciente);

        /// <summary>
        /// Método para listar as consultas.
        /// </summary>
        /// <returns>Lista de Pacientes</returns>
        public List<Paciente> Listar();

        /// <summary>
        ///  Método para atualizar propriedades de um Paciente.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="paciente"></param>
        public void Atualizar(Guid id, Paciente paciente);

        /// <summary>
        ///  Método paa deletar um paciente, passando seu id pelo corpo da aquisição.
        /// </summary>
        /// <param name="id"></param>
        public void Deletar(Guid id);

    }
}
