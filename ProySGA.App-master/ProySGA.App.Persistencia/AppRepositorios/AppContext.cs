using Microsoft.EntityFrameworkCore;
using ProySGA.App.Dominio.Entidades;

namespace ProySGA.App.Persistencia.AppRepositorios
{
    public class AppContext  : DbContext
    {
        public DbSet<Persona> Personas{get;set;}
        public DbSet<Actividad> Actividades{get;set;}
        public DbSet<Acudiente> Acudientes{get;set;}
        public DbSet<Asignatura> Asignaturas{get;set;}
        public DbSet<AsignaturaGrupo> AsignaturasGrupo{get;set;}
        public DbSet<Competencia> Competencias{get;set;}
        public DbSet<Docente> Docentes{get;set;}
        public DbSet<Estudiante> Estudiantes{get;set;}
        public DbSet<Grado> Grados{get;set;}
        public DbSet<Grupo> Grupos{get;set;}
        public DbSet<Matricula> Matriculas{get;set;}
        public DbSet<Periodo> Periodos{get;set;}
        //Configurar conexión base de datos
        //Configurar conexión base de datos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
     optionsBuilder
     .UseSqlServer("Data Source =(localdb)\\MSSQLLocalDB; Initial Catalog= ProyAppData");
        }
    }       
    }
}
