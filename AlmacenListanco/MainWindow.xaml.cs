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
using System.Windows.Navigation;
using System.Windows.Shapes;
using AlmacenListanco.BaseDatos;
using System.Globalization;
using System.Data.Sql;

namespace AlmacenListanco
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : Window
    {
        public static UnitOfWork U1 = new UnitOfWork();
        public static Pieza P1 = new Pieza();
        Empresa E1 = new Empresa();
        Compra Buy1 = new Compra();
        public static Factura F1 = new Factura();
        public static Propietario Cli1 = new Propietario();
        public static Coche Co1 = new Coche();
        List<Pieza> piezas = new List<Pieza>();
        List<Empresa> Provee = new List<Empresa>();
        List<Coche> coches = new List<Coche>();
        public static List<Propietario> clientes = new List<Propietario>();
        List<Factura> Facturas = new List<Factura>();
        Arreglo A1 = new Arreglo();
        List<Arreglo> temp = new List<Arreglo>();
        Conect v6 = new Conect();

        public MainWindow()
        {
            InitializeComponent();

            // Retrieve the enumerator instance and then the data.  
            // SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            // System.Data.DataTable table = instance.GetDataSources();
            



            AlmacenGrid.DataContext = P1;
            EmpresaGrid.DataContext = E1;
            ClienteGrid.DataContext = Cli1;
            
            Provee = U1.RepositorioEmpresa.Get();
            clientes = U1.RepositorioPropietario.Get();

            ProovedorCBal.ItemsSource = Provee;
            ProovedorCBal.DisplayMemberPath = "Nombre";
            ProovedorCBal.SelectedValuePath = "IdEmpresa";
            v6.Show();
        }
        static string RemoveDiacritics(string text) {
            return string.Concat(
                text.Normalize(NormalizationForm.FormD).Where(ch => CharUnicodeInfo.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark)).Normalize(NormalizationForm.FormC);
        }

        //Almacen
        private void SaveAl_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Pieza PBD = new Pieza();
                PBD = U1.RepositorioPieza.Get(z => (z.IdPieza.Equals(this.ReferenciaTBal.Text))).FirstOrDefault();

               if (PBD != null) {
                    P1 = U1.RepositorioPieza.Get(z => (z.IdPieza.Equals(this.ReferenciaTBal.Text))).FirstOrDefault();
                    Buy1.EmpresaId = this.ProovedorCBal.SelectedValue.ToString();
                    Buy1.FechaEntrada = this.Compra_calendario.SelectedDate.Value;
                    Buy1.PiezaId = this.ReferenciaTBal.Text;
                    Buy1.Precio = (Convert.ToInt32(this.PrecioTBal.Text)) * (Convert.ToInt32(this.CantidadTBal.Text));

                    int NewStock = Convert.ToInt32(this.CantidadTBal.Text);
                    int OldStock = P1.Cantidad;
                    NewStock = OldStock + NewStock;
                    P1.Compras.Add(Buy1);
                    P1.Cantidad = NewStock;
                    U1.Save();
                    
                    P1 = new Pieza();
                    AlmacenGrid.DataContext = P1;
                    VentanaConfirmacion v1 = new VentanaConfirmacion();
                    v1.Show();
                    U1 = new UnitOfWork();

                } else {
                        Buy1.EmpresaId = this.ProovedorCBal.SelectedValue.ToString();
                        Buy1.FechaEntrada = this.Compra_calendario.SelectedDate.Value;
                        Buy1.PiezaId = this.ReferenciaTBal.Text;
                      //  Buy1.Precio = (Convert.ToInt32(this.PrecioTBal.Text)) * (Convert.ToInt32(this.CantidadTBal.Text));
                        //  P1.Prove.IdEmpresa= this.ProovedorCBal.SelectedValue.ToString();
                        //eSTA LINEA DE CODIGO DA PROBLEMAS
                         P1.Compras.Add(Buy1);
                        U1.RepositorioPieza.Create(P1);
                        U1.Save();
                        P1 = new Pieza();
                        
                        AlmacenGrid.DataContext = P1;
                        VentanaConfirmacion v1 = new VentanaConfirmacion();
                        v1.Show();
                    }               
            }
            catch
            {
                P1 = new Pieza();
                AlmacenGrid.DataContext = P1;
                VentanaError v1 = new VentanaError();
                v1.Show();

            }

        }

        private void ListarAl_button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {

                piezas = U1.RepositorioPieza.Get(c => c.Uso.Equals("Almacen") || string.IsNullOrEmpty(c.Uso));
                PiezasAlmacen_DataGrid.ItemsSource = piezas;
            }
            catch 
            {
                VentanaError v1 = new VentanaError();
                v1.Show();
            }
        }
        public void PiezasAlmacen_DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                P1 = (Pieza)PiezasAlmacen_DataGrid.SelectedItem;
                AsignarPieza v1 = new AsignarPieza(PiezasAlmacen_DataGrid);
                v1.Show();
            }
            catch {
                VentanaError v1 = new VentanaError();
                v1.Show();
            }
        }



        //Proveedor
        private void ProovedorCBal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        

        private void SavePro_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                E1.Nombre = RemoveDiacritics(this.NombreTBpro.Text).Trim();
                U1.RepositorioEmpresa.Create(E1);
                U1.Save();
                E1 = new Empresa();
                EmpresaGrid.DataContext = E1;
                Provee = U1.RepositorioEmpresa.Get();
                ProovedorCBal.ItemsSource = Provee;

                VentanaConfirmacion v1 = new VentanaConfirmacion();
                v1.Show();
                
            }
            catch 
            {
                E1 = new Empresa();
                EmpresaGrid.DataContext = E1;
                VentanaError v1 = new VentanaError();
                v1.Show();
            }

        }
        private void SearchPro_button_Click(object sender, RoutedEventArgs e) {
            try {
                string EmpreNom = RemoveDiacritics(this.NombreTBpro.Text).Trim();
                E1 = U1.RepositorioEmpresa.Get(z => (z.Nombre.Equals(EmpreNom)) || (z.IdEmpresa.Equals(this.NifTBpro.Text))).FirstOrDefault(); 
                EmpresaGrid.DataContext = E1;
            }
            catch {
                E1 = new Empresa();
                EmpresaGrid.DataContext = E1;
                VentanaError v1 = new VentanaError();
                v1.Show();
            }
        }
        private void ListarDevuel_button_Click(object sender, RoutedEventArgs e) {
            try {
                piezas = U1.RepositorioPieza.Get(c =>c.Prove.IdEmpresa.Equals(E1.IdEmpresa) && c.Uso.Equals("Almacen") || string.IsNullOrEmpty(c.Uso));
                PiezasProvee_DataGrid.ItemsSource = piezas;
            }
            catch {
                VentanaError v1 = new VentanaError();
                v1.Show();
            }
        }
        private void ListarCompras_button_Click(object sender, RoutedEventArgs e) {
            try {
                piezas = U1.RepositorioPieza.Get(c => c.Prove.IdEmpresa.Equals(E1.IdEmpresa) && c.Uso.Equals("Devuelto") || string.IsNullOrEmpty(c.Uso));
                PiezasProvee_DataGrid.ItemsSource = piezas;
            }
            catch {
                VentanaError v1 = new VentanaError();
                v1.Show();
            }
        }


        //Cliente
        private void SaveCliente_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Cli1.Nombre = RemoveDiacritics(this.NombreTBcli.Text).Trim();
                Cli1.Apellidos = RemoveDiacritics(this.ApellidosTBcli.Text).Trim();
                U1.RepositorioPropietario.Create(Cli1);
                U1.Save();
                Cli1 = new Propietario();
                ClienteGrid.DataContext = Cli1;
                VentanaConfirmacion v1 = new VentanaConfirmacion();
                v1.Show();
                U1 = new UnitOfWork();
            }
            catch 
            {
                Cli1 = new Propietario();
                ClienteGrid.DataContext = Cli1;
                VentanaError v1 = new VentanaError();
                v1.Show();
            }

        }
        
        private void SearchCliente_button_Click(object sender, RoutedEventArgs e)

        {
            try
            {
                // Cli1 = U1.RepositorioPropietario.Get(z =>(z.Id_propietario.Equals(this.NifTBcli.Text)) || ((z.Nombre.Equals(this.NombreTBcli.Text)) && (z.Apellidos.Equals(this.ApellidosTBcli.Text)))).FirstOrDefault();
                //  ClienteGrid.DataContext = Cli1;

                 //clientes= U1.RepositorioPropietario.Get(z => (z.Id_propietario.Equals(this.NifTBcli.Text)) || ((RemoveDiacritics(z.Nombre.Trim()).Equals(RemoveDiacritics((this.NombreTBcli.Text).Trim()))) || (z.Apellidos.Equals(this.ApellidosTBcli.Text)))).ToList();

                string nomText = RemoveDiacritics((this.NombreTBcli.Text).Trim());
                string ApeText = RemoveDiacritics((this.ApellidosTBcli.Text).Trim());

                clientes = U1.RepositorioPropietario.Get(z => (z.Id_propietario.Equals(this.NifTBcli.Text)) || (z.Nombre.Equals(nomText)) || (z.Apellidos.Equals(ApeText))).ToList();
                BuscadorClientes v1 = new BuscadorClientes(clientes,ClienteGrid);
                clientes = new List<Propietario>();
                v1.Show();
                
            }
            catch 
            {
                Cli1 = new Propietario();
                ClienteGrid.DataContext = Cli1;
                VentanaError v1 = new VentanaError();
                v1.Show();
            }
        }

        private void AltaCoche_button_Click(object sender, RoutedEventArgs e)
        {
            try {
                AltaCoche V1 = new AltaCoche();
                V1.Show();
             }
            catch
            {
                Cli1 = new Propietario();
                ClienteGrid.DataContext = Cli1;
                VentanaError v1 = new VentanaError();
                v1.Show();
            }

        }
        private void ListarCliente_button_Click(object sender, RoutedEventArgs e)
        {
            coches = Cli1.Coches.ToList();
           // coches = U1.RepositorioCoche.Get();
            CochesClientes_DataGrid.ItemsSource = coches;
        }
        private void CochesClientes_DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            try {
                Co1 = (Coche)CochesClientes_DataGrid.SelectedItem;
                CambiarDatos v1 = new CambiarDatos(CochesClientes_DataGrid);
                v1.Show();
            }
            catch {
                VentanaError v1 = new VentanaError();
                v1.Show();
            }
        }

        //TAller
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string matricula = this.MatriculaTBtaller.Text.Trim();
                matricula = matricula.Replace(" ",""); 
                Co1 = U1.RepositorioCoche.Get(x => (x.Matricula.Equals(matricula))).FirstOrDefault();
                TallerGrid.DataContext = Co1;
                this.PropietarioTBtaller.Text = Co1.propietario.NombreCompleto;
                this.TelefonoTBtaller.Text = Co1.propietario.Telefono;
            }
            catch
            {
                Co1 = new Coche();
                TallerGrid.DataContext = Co1;
                VentanaError v1 = new VentanaError();
                v1.Show();
            }

        }


        private void GenerarFact_button_Click(object sender, RoutedEventArgs e)
        {
            try { 
            GenerarFacturaProforma V1 = new GenerarFacturaProforma();
            V1.ShowDialog();
            }
            catch
            {
                Co1 = new Coche();
                TallerGrid.DataContext = Co1;
                VentanaError v1 = new VentanaError();
                v1.Show();
            }
        }

        private void GenerarArre_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                GenerarArreglo V1 = new GenerarArreglo();
                V1.ShowDialog();
            }
            catch
            {
                Co1 = new Coche();
                TallerGrid.DataContext = Co1;
                VentanaError v1 = new VentanaError();
                v1.Show();
            }
        }

        private void ModArreglo_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ModificarArreglo V1 = new ModificarArreglo();
                V1.ShowDialog();
            }
            catch
            {
                Co1 = new Coche();
                TallerGrid.DataContext = Co1;
                VentanaError v1 = new VentanaError();
                v1.Show();
            }

        }
        private void Historial_button_Click(object sender, RoutedEventArgs e)
        {
            int numArreglos;
            Facturas = Co1.Facturas.ToList();
            foreach (Factura d in Facturas) {
                numArreglos=d.Arreglos.Count();
                d.NumArreglos = numArreglos;
            }
            HistorialGrid.ItemsSource = Facturas;
        }

        private void HistorialGrid_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            try {
                F1 = (Factura)HistorialGrid.SelectedItem;
            }
            catch {
                VentanaError v1 = new VentanaError();
                v1.Show();
            }
        }
    }
}
