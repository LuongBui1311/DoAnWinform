﻿#pragma checksum "..\..\..\Search.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50F365EE1A5D0FDF77D8DFFEC9E16AF02DB9A6EA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Login;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace Login {
    
    
    /// <summary>
    /// Search
    /// </summary>
    public partial class Search : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 115 "..\..\..\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtg_Thue;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtg_Tamtru;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\..\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtg_Tamvang;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\..\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtg_Cnkh;
        
        #line default
        #line hidden
        
        
        #line 216 "..\..\..\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_LogOut;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Login;V1.0.0.0;component/search.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Search.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 14 "..\..\..\Search.xaml"
            ((Login.Search)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dtg_Thue = ((System.Windows.Controls.DataGrid)(target));
            
            #line 115 "..\..\..\Search.xaml"
            this.dtg_Thue.Loaded += new System.Windows.RoutedEventHandler(this.dtg_Thue_Loaded);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dtg_Tamtru = ((System.Windows.Controls.DataGrid)(target));
            
            #line 128 "..\..\..\Search.xaml"
            this.dtg_Tamtru.Loaded += new System.Windows.RoutedEventHandler(this.dtg_Tamtru_Loaded);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dtg_Tamvang = ((System.Windows.Controls.DataGrid)(target));
            
            #line 148 "..\..\..\Search.xaml"
            this.dtg_Tamvang.Loaded += new System.Windows.RoutedEventHandler(this.dtg_Tamvang_Loaded);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dtg_Cnkh = ((System.Windows.Controls.DataGrid)(target));
            
            #line 168 "..\..\..\Search.xaml"
            this.dtg_Cnkh.Loaded += new System.Windows.RoutedEventHandler(this.dtg_Cnkh_Loaded);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_LogOut = ((System.Windows.Controls.Button)(target));
            
            #line 217 "..\..\..\Search.xaml"
            this.btn_LogOut.Click += new System.Windows.RoutedEventHandler(this.btn_LogOut_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

