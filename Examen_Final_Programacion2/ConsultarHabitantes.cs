using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen_Final_Programacion2
{
    public partial class ConsultarHabitantes : Form
    {
        private List<Pais> listaPais;
        private List<Provincia> listaProv;
        private List<Ciudad> listaCiudad;

        public ConsultarHabitantes()
        {
            InitializeComponent();
        }
        private void ConsultarHabitantes_Load(object sender, EventArgs e)
        {
            listaPais = ArchivoBinario.LeerPaises();
            listaProv = ArchivoBinario.LeerProvincia();
            listaCiudad = ArchivoBinario.LeerCiudad();

            cmb_pais.DataSource = listaPais;
            cmb_pais.DisplayMember = "Nombre";
            cmb_pais.ValueMember = "Codigo";

            cmb_pais.SelectedIndex = -1;
            cmb_provincia.SelectedIndex = -1;
            cmb_ciudad.SelectedIndex = -1;

            cmb_provincia.Enabled = false;
            cmb_ciudad.Enabled = false;
            txt_HabitantesPais.Text = "";
            txt_HabitantesProv.Text = "";
            txt_HabitantesCiu.Text = "";
        }

        private void CalcularHabitantes()
        {
            //Pais
            short CodPais = (short)cmb_pais.SelectedIndex;
            var CiudadPais = listaCiudad.Where(c => c.Pais == CodPais).ToList();
            int TotalPais = CiudadPais.Sum(c => (int)c.NumeroHabitantes);
            txt_HabitantesPais.Text = $"{TotalPais}";

            //Provincia
            if (cmb_provincia.SelectedIndex >= 0)
            {
                short CodProvincia = (short)cmb_provincia.SelectedIndex;
                var CiudadProv = listaCiudad.Where(c => c.Provincia == CodProvincia).ToList();
                int TotalProvincia = CiudadProv.Sum(c => (int)c.NumeroHabitantes);
                txt_HabitantesProv.Text = $"{TotalProvincia}";

                //ciudad
                if (cmb_ciudad.SelectedIndex >= 0)
                {
                    var ciudad = cmb_ciudad.SelectedItem as Ciudad;
                    txt_HabitantesCiu.Text = $"{ciudad.NumeroHabitantes}";
                }
            }
        }
        private void cmb_pais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_pais.SelectedIndex == -1) return;

            short paisSelecionado = (short)cmb_pais.SelectedIndex;
            var provinciasPais = listaProv.Where(p => p.Pais == paisSelecionado).ToList();

            if (provinciasPais.Count > 0)
            {
                cmb_provincia.DataSource = provinciasPais;
                cmb_provincia.DisplayMember = "Nombre";
                cmb_provincia.ValueMember = "Codigo";
                cmb_provincia.Enabled = true;
            }
            else
            {
                cmb_provincia.DataSource = null;
                cmb_provincia.Enabled = false;
                MessageBox.Show("No hay provincias para el país seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            cmb_ciudad.DataSource = null;
            cmb_ciudad.Enabled = false;
            txt_HabitantesPais.Text = "";

            CalcularHabitantes();
        }

        private void cmb_provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_provincia.SelectedIndex == -1) return;

            short paisSeleccionado = (short)cmb_pais.SelectedIndex;
            short provinciaSeleccionada = (short)cmb_provincia.SelectedIndex;

            var ciudadesProvincia = listaCiudad.Where(c => c.Pais == paisSeleccionado && c.Provincia == provinciaSeleccionada).ToList();

            if (ciudadesProvincia.Count > 0)
            {
                cmb_ciudad.DataSource = ciudadesProvincia;
                cmb_ciudad.DisplayMember = "Nombre";
                cmb_ciudad.ValueMember = "Codigo";
                cmb_ciudad.Enabled = true;

            }
            else
            {
                cmb_ciudad.DataSource = null;
                cmb_ciudad.Enabled = false;
                MessageBox.Show("No hay ciudades para la provincia seleccionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            CalcularHabitantes();
        }

        private void cmb_ciudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularHabitantes();
        }

        private void bt_Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
