﻿#pragma checksum "C:\Users\Andro\Documents\GitHub\RSC-Asyncro-B\Mobile\WindowsPhone\PhoneApp1\PhoneApp1\Pages\Settings.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "085A636F5061730E45D623633B0271FE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
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


namespace PhoneApp1 {
    
    
    public partial class Settings : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal Microsoft.Phone.Controls.ToggleSwitch pushNotification;
        
        internal Microsoft.Phone.Controls.ToggleSwitch alarmCheckBox;
        
        internal Microsoft.Phone.Controls.ToggleSwitch location;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/PhoneApp1;component/Pages/Settings.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.pushNotification = ((Microsoft.Phone.Controls.ToggleSwitch)(this.FindName("pushNotification")));
            this.alarmCheckBox = ((Microsoft.Phone.Controls.ToggleSwitch)(this.FindName("alarmCheckBox")));
            this.location = ((Microsoft.Phone.Controls.ToggleSwitch)(this.FindName("location")));
        }
    }
}

