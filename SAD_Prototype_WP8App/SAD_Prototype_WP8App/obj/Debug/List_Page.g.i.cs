﻿#pragma checksum "C:\Users\Suryanarayanamurthy\Documents\GitHub\SAD14BS13\SAD_Prototype_WP8App\SAD_Prototype_WP8App\List_Page.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E7349BC79D54151AE98F06D73D3A339E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace SAD_Prototype_WP8App {
    
    
    public partial class List_Page : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBox Titel_Tb;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.ListBox ItemsList;
        
        internal System.Windows.Controls.TextBox NewItem_tb;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/SAD_Prototype_WP8App;component/List_Page.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.Titel_Tb = ((System.Windows.Controls.TextBox)(this.FindName("Titel_Tb")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.ItemsList = ((System.Windows.Controls.ListBox)(this.FindName("ItemsList")));
            this.NewItem_tb = ((System.Windows.Controls.TextBox)(this.FindName("NewItem_tb")));
        }
    }
}

