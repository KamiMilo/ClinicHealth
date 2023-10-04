using Api_healthclinic.Domains;

namespace Api_healthclinic.Interfaces
{
    public interface IFeedbackRepository
    {
        /// <summary>
        /// Método para cdastrar um comentário.
        /// </summary>
        /// <param name="novoComentario"></param>
        public void Comentar(Feedback novoComentario);

        /// <summary>
        /// Método para listar comentários.
        /// </summary>
        /// <returns>lista de comentários</returns>
        public List<Feedback> Listar();

        /// <summary>
        /// Método para atualizar comentário.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="comentario"></param>
        public void Atualizar(Guid id, Feedback comentario);

        /// <summary>
        /// Método para deletar comentário, passando seu id pelo corpo da aquisição.
        /// </summary>
        /// <param name="id"></param>
        public void Deletar(Guid id);

    }
}
