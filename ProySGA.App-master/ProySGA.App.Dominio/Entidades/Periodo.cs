using System;
namespace ProySGA.App.Dominio.Entidades
{
    public class Periodo
    {
        public int id {get; set;}
        public string nombre {get; set;}
        public string codigo {get; set;}
        public string descripcion {get; set;}
        public DateTime fecha_inicio {get; set;}
        public DateTime fecha_fin {get; set;}
    }
}