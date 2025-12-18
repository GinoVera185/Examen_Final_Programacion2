using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_Final_Programacion2
{
    internal class Pais
    {
        public short Codigo { get; set; }
        public string Nombre { get; set; }

        public Pais(short codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;
        }

    }
}
