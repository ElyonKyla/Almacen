﻿#pragma checksum "..\..\BuscadorPiezas.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58394CB6F0CAB038678140DB923B21D84413FF55"
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
    /// BuscadorPiezas
    /// </summary>
    public partial class BuscadorPiezas : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\BuscadorPiezas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid BuscadorPieza;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\BuscadorPiezas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ReferenciaTBal;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\BuscadorPiezas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NombreTBal;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\BuscadorPiezas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CasaTBal;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\BuscadorPiezas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MarcaTBal;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\BuscadorPiezas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ModeloTBal;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\BuscadorPiezas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox VarianteTBal;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\BuscadorPiezas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Buscador_button;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\BuscadorPiezas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Piezas_DataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/AlmacenListanco;component/buscadorpiezas.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\BuscadorPiezas.xaml"
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
            this.BuscadorPieza = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.ReferenciaTBal = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.NombreTBal = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.CasaTBal = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.MarcaTBal = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.ModeloTBal = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.VarianteTBal = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.Buscador_button = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\BuscadorPiezas.xaml"
            this.Buscador_button.Click += new System.Windows.RoutedEventHandler(this.Buscador_button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Piezas_DataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 26 "..\..\BuscadorPiezas.xaml"
            this.Piezas_DataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Piezas_DataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
