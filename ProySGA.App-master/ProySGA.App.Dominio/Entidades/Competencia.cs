using System;
namespace ProySGA.App.Dominio.Entidades
{
    public class Competencia
    {
        public int id {get; set;}
        public string nombre {get; set;}
        public string descripcion {get; set;}
        public AsignaturaGrupo asignatura {get; set;}
    }
}