﻿#pragma checksum "..\..\NavPasager.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "16E711598FCDF8A5138099DC0E44E3C2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ClientWPF;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace ClientWPF {
    
    
    /// <summary>
    /// NavPasager
    /// </summary>
    public partial class NavPasager : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\NavPasager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\NavPasager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox tracksCB;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\NavPasager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox hoursCB;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\NavPasager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bookBT;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\NavPasager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\NavPasager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button logoffBT;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\NavPasager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label2;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\NavPasager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox numberTB;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\NavPasager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label3;
        
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
            System.Uri resourceLocater = new System.Uri("/ClientWPF;component/navpasager.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\NavPasager.xaml"
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
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.tracksCB = ((System.Windows.Controls.ComboBox)(target));
            
            #line 11 "..\..\NavPasager.xaml"
            this.tracksCB.DropDownOpened += new System.EventHandler(this.tracksCB_DropDownOpened);
            
            #line default
            #line hidden
            return;
            case 3:
            this.hoursCB = ((System.Windows.Controls.ComboBox)(target));
            
            #line 12 "..\..\NavPasager.xaml"
            this.hoursCB.DropDownOpened += new System.EventHandler(this.hoursCB_DropDownOpened);
            
            #line default
            #line hidden
            return;
            case 4:
            this.bookBT = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\NavPasager.xaml"
            this.bookBT.Click += new System.Windows.RoutedEventHandler(this.bookBT_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.logoffBT = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\NavPasager.xaml"
            this.logoffBT.Click += new System.Windows.RoutedEventHandler(this.logoffBT_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.label2 = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.numberTB = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\NavPasager.xaml"
            this.numberTB.GotFocus += new System.Windows.RoutedEventHandler(this.numberTB_GotFocus);
            
            #line default
            #line hidden
            
            #line 17 "..\..\NavPasager.xaml"
            this.numberTB.LostFocus += new System.Windows.RoutedEventHandler(this.numberTB_LostFocus);
            
            #line default
            #line hidden
            return;
            case 9:
            this.label3 = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

