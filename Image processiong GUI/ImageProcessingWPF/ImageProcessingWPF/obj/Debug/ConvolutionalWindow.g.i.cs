﻿#pragma checksum "..\..\ConvolutionalWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "915CFDBBC8745D34BAA895025A15FD793C5EB0153C810E333268FECACC918BF8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ImageProcessingWPF;
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


namespace ImageProcessingWPF {
    
    
    /// <summary>
    /// ConvolutionalWindow
    /// </summary>
    public partial class ConvolutionalWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\ConvolutionalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Sobel_x;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\ConvolutionalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sobel_y;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\ConvolutionalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button laplacian_1;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\ConvolutionalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button laplacian_2;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\ConvolutionalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button low_pass;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\ConvolutionalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button high_pass;
        
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
            System.Uri resourceLocater = new System.Uri("/ImageProcessingWPF;component/convolutionalwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ConvolutionalWindow.xaml"
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
            this.Sobel_x = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\ConvolutionalWindow.xaml"
            this.Sobel_x.Click += new System.Windows.RoutedEventHandler(this.sobelx);
            
            #line default
            #line hidden
            return;
            case 2:
            this.sobel_y = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\ConvolutionalWindow.xaml"
            this.sobel_y.Click += new System.Windows.RoutedEventHandler(this.sobely);
            
            #line default
            #line hidden
            return;
            case 3:
            this.laplacian_1 = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\ConvolutionalWindow.xaml"
            this.laplacian_1.Click += new System.Windows.RoutedEventHandler(this.laplacian1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.laplacian_2 = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\ConvolutionalWindow.xaml"
            this.laplacian_2.Click += new System.Windows.RoutedEventHandler(this.laplacian2);
            
            #line default
            #line hidden
            return;
            case 5:
            this.low_pass = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\ConvolutionalWindow.xaml"
            this.low_pass.Click += new System.Windows.RoutedEventHandler(this.lowpass);
            
            #line default
            #line hidden
            return;
            case 6:
            this.high_pass = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\ConvolutionalWindow.xaml"
            this.high_pass.Click += new System.Windows.RoutedEventHandler(this.highpass);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

