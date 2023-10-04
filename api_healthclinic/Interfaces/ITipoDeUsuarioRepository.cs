using Api_healthclinic.Domains;
using System.Reflection;

namespace Api_healthclinic.Interfaces
{
    public interface ITipoDeUsuarioRepository
    {

        /// <summary>
        /// Método para Cadastrar um novo tipo de usuário.
        /// </summary>
        /// <param name="novoTipo"></param>
        public void Cadastrar(TipoUsuario novoTipo);

        /// <summary>
        /// Método para listar tipos de usuário
        /// </summary>
        /// <returns>Lista de tipos de usuário </returns>
        public List<TipoUsuario> Listar();

        /// <summary>
        ///  Método paa deletar um tipo de usuário, passando seu id pelo corpo da aquisição.
        /// </summary>
        /// <param name="id"></param>
        public void Deletar(Guid id);
        
    }
}
