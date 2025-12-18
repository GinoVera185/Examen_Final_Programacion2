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
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txt_pais.ReadOnly = true;
            bt_Guardar.Enabled = false;
        }

        private void bt_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                short codigo = (short)nUD_CodigoPais.Value;
                string nombre = txt_pais.Text.Trim();

                if (codigo <= 0 || string.IsNullOrEmpty(nombre))
                {
                    MessageBox.Show("El código del Pais debe ser un número positivo y el nombre no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ArchivoBinario.GuardarPais(new Pais(codigo, nombre));

                MessageBox.Show("pais guardado Exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_pais.Clear();
                nUD_CodigoPais.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el pais: \n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_pais_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_pais.Text))
            {
                bt_Guardar.Enabled = false;
            }
            else
            {
                bt_Guardar.Enabled = true;
            }
        }

        private void nUD_CodigoPais_ValueChanged(object sender, EventArgs e)
        {
            if (nUD_CodigoPais.Value <= 0)
            {
                txt_pais.ReadOnly = true;
            }
            else
            {
                txt_pais.ReadOnly = false;
            }
        }
    }
}
