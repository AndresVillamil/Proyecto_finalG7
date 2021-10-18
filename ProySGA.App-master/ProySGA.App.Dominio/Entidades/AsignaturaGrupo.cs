using System;
namespace ProySGA.App.Dominio.Entidades
{
    public class AsignaturaGrupo
    {
        public int id {get; set;}
        public string descripcion {get; set;}
        public Asignatura asignatura {get; set;}
        public Docente docente {get; set;}
        public Grupo grupo {get; set;}
    }
}