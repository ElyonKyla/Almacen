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
using Microsoft.Win32;
using System.Data.SqlClient;
using System.Data.OleDb;
using Microsoft.SqlServer;


namespace AlmacenListanco {
    /// <summary>
    /// Lógica de interacción para Conect.xaml
    /// </summary>
    public partial class Conect : Window {
        public Conect() {
            InitializeComponent();
            //string Instancia="";

            //RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            //OleDbConnection connection = new OleDbConnection("Data Source =(local)\\" + Instancia + "; Initial Catalog = AlmacenDB; integrated security = SSPI; Provider=SQLOLEDB");
            //                    connection.Open();
            //                    Console.WriteLine("ServerVersion: {0}", connection.ServerVersion);


            //using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView)) {
            //    RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
            //    if (instanceKey != null) {
            //        foreach (var instanceName in instanceKey.GetValueNames()) {
            //            Console.WriteLine(Environment.MachineName + @"\" + instanceName);
            //            Instancia = instanceName;
            //        }
            //          SqlConnection conexion = new SqlConnection ("server ="+Environment.MachineName +"\\"  +Instancia  + "; Initial Catalog = AlmacenDB; integrated security = SSPI");
            //         //SqlConnection conexion = new SqlConnection("Data Source=localhost; Initial Catalog=AlmacenDB;Integrated Security=SSPI");
            //          conexion.Open();
            //    }
            //}

            //Connect to the local, default instance of SQL Server.   
            Server srv;
            srv = new Server();
            //The connection is established when a property is requested.   
            Console.WriteLine(srv.Information.Version);

        }
        
        //Archivo de conexion
    }
}
