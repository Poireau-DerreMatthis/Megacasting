﻿#pragma checksum "..\..\..\..\Views\PackView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DA80803B0855A4EEE16BC02F8343C6DE7F23B47D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
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
using megacasting.WPF.Views;


namespace megacasting.WPF.Views {
    
    
    /// <summary>
    /// PackView
    /// </summary>
    public partial class PackView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\..\Views\PackView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid myGrid;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Views\PackView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridPack;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Views\PackView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Libelle;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Views\PackView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NombreOffre;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Views\PackView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tarif;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Views\PackView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ModifierPack;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Views\PackView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SupprimerPack;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Views\PackView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AjouterPack;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/megacasting.WPF;component/views/packview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\PackView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.myGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.DataGridPack = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.Libelle = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.NombreOffre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Tarif = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.ModifierPack = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\..\Views\PackView.xaml"
            this.ModifierPack.Click += new System.Windows.RoutedEventHandler(this.ModifierPack_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.SupprimerPack = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\..\Views\PackView.xaml"
            this.SupprimerPack.Click += new System.Windows.RoutedEventHandler(this.SupprimerPack_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.AjouterPack = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\..\Views\PackView.xaml"
            this.AjouterPack.Click += new System.Windows.RoutedEventHandler(this.AjouterUser_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

