using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_Final_Programacion2
{
    internal class Provincia
    {
        public short Codigo { get; set; }
        public string Nombre { get; set; }
        public short Pais { get; set; }
        public Provincia(short codigo, string nombre, short pais)
        {
            Codigo = codigo;
            Nombre = nombre;
            Pais = pais;
        }
    }
}
