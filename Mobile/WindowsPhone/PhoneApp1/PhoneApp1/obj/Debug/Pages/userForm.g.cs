﻿#pragma checksum "C:\Users\Dragutin\Desktop\AsyncroB\WP\Mobile\WindowsPhone\PhoneApp1\PhoneApp1\Pages\userForm.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BDA81805FC61097BAD9AAFC9D172C687"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CS.Windows.Controls;
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


namespace PhoneApp1 {
    
    
    public partial class userForm : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock pagefsdfsdName;
        
        internal System.Windows.Controls.StackPanel ContentPanel;
        
        internal CS.Windows.Controls.WatermarkTextBox naziv;
        
        internal CS.Windows.Controls.WatermarkTextBox prezime;
        
        internal CS.Windows.Controls.WatermarkTextBox korIme;
        
        internal CS.Windows.Controls.WatermarkPasswordBox lozinka;
        
        internal CS.Windows.Controls.WatermarkPasswordBox ponovanUnos;
        
        internal CS.Windows.Controls.WatermarkTextBox status;
        
        internal CS.Windows.Controls.WatermarkTextBox Id;
        
        internal CS.Windows.Controls.WatermarkTextBox tip;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/PhoneApp1;component/Pages/userForm.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.pagefsdfsdName = ((System.Windows.Controls.TextBlock)(this.FindName("pagefsdfsdName")));
            this.ContentPanel = ((System.Windows.Controls.StackPanel)(this.FindName("ContentPanel")));
            this.naziv = ((CS.Windows.Controls.WatermarkTextBox)(this.FindName("naziv")));
            this.prezime = ((CS.Windows.Controls.WatermarkTextBox)(this.FindName("prezime")));
            this.korIme = ((CS.Windows.Controls.WatermarkTextBox)(this.FindName("korIme")));
            this.lozinka = ((CS.Windows.Controls.WatermarkPasswordBox)(this.FindName("lozinka")));
            this.ponovanUnos = ((CS.Windows.Controls.WatermarkPasswordBox)(this.FindName("ponovanUnos")));
            this.status = ((CS.Windows.Controls.WatermarkTextBox)(this.FindName("status")));
            this.Id = ((CS.Windows.Controls.WatermarkTextBox)(this.FindName("Id")));
            this.tip = ((CS.Windows.Controls.WatermarkTextBox)(this.FindName("tip")));
        }
    }
}

