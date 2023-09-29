using Api_healthclinic.Contexts;
using Api_healthclinic.Domains;
using Api_healthclinic.Interfaces;
using Api_healthclinic.Utils;

namespace Api_healthclinic.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly HealthContext ctx;

        public UsuarioRepository()
        {
            ctx = new HealthContext();
        }

        public void Atualizar(Guid id)
        {
            Usuario usuarioBuscado = ctx.Usuario.Find(id);

            ctx.Usuario.Update(usuarioBuscado);

            ctx.SaveChanges();
        }

        public void BuscaPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Usuario BuscarPorEmail(string email, string senha)
        {
            try
            {
                Usuario usuarioBuscado = ctx.Usuario
                    .Select(u => new Usuario
                    {
                        IdUsuario = u.IdUsuario,
                        Nome = u.Nome,
                        Email = u.Email,
                        Senha = u.Senha,
             
                    }).FirstOrDefault(u => u.Email == email)!;

                if (usuarioBuscado != null)
                {
                    bool confere = Criptografia.CompararHash(senha, usuarioBuscado.Senha!);

                    if (confere)
                    {
                        return usuarioBuscado;
                    }
                }
                return null!;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void Cadastrar(Usuario novoUsuario)
        {
            try
            {
                novoUsuario.Senha = ctx.Criptografia.GerarHash(novoUsuario.senha!);
                ctx.Usuario.Add(novoUsuario);
                ctx.SaveChanges();
            }

            catch (Exception) 
            {
                throw;
            }
        }

        void IUsuarioRepository.BuscarPorEmail(string email, string senha)
        {
            throw new NotImplementedException();
        }
    }
}

