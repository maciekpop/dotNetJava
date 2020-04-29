﻿#pragma checksum "..\..\..\..\Views\InfoView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64FA241D74465E87FE5B7B9C15D36B3A2FB68BA7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
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
using dotNetProjekt.Views;


namespace dotNetProjekt.Views {
    
    
    /// <summary>
    /// InfoView
    /// </summary>
    public partial class InfoView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\..\Views\InfoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label dataLabel;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Views\InfoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Views\InfoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button showAllDataButton;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Views\InfoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textWorkerName;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Views\InfoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button showOneWorker;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Views\InfoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textWorkerID;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Views\InfoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button showWorkerTimes;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Views\InfoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button schowMyTimes;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/dotNetProjekt;component/views/infoview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\InfoView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.dataLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 38 "..\..\..\..\Views\InfoView.xaml"
            this.dataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dataGridChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.showAllDataButton = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\..\Views\InfoView.xaml"
            this.showAllDataButton.Click += new System.Windows.RoutedEventHandler(this.showAllDataButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.textWorkerName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.showOneWorker = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\..\Views\InfoView.xaml"
            this.showOneWorker.Click += new System.Windows.RoutedEventHandler(this.showOneWorker_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.textWorkerID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.showWorkerTimes = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\..\Views\InfoView.xaml"
            this.showWorkerTimes.Click += new System.Windows.RoutedEventHandler(this.showWorkerTimes_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.schowMyTimes = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\..\Views\InfoView.xaml"
            this.schowMyTimes.Click += new System.Windows.RoutedEventHandler(this.schowMyTimes_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

