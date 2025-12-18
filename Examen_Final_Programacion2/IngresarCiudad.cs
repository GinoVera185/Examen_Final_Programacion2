using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen_Final_Programacion2
{
    public partial class IngresarCiudad : Form
    {
        private List<Pais> listaPais;
        private List<Provincia> listaProv;
        public IngresarCiudad()
        {
            InitializeComponent();
        }

        private void IngresarCiudad_Load(object sender, EventArgs e)
        {
            listaPais = ArchivoBinario.LeerPaises();
            listaProv = ArchivoBinario.LeerProvincia();

            cmb_pais.DataSource = listaPais;
            cmb_pais.DisplayMember = "Nombre";
            cmb_pais.ValueMember = "Codigo";

            cmb_provincia.Enabled = false;
            nUD_CodigoCiudad.ReadOnly = true;
            txt_Ciudad.ReadOnly = true;
            nUD_Habitantes.ReadOnly = true;
            bt_Guardar.Enabled = false;
        }

        private void cmb_pais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_pais.SelectedIndex == -1)
            {
                cmb_provincia.DataSource = null;
                cmb_provincia.Enabled = false;
                return;
            }
            else
            {
                cmb_provincia.Enabled = true;
            }

            short CodPais = (short)cmb_pais.SelectedIndex;
            var provinciaPais = listaProv.Where(p => p.Pais == CodPais).ToList();

            if (provinciaPais.Count > 0)
            {
                cmb_provincia.DataSource = provinciaPais;
                cmb_provincia.DisplayMember = "Nombre";
                cmb_provincia.ValueMember = "Codigo";
            }
            else
            {
                cmb_provincia.DataSource = null;
                cmb_provincia.Enabled = false;
            }

        }

        private void cmb_provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_pais.SelectedIndex == -1 || cmb_provincia.SelectedIndex == -1)
            {
                nUD_CodigoCiudad.ReadOnly = true;
            }
            else
            {
                nUD_CodigoCiudad.ReadOnly = false;
            }
        }

        private void nUD_CodigoCiudad_ValueChanged(object sender, EventArgs e)
        {
            if (nUD_CodigoCiudad.Value <= 0 || cmb_provincia.SelectedIndex == -1)
            {
                txt_Ciudad.ReadOnly = true;
            }
            else
            {
                txt_Ciudad.ReadOnly = false;
            }
        }

        private void txt_Ciudad_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Ciudad.Text.Trim()))
            {
                nUD_Habitantes.ReadOnly = true;
            }
            else
            {
                nUD_Habitantes.ReadOnly = false;
            }
        }


        private void bt_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                short codigo = (short)nUD_CodigoCiudad.Value;
                string nombre = txt_Ciudad.Text.Trim();
                short provinciaCodigo = (short)cmb_provincia.SelectedIndex;
                short paisCodigo = (short)cmb_pais.SelectedIndex;
                int habitantes = (int)nUD_Habitantes.Value;

                if (codigo <= 0 || string.IsNullOrEmpty(nombre) || habitantes < 0)
                {
                    MessageBox.Show("Por favor, complete todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ArchivoBinario.GuardarCiudad(new Ciudad(codigo, nombre, provinciaCodigo, paisCodigo, habitantes));

                MessageBox.Show("Ciudad guardada exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_Ciudad.Clear();
                nUD_CodigoCiudad.Value = 0;
                nUD_Habitantes.Value = 0;
                cmb_pais.SelectedIndex = -1;
                cmb_provincia.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la ciudad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nUD_Habitantes_ValueChanged(object sender, EventArgs e)
        {
            if (nUD_Habitantes.Value <= 0)
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
