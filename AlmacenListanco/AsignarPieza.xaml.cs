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

namespace AlmacenListanco {
    /// <summary>
    /// Lógica de interacción para AsignarPieza.xaml
    /// </summary>
    public partial class AsignarPieza : Window {
        DataGrid G1;
        int stockTotal = MainWindow.P1.Cantidad;
        List<Compra> compras = new List<Compra>();
        public AsignarPieza(DataGrid G1) {
            InitializeComponent();
            this.G1 = G1;
            
            this.ReferenciaTBal.Text = MainWindow.P1.IdPieza;
            this.NombreTBal.Text = MainWindow.P1.Nombre;
            this.CasaTBal.Text = MainWindow.P1.Casa;
           // this.ProveTBal.Text = MainWindow.P1.Compras.
            // this.CantidadCBal.Text
            this.VarianteTBal.Text = MainWindow.P1.Variante;
            AsigPieza.DataContext = MainWindow.P1;
        }

        private void SaveAl_button_Click(object sender, RoutedEventArgs e) {
            try {
                MainWindow.P1.Uso = "Almacen";
                MainWindow.U1.RepositorioPieza.Update(MainWindow.P1);
                MainWindow.U1.Save();
                G1.Items.Refresh();
                this.Close();
                
                
                VentanaConfirmacion v1 = new VentanaConfirmacion();
                v1.Show();
            }
            catch {
                VentanaError v1 = new VentanaError();
                v1.Show();
            }

        }

        private void RestoreAl_button_Click(object sender, RoutedEventArgs e) {
            
            try {
                MainWindow.P1.Uso = "Devuelto";
                MainWindow.U1.RepositorioPieza.Update(MainWindow.P1);
                MainWindow.U1.Save();
                this.Close();
                
                VentanaConfirmacion v1 = new VentanaConfirmacion();
                v1.Show();
            }
            catch {
                VentanaError v1 = new VentanaError();
                v1.Show();
            }
        }

        private void CantidadCBal_SelectionChanged(object sender, SelectionChangedEventArgs e) {

        }
    }
}
