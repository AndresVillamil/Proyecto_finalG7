using System;
namespace ProySGA.App.Dominio.Entidades
{
    public class Asignatura
    {
        public int id {get; set;}
        public string nombre {get; set;}
        public string descripcion {get; set;}
        public Area area {get; set;}
        public Grado grado {get; set;}
    }
}