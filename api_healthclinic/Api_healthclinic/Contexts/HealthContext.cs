using Api_healthclinic.Domains;
using Microsoft.EntityFrameworkCore;

namespace Api_healthclinic.Contexts
{
    public class HealthContext : DbContext
    {
        //definir Entidades do banco de dados

        public DbSet<TipoUsuario> TipoUsuario { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Administrador> Administrador { get; set; }

        public DbSet<Clinica> Clinica { get; set; }

        public DbSet<Consulta> Consulta { get; set; }

        public DbSet<Especialidade> Especialidade { get; set; }

        public DbSet<Feedback> Feedback { get; set; }

        public DbSet<Medico> Medico { get; set; }

        public DbSet<Paciente> Paciente { get; set; }

        public DbSet<Prontuario> Prontuario { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=  NOTE07-S14; Database = health_clinic_kamille; User Id =sa ;pwd= Senai@134 ; TrustServerCertificate=true;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
