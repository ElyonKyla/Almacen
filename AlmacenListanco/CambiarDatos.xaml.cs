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
    /// Lógica de interacción para CambiarDatos.xaml
    /// </summary>
    public partial class CambiarDatos : Window {
        DataGrid G1;
        public static Propietario CliNuevo = new Propietario();
        Propietario CliViejo = new Propietario();
        List<Coche> cochesCliNuevo = new List<Coche>();
        List<Coche> cochesCliViejo = new List<Coche>();
        public static List<Propietario> buscado = new List<Propietario>();

        bool MatriculaVacia = false;
        string MatriculaConservar;
        public CambiarDatos(DataGrid G1) {
            InitializeComponent();
            this.G1 = G1;
            this.Bastidor.Text = MainWindow.Co1.Id_coche;
            this.Marca.Text = MainWindow.Co1.Marca;
            this.Modelo.Text = MainWindow.Co1.Modelo;
            this.Matricula.Text = MainWindow.Co1.Matricula;
            CliViejo = MainWindow.U1.RepositorioPropietario.Get(z => (z.Id_propietario.Equals(MainWindow.Co1.PropietarioId))).FirstOrDefault();
            this.Nombre.Text = MainWindow.Cli1.Nombre;
            this.Apellidos.Text = MainWindow.Cli1.Apellidos;
            cochesCliViejo = CliViejo.Coches.ToList();
            MatriculaConservar = MainWindow.Co1.Matricula;
            CliNuevo = new Propietario();
            Nuevo_Cli.DataContext = CliNuevo;
            
        }

        private void Buscar_Click(object sender, RoutedEventArgs e) {
            try {
               // CliNuevo = MainWindow.U1.RepositorioPropietario.Get(z => ((z.Nombre.Equals(this.Nombre_Nuevo.Text)) && (z.Apellidos.Equals(this.Apellidos_Nuevo.Text)))).FirstOrDefault();
                buscado = MainWindow.U1.RepositorioPropietario.Get(z => ((z.Nombre.Equals(this.Nombre_Nuevo.Text)) || (z.Apellidos.Equals(this.Apellidos_Nuevo.Text)))).ToList();
                BuscadorClientes v1 = new BuscadorClientes(buscado, Nuevo_Cli);
                v1.Show();
                cochesCliNuevo = CliNuevo.Coches.ToList();
            }catch {
                this.Close();
                VentanaError v1 = new VentanaError();
                v1.Show();
            }
            
        }

        private void SaveCo_button_Click(object sender, RoutedEventArgs e) {
            try {
                MatriculaVacia = string.IsNullOrEmpty(this.Matricula_Nueva.Text);
                    if (MatriculaVacia == true) {
                    MainWindow.Co1.Matricula = MatriculaConservar;
                    MainWindow.Co1.PropietarioId = CliNuevo.Id_propietario;
                    MainWindow.U1.RepositorioCoche.Update(MainWindow.Co1);
                    CliNuevo.Coches.Add(MainWindow.Co1);
                    CliViejo.Coches.Remove(MainWindow.Co1);

                    MainWindow.U1.RepositorioPropietario.Update(CliNuevo);
                    MainWindow.U1.RepositorioPropietario.Update(CliViejo);
                    MainWindow.U1.Save();
                    G1.Items.Refresh();
                    this.Close();
                    VentanaConfirmacion v1 = new VentanaConfirmacion();
                    v1.Show();

                    


                } else {
                    string matricula = Matricula_Nueva.Text.Trim();
                    matricula = matricula.Replace(" ", "");
                    MainWindow.Co1.Matricula = matricula;
                    MainWindow.Co1.PropietarioId = CliNuevo.Id_propietario;
                    MainWindow.U1.RepositorioCoche.Update(MainWindow.Co1);
                    CliNuevo.Coches.Add(MainWindow.Co1);
                    CliViejo.Coches.Remove(MainWindow.Co1);
                    MainWindow.U1.RepositorioPropietario.Update(CliNuevo);
                    MainWindow.U1.RepositorioPropietario.Update(CliViejo);
                    MainWindow.U1.Save();
                    G1.Items.Refresh();
                    this.Close();
                    VentanaConfirmacion v1 = new VentanaConfirmacion();
                    v1.Show();

                }

            }
            catch {
                this.Close();
                VentanaError v1 = new VentanaError();
                v1.Show();
            }
        }
    }
}
