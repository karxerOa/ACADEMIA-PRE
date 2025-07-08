using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Carrera
    {
        public int Id_carrera { get; set; }
        public string Nombre_carrera { get; set; }
        public string Id_area { get; set; }
        public Area Area { get; set; }
        public Carrera() { 
        
        }
    }
}
