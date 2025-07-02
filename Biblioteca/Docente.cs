using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Docente: Persona
    {
        public string Especialidad { get; set; }
        public Usuario Usuario { get; set; }

        public Docente() { }

        public Docente(
            string nombre, string apPat, string apMat, int edad, string dni, string telefono,
            string especialidad, Usuario usuario)
            : base(nombre, apPat, apMat, edad, dni, telefono)
        {
            Especialidad = especialidad;
            Usuario = usuario;
        }

        public override string ObtenerInformacion()
        {
            return base.ObtenerInformacion() +
                   $" - Especialidad: {Especialidad} - Usuario: {Usuario.User} - Rol: {Usuario.Rol}";
        }
    }
}

