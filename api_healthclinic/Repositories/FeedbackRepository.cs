using Api_healthclinic.Contexts;
using Api_healthclinic.Domains;
using Api_healthclinic.Interfaces;

namespace Api_healthclinic.Repositories
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly HealthContext ctx;

        public FeedbackRepository()
        {
            ctx = new HealthContext();
        }
        public void Atualizar(Guid id, Feedback comentario)
        {
            Feedback comentarioBuscado = ctx.Feedback.Find(id);

            if (comentarioBuscado != null)
            {
                comentarioBuscado.Comentario = comentario.Comentario;
            }

            ctx.Feedback.Update(comentarioBuscado);
            ctx.SaveChanges();
        }

        public void Comentar(Feedback novoComentario)
        {
            novoComentario.IdFeedback = Guid.NewGuid();

            ctx.Feedback.Add(novoComentario);

            ctx.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Feedback comentarioBuscado = ctx.Feedback.Find(id);

            ctx.Feedback.Remove(comentarioBuscado);

            ctx.SaveChanges();
        }

        public List<Feedback> Listar()
        {
            return ctx.Feedback.ToList();
        }
    }
}
