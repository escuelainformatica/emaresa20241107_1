using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto20241107.modelos
{
    public class Envio
    {
        public int Alto { get; set; }
        public int Ancho { get; set; }
        public int Largo { get; set; }
        public int Peso { get; set; }
        public string Direccion { get; set; }

        public Envio(int alto, int ancho, int largo, int peso, string direccion)
        {
            Alto = alto;
            Ancho = ancho;
            Largo = largo;
            Peso = peso;
            Direccion = direccion;
        }

        public Envio()
        {
        }

    }
}
