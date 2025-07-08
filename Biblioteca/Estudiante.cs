using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estudiante : Persona
    {
        public string IdEstudiante { get; set; }         
        public Carrera Carrera { get; set; }             
        public Usuario Usuario { get; set; }             
        public Apoderado Apoderado { get; set; } 

        public Estudiante() { 
        
        }
        public Estudiante(
             string idEstudiante,
             string nombre,
             string apellidoPaterno,
             string apellidoMaterno,
             int edad,
             string dni,
             string telefono,
             Carrera carrera,
             Usuario usuario,
             Apoderado apoderado = null 
         ) : base(nombre, apellidoPaterno, apellidoMaterno, edad, dni, telefono)
            {
                IdEstudiante = idEstudiante;
                Carrera = carrera;
                Usuario = usuario;
                Apoderado = apoderado;
        }   
    }
}
