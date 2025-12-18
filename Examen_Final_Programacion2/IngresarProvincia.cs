using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen_Final_Programacion2
{
    public partial class IngresarProvincia : Form
    {
        public IngresarProvincia()
        {
            InitializeComponent();
        }

        private void IngresarProvincia_Load(object sender, EventArgs e)
        {
            List<Pais> listaPais = ArchivoBinario.LeerPaises();
            cmb_pais.DataSource = listaPais;
            cmb_pais.DisplayMember = "Nombre";
            cmb_pais.ValueMember = "Codigo";

            nUD_CodigoProv.ReadOnly = true;
            txt_Provincia.ReadOnly = true;
            bt_Guardar.Enabled = false;
        }

        private void bt_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                short codigo = (short)nUD_CodigoProv.Value;
                string nombre = txt_Provincia.Text.Trim();
                short paisCodigo = (short)cmb_pais.SelectedIndex;

                if (codigo <= 0 || string.IsNullOrEmpty(nombre))
                {
                    MessageBox.Show("El código de la provincia debe ser un número positivo y el nombre no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ArchivoBinario.GuardarProvincia(new Provincia(codigo, nombre, paisCodigo));

                MessageBox.Show("Provincia guardada exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_Provincia.Clear();
                nUD_CodigoProv.Value = 0;
                cmb_pais.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la Provincia: \n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_pais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( cmb_pais.SelectedIndex == -1)
            {
                nUD_CodigoProv.ReadOnly = true;
            }
            else
            {
                nUD_CodigoProv.ReadOnly = false;
            }
        }

        private void nUD_CodigoProv_ValueChanged(object sender, EventArgs e)
        {
            if (nUD_CodigoProv.Value <= 0)
            {
                txt_Provincia.ReadOnly = true;
            }
            else
            {
                txt_Provincia.ReadOnly = false;
            }
        }

        private void txt_Provincia_TextChanged(object sender, EventArgs e)
        {
            if (nUD_CodigoProv.Value <= 0 || cmb_pais.SelectedIndex == -1)
            {
                bt_Guardar.Enabled = false;
            }
            else
            {
                bt_Guardar.Enabled = true;
            }
        }

        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
