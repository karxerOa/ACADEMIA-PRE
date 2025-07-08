using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Area
    {
        public string Id_area { get; set; }
        public string Tipo_area { get; set; }
        public string Denominacion { get; set; }
        public Area()
        {

        }
        public Area(string id_area, string tipo_area, string denominacion)
        {
            Id_area = id_area;
            Tipo_area = tipo_area;
            Denominacion = denominacion;
        }
    }
}
