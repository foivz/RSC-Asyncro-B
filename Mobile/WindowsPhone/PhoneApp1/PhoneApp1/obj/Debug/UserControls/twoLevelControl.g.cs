﻿#pragma checksum "C:\Users\Dragutin\Desktop\AsyncroB\WP\Mobile\WindowsPhone\PhoneApp1\PhoneApp1\UserControls\twoLevelControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BFFE9C98DA6ED7762E8B82C4BBD3F9C7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    
    
    public partial class twoLevelControl : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LevelGrid1;
        
        internal System.Windows.Controls.TextBlock Level1Name;
        
        internal System.Windows.Controls.Image Level1Image;
        
        internal System.Windows.Controls.Grid LevelGrid2;
        
        internal System.Windows.Controls.TextBlock Level2Name;
        
        internal System.Windows.Controls.Image Level2Image;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/PhoneApp1;component/UserControls/twoLevelControl.xaml", System.UriKind.Relative));
            this.LevelGrid1 = ((System.Windows.Controls.Grid)(this.FindName("LevelGrid1")));
            this.Level1Name = ((System.Windows.Controls.TextBlock)(this.FindName("Level1Name")));
            this.Level1Image = ((System.Windows.Controls.Image)(this.FindName("Level1Image")));
            this.LevelGrid2 = ((System.Windows.Controls.Grid)(this.FindName("LevelGrid2")));
            this.Level2Name = ((System.Windows.Controls.TextBlock)(this.FindName("Level2Name")));
            this.Level2Image = ((System.Windows.Controls.Image)(this.FindName("Level2Image")));
        }
    }
}

