using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Persona
    {
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private int edad;
        private string dni;
        private string telefono;
        public string Nombre
        {
            get => nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede estar vacío.");
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El nombre no puede contener números.");
                nombre = value;
            }
        }
        public string ApellidoPaterno
        {
            get => apellidoPaterno;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El apellido paterno no puede estar vacío.");
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El apellido paterno no puede contener números.");
                apellidoPaterno = value;
            }
        }
        public string ApellidoMaterno
        {
            get => apellidoMaterno;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El apellido materno no puede estar vacío.");
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("El apellido materno no puede contener números.");
                apellidoMaterno = value;
            }
        }

        public int Edad
        {
            get => edad;
            set
            {
                if (value < 14 || value > 50)
                    throw new ArgumentException("La edad debe estar entre 14 y 50.");
                edad = value;
            }
        }
        public string DNI
        {
            get => dni;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length != 8 || !value.All(char.IsDigit))
                    throw new ArgumentException("El DNI debe tener exactamente 8 dígitos numéricos.");
                dni = value;
            }
        }
        public string Telefono
        {
            get => telefono;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length != 9 || !value.All(char.IsDigit))
                    throw new ArgumentException("El teléfono debe tener 9 dígitos numéricos.");
                telefono = value;
            }
        }
        // Constructor base
        public Persona() { }

        public Persona(string nombre, string apPat, string apMat, int edad, string dni, string telefono)
        {
            Nombre = nombre;
            ApellidoPaterno = apPat;
            ApellidoMaterno = apMat;
            Edad = edad;
            DNI = dni;
            Telefono = telefono;
        }
        public virtual string ObtenerInformacion()
        {
            return $"{Nombre} {ApellidoPaterno} {ApellidoMaterno}, Edad: {Edad}, DNI: {DNI}, Teléfono: {Telefono}";
        }
    }
}
