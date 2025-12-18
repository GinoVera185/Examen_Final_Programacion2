using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen_Final_Programacion2
{
    public partial class MenuIngreso : Form
    {
        public MenuIngreso()
        {
            InitializeComponent();
        }

        private void bt_IngresarPais_Click(object sender, EventArgs e)
        {
            Form2 InPais = new Form2();
            InPais.ShowDialog();
        }

        private void bt_IngresarProvincia_Click(object sender, EventArgs e)
        {
            IngresarProvincia InProv = new IngresarProvincia();
            InProv.ShowDialog();
        }

        private void bt_IngresarCiudad_Click(object sender, EventArgs e)
        {
            IngresarCiudad InCiudad = new IngresarCiudad();
            InCiudad.ShowDialog();
        }

        private void bt_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
