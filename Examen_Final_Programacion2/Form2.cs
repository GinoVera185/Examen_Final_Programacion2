using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen_Final_Programacion2
{
    public partial class Form2 : Form
    {
        public short codigo;
        public string Nombre;
        public string ArchivoPais = "Pais.dat";

        public Form2()
        {
            InitializeComponent();

        }

        public void GuardarArchivo()
        {
            using (FileStream fs = new FileStream(ArchivoPais, FileMode.OpenOrCreate))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                writer.Write(codigo);
                writer.Write(Nombre);
            }
        }

        private void bt_Guardar_Click(object sender, EventArgs e)
        {


        }

        private void bt_Agregar_Click(object sender, EventArgs e)
        {

        }
    }
}
