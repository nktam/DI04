using System;
using System.Collections.Generic;
using System.Text;

namespace UTILS
{
    public class ComercialVO
    {
        int id;
        string nombre, direccion, edad;

        public ComercialVO()
        {
        }

        public ComercialVO(int id, string nombre, string direccion, string edad)
        {
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
            this.edad = edad;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Edad { get => edad; set => edad = value; }
        
    }
}
