using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AlmacenListanco
{
    /// <summary>
    /// Lógica de interacción para AltaCoche.xaml
    /// </summary>
    public partial class AltaCoche : Window
    {
        Coche Co1 = new Coche();
        public AltaCoche()
        {
            InitializeComponent();
            Coche.DataContext = Co1;
            
            
            Co1.propietario = MainWindow.Cli1;
            this.Nombre.Text = MainWindow.Cli1.Nombre;
            this.Apellidos.Text = MainWindow.Cli1.Apellidos;
            Co1.PropietarioId = MainWindow.Cli1.Id_propietario;
           
            
        }

        private void SaveCo_button_Click(object sender, RoutedEventArgs e)
        {
            
           

            try {
                string matricula = this.Matricula.Text.Trim();
                matricula = matricula.Replace(" ","");
                Co1.Matricula = matricula;
                Co1.F_venta = Convert.ToDateTime(Calendario.Text);

            MainWindow.U1.RepositorioCoche.Create(Co1);
            MainWindow.U1.Save();
            Co1 = new Coche();
            Coche.DataContext = Co1;
                VentanaConfirmacion v1 = new VentanaConfirmacion();
                v1.Show();
            }
            catch
            {
                Co1 = new Coche();
                Coche.DataContext = Co1;
                VentanaError v1 = new VentanaError();
                v1.Show();
            }
        }
    }
}
