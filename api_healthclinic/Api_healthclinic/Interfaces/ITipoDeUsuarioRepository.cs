using Api_healthclinic.Domains;
using System.Reflection;

namespace Api_healthclinic.Interfaces
{
    public interface ITipoDeUsuarioRepository
    {

        public void Cadastrar(TipoUsuario novoTipo);

        public List<TipoUsuario> Listar();

        public void Deletar(Guid id);
        
    }
}
