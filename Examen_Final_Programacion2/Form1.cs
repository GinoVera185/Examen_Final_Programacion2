namespace Examen_Final_Programacion2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Ingresar_Click(object sender, EventArgs e)
        {
            MenuIngreso menuIngreso = new MenuIngreso();
            menuIngreso.ShowDialog();
            
        }

        private void bt_consultar_Click(object sender, EventArgs e)
        {
            ConsultarHabitantes Consulta = new ConsultarHabitantes();
            Consulta.ShowDialog();
            
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        
    }
}
