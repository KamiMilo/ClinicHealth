using Api_healthclinic.Domains;

namespace Api_healthclinic.Interfaces
{
    public interface IClinicaRepository
    {
        /// <summary>
        /// Método para Cadastrar uma nova clínica.
        /// </summary>
        /// <param name="novoClinica"></param>
        /// 
        public void Cadastrar(Clinica novoClinica);

        /// <summary>
        /// Método para Listar.
        /// </summary>
        /// <returns></returns>
        public List<Clinica> Listar();


        /// <summary>
        /// método para Deletar, passando o id pelo corpo da aquisição.
        /// </summary>
        /// <param name="id"></param>
        public void Deletar(Guid id);
    }
}
