﻿#pragma checksum "..\..\..\JobWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F66565CAB5A61B690CD09E3E51C98316C12A17E7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using WPFApp;


namespace WPFApp {
    
    
    /// <summary>
    /// JobWindow
    /// </summary>
    public partial class JobWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\JobWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtJobId;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\JobWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtJobTitle;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\JobWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMinSalary;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\JobWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMaxSalary;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\JobWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSeachText;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\JobWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFilterMin;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\JobWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFilterMax;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\JobWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgData;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\JobWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCreate;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\JobWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdate;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\JobWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\JobWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPFApp;component/jobwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\JobWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\JobWindow.xaml"
            ((WPFApp.JobWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtJobId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtJobTitle = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtMinSalary = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtMaxSalary = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtSeachText = ((System.Windows.Controls.TextBox)(target));
            
            #line 54 "..\..\..\JobWindow.xaml"
            this.txtSeachText.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtSeachText_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtFilterMin = ((System.Windows.Controls.TextBox)(target));
            
            #line 57 "..\..\..\JobWindow.xaml"
            this.txtFilterMin.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtFilterSalary_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtFilterMax = ((System.Windows.Controls.TextBox)(target));
            
            #line 60 "..\..\..\JobWindow.xaml"
            this.txtFilterMax.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtFilterSalary_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.dgData = ((System.Windows.Controls.DataGrid)(target));
            
            #line 64 "..\..\..\JobWindow.xaml"
            this.dgData.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgData_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnCreate = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\JobWindow.xaml"
            this.btnCreate.Click += new System.Windows.RoutedEventHandler(this.btnCreate_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\..\JobWindow.xaml"
            this.btnUpdate.Click += new System.Windows.RoutedEventHandler(this.btnUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\JobWindow.xaml"
            this.btnDelete.Click += new System.Windows.RoutedEventHandler(this.btnDelete_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\..\JobWindow.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

