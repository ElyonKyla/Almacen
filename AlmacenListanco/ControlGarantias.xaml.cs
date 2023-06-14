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
    /// Lógica de interacción para ControlGarantias.xaml
    /// </summary>
    public partial class ControlGarantias : Window {
        public Arreglo A2 = new Arreglo();
        public Arreglo A3 = new Arreglo();
        
        public ControlGarantias(Arreglo A2) {

            InitializeComponent();
            ConGarantia.DataContext = A2;
            A3= MainWindow.U1.RepositorioArreglo.Get(x => (x.IdAreglo.Equals(A2.IdAreglo))).FirstOrDefault();
        }

        private void Si_Garantia_Click(object sender, RoutedEventArgs e) {
            try {
                A3.Tipo = "En Garantia";
                MainWindow.U1.RepositorioArreglo.Update(A3);
                MainWindow.U1.Save();
                VentanaConfirmacion v1 = new VentanaConfirmacion();
                v1.Show();
                this.Close();
            }
            catch {
                VentanaError v1 = new VentanaError();
                v1.Show();
            }
        }

        private void No_Garanía_Click(object sender, RoutedEventArgs e) {
            try { 
                A2.Tipo = "Sin Garantia";
                MainWindow.U1.RepositorioArreglo.Update(A3);
                MainWindow.U1.Save();
                VentanaConfirmacion v1 = new VentanaConfirmacion();
                v1.Show();
                this.Close();
            }
            catch {
                VentanaError v1 = new VentanaError();
                v1.Show();
            }
}
    }
}
