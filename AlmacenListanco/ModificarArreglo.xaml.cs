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
    /// Lógica de interacción para ModificarArreglo.xaml
    /// </summary>
    public partial class ModificarArreglo : Window
    {
        Arreglo A1 = new Arreglo();
        List<Arreglo> temp = new List<Arreglo>();
        public static List<Pieza> listaPieza = new List<Pieza>();
        Factura F1 = new Factura();
        
        public ModificarArreglo()
        {
            InitializeComponent();
            InitializeComponent();
            this.MatriculaTB.Text = MainWindow.Co1.Matricula;
            this.BastidorTB.Text = MainWindow.Co1.Id_coche;
            this.MarcaTB.Text = MainWindow.Co1.Marca;
            this.ModeloTB.Text = MainWindow.Co1.Modelo;

            FacturaCB.ItemsSource = MainWindow.Co1.Facturas;
            FacturaCB.DisplayMemberPath = "NumFactura";
            FacturaCB.SelectedValuePath = "NumFactura";
            ModArreglo.DataContext = A1;
        }

        private void FacturaCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = FacturaCB.SelectedIndex;
            F1 = MainWindow.Co1.Facturas.ToList()[index];
            temp = MainWindow.Co1.Facturas.ToList()[index].Arreglos.ToList();
            ArregloCB.ItemsSource = temp;
            ArregloCB.DisplayMemberPath = "IdAreglo";
            ArregloCB.SelectedValuePath = "IdAreglo";
        }

        private void ArregloCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ArregloCB.SelectedIndex;
            A1 = F1.Arreglos.ToList()[index];
            listaPieza = F1.Arreglos.ToList()[index].Piezas.ToList();
            PiezasArreglo_DataGrid.ItemsSource = listaPieza;
            this.tituloArreglo.Text = A1.Titulo;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BuscadorPiezas V1 = new BuscadorPiezas(PiezasArreglo_DataGrid);
            V1.ShowDialog();
        }

        private void ModArregloSave_button_Click(object sender, RoutedEventArgs e)
        {
            try { 
            A1.Piezas = listaPieza;
            
            F1.Arreglos.Add(A1);
            MainWindow.U1.RepositorioFactura.Update(F1);
            MainWindow.U1.Save();
            ModArreglo.DataContext = A1;
            this.Close();
                VentanaConfirmacion v1 = new VentanaConfirmacion();
                v1.Show();
            }
            catch
            {
                VentanaError v1 = new VentanaError();
                v1.Show();
            }
        }
    }
}
