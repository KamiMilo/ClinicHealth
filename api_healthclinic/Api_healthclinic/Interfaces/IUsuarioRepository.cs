using Api_healthclinic.Domains;

namespace Api_healthclinic.Interfaces
{
    public interface IUsuarioRepository
    {
        public void Cadastrar(Usuario novoUsuario);

        public void BuscarPorEmail(String email,string senha);

        public void BuscaPorId(Guid id);

        public void Atualizar(Guid id);

    }
}
