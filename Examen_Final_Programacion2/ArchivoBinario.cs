using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_Final_Programacion2
{
    internal class ArchivoBinario
    {
        public static void GuardarPais(Pais pais)
        {
            using var file = File.Open("Pais.dat", FileMode.Append);
            using var writer = new BinaryWriter(file);
            writer.Write(pais.Codigo);
            writer.Write(pais.Nombre);
        }

        public static void GuardarProvincia(Provincia prov)
        {
            using var file = File.Open("Provincia.dat", FileMode.Append);
            using var writer = new BinaryWriter(file);
            writer.Write(prov.Pais);
            writer.Write(prov.Codigo);
            writer.Write(prov.Nombre);
        }

        public static void GuardarCiudad(Ciudad ciudad)
        {
            using var file = File.Open("Ciudad.dat", FileMode.Append);
            using var writer = new BinaryWriter(file);
            writer.Write(ciudad.Pais);
            writer.Write(ciudad.Provincia);
            writer.Write(ciudad.Codigo);
            writer.Write(ciudad.Nombre);
            writer.Write(ciudad.NumeroHabitantes);
        }
        public static List<Pais> LeerPaises()
        {
            var listaPais = new List<Pais>();

            if (!File.Exists("Pais.dat")) return listaPais;

            try
            {
                using (var reader = new BinaryReader(File.Open("Pais.dat", FileMode.Open)))
                {
                    while (reader.BaseStream.Position < reader.BaseStream.Length)
                    {
                        short codigo = reader.ReadInt16();
                        string nombre = reader.ReadString();
                        listaPais.Add(new Pais(codigo, nombre));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer paises: \n{ex.Message}", "Error de lectura");
            }

            return listaPais;
        }

        public static List<Provincia> LeerProvincia()
        {
            var listaProv = new List<Provincia>();

            if (!File.Exists("Provincia.dat")) return listaProv;

            try
            {
                using (var reader = new BinaryReader(File.Open("Provincia.dat", FileMode.Open)))
                {
                    while(reader.BaseStream.Position < reader.BaseStream.Length)
                    {
                        short pais = reader.ReadInt16();
                        short codigo = reader.ReadInt16();
                        string nombre = reader.ReadString();
                        listaProv.Add(new Provincia(codigo, nombre, pais));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer provincias: \n{ex.Message}", "Error de lectura");
            }

            return listaProv;
        }

        public static List<Ciudad> LeerCiudad()
        {
            var listaCiudad = new List<Ciudad>();

            if (!File.Exists("Ciudad.dat")) return listaCiudad;

            try
            {
                using (var reader = new BinaryReader(File.Open("Ciudad.dat", FileMode.Open)))
                {
                    while (reader.BaseStream.Position < reader.BaseStream.Length)
                    {
                        short pais = reader.ReadInt16();
                        short provincia = reader.ReadInt16();
                        short codigo = reader.ReadInt16();
                        string nombre = reader.ReadString();
                        long habitantes = reader.ReadInt64();
                        listaCiudad.Add(new Ciudad(codigo, nombre, provincia, pais, habitantes));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer provincias: \n{ex.Message}", "Error de lectura");
            }

            return listaCiudad;
        }

    }


}
