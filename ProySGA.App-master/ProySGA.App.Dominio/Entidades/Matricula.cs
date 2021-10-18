using System;
namespace ProySGA.App.Dominio.Entidades
{
    public class Matricula
    {
        public int id {get; set;}
        public DateTime fecha {get; set;}
        public string creador {get; set;}
        public Estudiante estudiante {get; set;}
        public Grupo grupo {get; set;}
        public Grado grado {get; set;}
    }
    
}