using System;
using System.Collections.Generic;
using System.Text;

namespace UTILS
{
    public class DatosVO
    {
        private int valor;
        private string pie;

        public DatosVO(int valor, string pie)
        {
            this.valor = valor;
            this.pie = pie;
        }

        public int Valor { get => valor; set => valor = value; }
        public string Nombre { get => pie; set => pie = value; }
    }

}
