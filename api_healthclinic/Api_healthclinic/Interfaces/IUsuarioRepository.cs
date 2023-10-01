using Api_healthclinic.Domains;

namespace Api_healthclinic.Interfaces
{
    public interface IUsuarioRepository
    {
        public void Cadastrar(Usuario novoUsuario);

        public List<Usuario> Listar();

        public Usuario BuscarPorEmail(string email,string senha);

        public Usuario BuscaPorId(Guid id);

        public void Deletar(Guid id);



    }
}
