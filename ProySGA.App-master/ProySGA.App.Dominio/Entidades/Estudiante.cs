using System;
using System.ComponentModel.DataAnnotations;

namespace ProySGA.App.Dominio.Entidades
{
    public class Estudiante : Persona
    {
    
        
        /*public int id { get; set; }
        public string nombres { set; get; }
        public string apellidos { set; get; }
        public string identificacion { set; get; }
        public string telefono { set; get; }
        public string mail { set; get; }
        public string direccion { set; get; }*/
        public string nacimiento { get; set; }
        public Persona padre { get; set; }
        public Persona madre { get; set; }
    }



}