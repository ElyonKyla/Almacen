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
    /// Lógica de interacción para BuscadorPiezas.xaml
    /// </summary>
    public partial class BuscadorPiezas : Window
    {
        DataGrid G1;
        List<Pieza> piezas = new List<Pieza>();
        Pieza P1;
        public BuscadorPiezas(DataGrid G1)
        {
            InitializeComponent();
            this.G1 = G1;
            BuscadorPieza.DataContext = P1;
        }

      

        private void Piezas_DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                P1 = (Pieza)Piezas_DataGrid.SelectedItem;
                int Stock = P1.Cantidad;
                Stock = Stock - 1;
                P1.Cantidad = Stock;
               // MainWindow.U1.RepositorioPieza.Update(P1);
                GenerarArreglo.listaPieza.Add(P1);
                ModificarArreglo.listaPieza.Add(P1);
                G1.Items.Refresh();
                this.Close();

            }
            catch {
                VentanaError v1 = new VentanaError();
                v1.Show();
            }
        }

        private void Buscador_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                piezas.Clear();
                Piezas_DataGrid.Items.Refresh();
                //Referencia
                if (!string.IsNullOrEmpty(this.ReferenciaTBal.Text))
                {
                    piezas = MainWindow.U1.RepositorioPieza.Get(x => (x.IdPieza.Trim().Equals(this.ReferenciaTBal.Text.Trim()))).ToList();
                }
                //Nombre pieza
                if (!string.IsNullOrEmpty(this.NombreTBal.Text))
                {
                    piezas = MainWindow.U1.RepositorioPieza.Get(x => (x.Nombre.Trim().Equals(this.NombreTBal.Text.Trim()))).ToList();
                }
                //Marca
                if (!string.IsNullOrEmpty(this.MarcaTBal.Text))
                {
                    piezas = MainWindow.U1.RepositorioPieza.Get(x => (x.Marca.Trim().Equals(this.MarcaTBal.Text.Trim())) || x.Marca.Trim().Equals("*")).ToList();
                }
                //Modelo
                if (!string.IsNullOrEmpty(this.ModeloTBal.Text))
                {
                    piezas = MainWindow.U1.RepositorioPieza.Get(x => (x.Modelo.Trim().Equals(this.ModeloTBal.Text.Trim())) || x.Marca.Trim().Equals("*")).ToList();
                }
                //Fabricante
                if (!string.IsNullOrEmpty(this.CasaTBal.Text))
                {
                    piezas = MainWindow.U1.RepositorioPieza.Get(x => (x.Casa.Trim().Equals(this.CasaTBal.Text.Trim()))).ToList();
                }
                //Variante
                if (!string.IsNullOrEmpty(this.VarianteTBal.Text))
                {
                    piezas = MainWindow.U1.RepositorioPieza.Get(x => (x.Variante.Trim().Equals(this.VarianteTBal.Text.Trim()))).ToList();
                }



                // piezas = MainWindow.U1.RepositorioPieza.Get(x => (x.IdPieza.Equals(this.ReferenciaTBal.Text)) || (x.Nombre.Equals(this.NombreTBal.Text)) || (x.Casa.Equals(this.CasaTBal.Text)) || (x.Variante.Equals(this.VarianteTBal.Text))).ToList();


                Piezas_DataGrid.ItemsSource = piezas;
                
                P1 = new Pieza();
                BuscadorPieza.DataContext = P1;
            }
            catch
            {
                P1 = new Pieza();
                BuscadorPieza.DataContext = P1;
                VentanaError v1 = new VentanaError();
                v1.Show();

            }
            

        }

       
    }
}
