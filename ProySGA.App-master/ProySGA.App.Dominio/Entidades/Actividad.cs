using System;
namespace ProySGA.App.Dominio.Entidades
{
    public class Actividad
    {
        public int id {get; set;}
        public string nombre {get; set;}
        public string descripcion {get; set;}
        public bool asitencia {get; set;}
        public DateTime fecha_inicio {get; set;}
        public DateTime fecha_fin {get; set;}
        public Competencia competencia {get; set;}
        public Periodo periodo {get; set;}
    }
}