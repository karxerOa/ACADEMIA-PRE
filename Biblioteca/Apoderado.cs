﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Apoderado
    {
        public string Id_apoderado { get; set; }
        public string nombre_apoderado { get; set; }
        public string telefono_apoderado { get; set; }

        public Apoderado(){
                               
        }
        public Apoderado(string id_apoderado, string nombre_apoderado, string telefono_apoderado)
        {
            this.Id_apoderado = id_apoderado;
            this.nombre_apoderado = nombre_apoderado;
            this.telefono_apoderado = telefono_apoderado;
        }
    }
}
