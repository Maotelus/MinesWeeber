﻿#pragma checksum "..\..\HauptMenue.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16A2C2B058B7A8E9CE5FB36873623B016993F74A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using MinesWeeber;
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


namespace MinesWeeber {
    
    
    /// <summary>
    /// HauptMenue
    /// </summary>
    public partial class HauptMenue : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\HauptMenue.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_StartGame;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\HauptMenue.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Highscore;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\HauptMenue.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Exit;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\HauptMenue.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_Name;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\HauptMenue.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_PlayerName;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\HauptMenue.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_warnign;
        
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
            System.Uri resourceLocater = new System.Uri("/MinesWeeber;component/hauptmenue.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\HauptMenue.xaml"
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
            
            #line 8 "..\..\HauptMenue.xaml"
            ((MinesWeeber.HauptMenue)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_StartGame = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\HauptMenue.xaml"
            this.btn_StartGame.Click += new System.Windows.RoutedEventHandler(this.Btn_start_game);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_Highscore = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\HauptMenue.xaml"
            this.btn_Highscore.Click += new System.Windows.RoutedEventHandler(this.Btn_Highscore);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_Exit = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\HauptMenue.xaml"
            this.btn_Exit.Click += new System.Windows.RoutedEventHandler(this.Btn_exit);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtbox_Name = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\HauptMenue.xaml"
            this.txtbox_Name.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lbl_PlayerName = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.lbl_warnign = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

