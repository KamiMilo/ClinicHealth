using Api_healthclinic.Domains;

namespace Api_healthclinic.Interfaces
{
    public interface IFeedbackRepository
    {
        public void Comentar(Feedback novoComentario);

        public List<Feedback> Listar();

        public void Atualizar(Guid id);

        public void Deletar(Guid id);

    }
}
