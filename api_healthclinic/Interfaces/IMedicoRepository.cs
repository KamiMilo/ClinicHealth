using Api_healthclinic.Domains;

namespace Api_healthclinic.Interfaces
{
    public interface IMedicoRepository
    {
        /// <summary>
        ///  Método para Cadastrar um novo médico.
        /// </summary>
        /// <param name="Medico"></param>
        public void Cadastrar(Medico Medico);

        /// <summary>
        ///  Método para listar os Médicos.
        /// </summary>
        /// <returns></returns>
        public List<Medico> Listar();

        /// <summary>
        /// Método para atualizar propriedades de um médico.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="medico"></param>
        public void Atualizar(Guid id, Medico medico);

        /// <summary>
        ///  Método paa deletar um Médico, passando seu id pelo corpo da aquisição
        /// </summary>
        /// <param name="id"></param>
        public void Deletar(Guid id);

    }
}
