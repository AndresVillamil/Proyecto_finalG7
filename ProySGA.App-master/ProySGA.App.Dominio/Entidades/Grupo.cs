using System;
namespace ProySGA.App.Dominio.Entidades
{
    public class Grupo
    {
        public int id {get; set;}
        public string nombre {get; set;}
        public string descripcion {get; set;}
        public Docente director {get; set;}
    }
}
