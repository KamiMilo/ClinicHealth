using Api_healthclinic.Domains;

namespace Api_healthclinic.Interfaces
{
    public interface IConsultaRepository
    {
        /// <summary>
        /// Método para Cadastrar uma consulta.
        /// </summary>
        /// <param name="novoConsulta"></param>
        public void Cadastrar(Consulta novoConsulta);

        /// <summary>
        /// Método para listar as consultas.
        /// </summary>
        /// <returns>Lista de Consultas</returns>
        public List<Consulta> Listar();

        /// <summary>
        /// método para listar consultas pelo paciente,passando seu id pelo corpo da aquisição.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Lista de Consultas</returns>
        public List<Consulta> ListarPaciente(Guid id);

        /// <summary>
        ///  método para listar consultas pelo Médico,passando seu id pelo corpo da aquisição.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Lista de Consultas</returns>
        public List<Consulta> ListarMedico(Guid id);

        /// <summary>
        /// Método para atualizar propriedades de uma consulta.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="consulta"></param>
        public void Atualizar(Guid id ,Consulta consulta);

        /// <summary>
        /// Método paa deletar uma consulta, passando seu id pelo corpo da aquisição.
        /// </summary>
        /// <param name="id"></param>
        public void Deletar(Guid id);

        /// <summary>
        /// Método para buscar uma consulta,,passando seu id pelo corpo da aquisição.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Consulta</returns>
        public Consulta BuscarPorId(Guid id);
    }
}
