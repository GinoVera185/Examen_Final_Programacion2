using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_Final_Programacion2
{
    internal class Archivo
    {
        
        public List<Registro> registros = new List<Registro>();

        

        public void AgregarRegistro(Registro registro)
        {
            registros.Add(registro);
        }

        
    }
}
