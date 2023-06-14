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
    /// Lógica de interacción para GenerarFacturaProforma.xaml
    /// </summary>
    public partial class GenerarFacturaProforma : Window
    {
        Factura F1 = new Factura();
        public GenerarFacturaProforma()
        {
            InitializeComponent();
            GenerarFactura.DataContext = F1;
            InitializeComponent();
            F1.coche = MainWindow.Co1;

            this.MatriculaTB.Text = MainWindow.Co1.Matricula;
            this.BastidorTB.Text = MainWindow.Co1.Id_coche;
            this.MarcaTB.Text = MainWindow.Co1.Marca;
            this.ModeloTB.Text = MainWindow.Co1.Modelo;

            this.NombreTB.Text= MainWindow.Co1.propietario.Nombre;
            this.ApellidosTB.Text = MainWindow.Co1.propietario.Apellidos;
            this.DireccionTB.Text = MainWindow.Co1.propietario.Direccion;
            this.DNItb.Text = MainWindow.Co1.propietario.Id_propietario;



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                F1.FechaExp = Convert.ToDateTime(Calendario.Text);
                F1.NumFactura = Convert.ToInt32(NumFactura.Text);
                MainWindow.U1.RepositorioFactura.Create(F1);
                MainWindow.U1.Save();
                F1 = new Factura();
                GenerarFactura.DataContext = F1;
                this.Close();
                VentanaConfirmacion v1 = new VentanaConfirmacion();
                v1.Show();
            }
            catch
            {
                GenerarFactura.DataContext = F1;
                this.Close();
                VentanaError v1 = new VentanaError();
                v1.Show();
            }
        }
    }
}
