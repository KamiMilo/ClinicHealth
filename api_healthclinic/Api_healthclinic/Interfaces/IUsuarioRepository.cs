using Api_healthclinic.Domains;

namespace Api_healthclinic.Interfaces
{
    public interface IUsuarioRepository
    {
        public void Cadastrar(Usuario novoUsuario);

        public void BuscarUsuario(Guid Id);

        public void Atualizar(Guid id);

    }
}
