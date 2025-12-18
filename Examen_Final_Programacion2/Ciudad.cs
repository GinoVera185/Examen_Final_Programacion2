using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_Final_Programacion2
{
    internal class Ciudad
    {
        public short Codigo { get; set; }
        public string Nombre { get; set; }
        public short Provincia { get; set; }
        public short Pais { get; set; }
        public long NumeroHabitantes { get; set; }
        public Ciudad(short codigo, string nombre, short provincia, short pais, long habitantes)
        {
            Codigo = codigo;
            Nombre = nombre;
            Provincia = provincia;
            Pais = pais;
            NumeroHabitantes = habitantes;
        }
    }
}
