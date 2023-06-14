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
    /// Lógica de interacción para GenerarArreglo.xaml
    /// </summary>
    public partial class GenerarArreglo : Window
    {
       public static Arreglo A1 = new Arreglo();
        List<Arreglo> temp = new List<Arreglo>();
        Factura F1 = new Factura();
        public static List<Pieza> listaPieza = new List<Pieza>();
        public GenerarArreglo()
        {
            
            InitializeComponent();
            this.MatriculaTB.Text = MainWindow.Co1.Matricula;
            this.BastidorTB.Text = MainWindow.Co1.Id_coche;
            this.MarcaTB.Text = MainWindow.Co1.Marca;
            this.ModeloTB.Text = MainWindow.Co1.Modelo;

            FacturaCB.ItemsSource = MainWindow.Co1.Facturas;
            FacturaCB.DisplayMemberPath = "NumFactura";
            FacturaCB.SelectedValuePath = "NumFactura";

            
            GenArreglo.DataContext = A1;

            PiezasArreglo_DataGrid.ItemsSource = listaPieza;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try { 
            BuscadorPiezas V1 = new BuscadorPiezas(PiezasArreglo_DataGrid);
            V1.ShowDialog();
            }
            catch {
                VentanaError v1 = new VentanaError();
                v1.Show();
            }

        }

        private void FacturaCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = FacturaCB.SelectedIndex;
            F1 = MainWindow.Co1.Facturas.ToList()[index];
            temp = MainWindow.Co1.Facturas.ToList()[index].Arreglos.ToList();
            this.ArregloTB.Text = (temp.Count + 1).ToString();


        }

        private void GenArreglo_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                A1.Piezas = listaPieza;
                A1.IdAreglo = Convert.ToInt32(this.ArregloTB.Text);
                // MainWindow.U1.RepositorioArreglo.Create(A1);
                F1.Arreglos.Add(A1);
                MainWindow.U1.RepositorioFactura.Update(F1);
                MainWindow.U1.Save();
                GenArreglo.DataContext = A1;
                ControlGarantias v2 = new ControlGarantias(A1);
                v2.Show();
                this.Close();
            }
            catch
            {
                VentanaError v1 = new VentanaError();
                v1.Show();
            }
        }
        }

    }
    

