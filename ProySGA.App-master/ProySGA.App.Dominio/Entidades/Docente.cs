using System;
namespace ProySGA.App.Dominio.Entidades
{
    public class Docente : Persona
    {
        /*public int id {get; set;}
        public string nombres {set; get;}
        public string apellidos {set; get;}
        public string identificacion {set; get;}
        public string telefono {set; get;}
        public string mail {set; get;}
        public string direccion {set; get;}*/
        public string profesion {get; set;}
        public double salario {get; set;}
    }
}