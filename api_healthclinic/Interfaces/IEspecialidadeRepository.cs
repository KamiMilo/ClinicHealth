using Api_healthclinic.Domains;

namespace Api_healthclinic.Interfaces
{
    public interface IEspecialidadeRepository
    {
        /// <summary>
        /// Método para cadastrar uma especialidade
        /// </summary>
        /// <param name="Especialidade"></param>
        public void Cadastrar(Especialidade Especialidade);

        /// <summary>
        /// Método para listar as especialidades.
        /// </summary>
        /// <returns>Lista de Especialidades</returns>
        public List<Especialidade> Listar();

        /// <summary>
        /// Método para atualizar especialidade.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="especialidade"></param>
        public void Atualizar(Guid id, Especialidade especialidade);

        /// <summary>
        /// Método para deletar especialidade passando seu id pelo corpo d aquisição.
        /// </summary>
        /// <param name="id"></param>
        public void Deletar(Guid id);
  
    }
}
