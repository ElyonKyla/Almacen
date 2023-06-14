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
    /// Lógica de interacción para BuscadorClientes.xaml
    /// </summary>
    public partial class BuscadorClientes : Window {
        List<Propietario> props = new List<Propietario>();
        Grid G1;
        Propietario C1 = new Propietario();
        public BuscadorClientes(List <Propietario> props, Grid G1) {     
            InitializeComponent();
            this.G1 = G1;
            this.props = props;
            Clientes_dataGrid.ItemsSource = props;
        }

        private void Clientes_dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            try {
                C1 = (Propietario)Clientes_dataGrid.SelectedItem;
                G1.DataContext = C1;
                MainWindow.Cli1 = C1;

                CambiarDatos.CliNuevo = C1;

                //Intento de vacia
                props = new List<Propietario>();
                Clientes_dataGrid.DataContext = props;
                this.Close();
            }
            catch {
                
                VentanaError v1 = new VentanaError();
                v1.Show();

            }
        }
    }
}
