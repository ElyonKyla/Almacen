﻿#pragma checksum "..\..\AltaCoche.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CC43095331DD90DCFD79865783186F66689FF809"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using AlmacenListanco;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace AlmacenListanco {
    
    
    /// <summary>
    /// AltaCoche
    /// </summary>
    public partial class AltaCoche : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\AltaCoche.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Coche;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\AltaCoche.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Bastidor;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\AltaCoche.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Matricula;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\AltaCoche.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Nombre;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\AltaCoche.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Marca;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\AltaCoche.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Modelo;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\AltaCoche.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Save_button;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\AltaCoche.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ModCoche;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\AltaCoche.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Apellidos;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\AltaCoche.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Calendario;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AlmacenListanco;component/altacoche.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AltaCoche.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Coche = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.Bastidor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Matricula = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Nombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Marca = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Modelo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Save_button = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\AltaCoche.xaml"
            this.Save_button.Click += new System.Windows.RoutedEventHandler(this.SaveCo_button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ModCoche = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.Apellidos = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.Calendario = ((System.Windows.Controls.DatePicker)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

