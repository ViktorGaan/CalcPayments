﻿#pragma checksum "..\..\PageCalculator.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "746110BF0B551A55D14568F50262DCC0DA5872EE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ItVolga;
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


namespace ItVolga {
    
    
    /// <summary>
    /// PageCalculator
    /// </summary>
    public partial class PageCalculator : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\PageCalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnСalculate;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\PageCalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SummaText;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\PageCalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SrokText;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\PageCalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ProcentText;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\PageCalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox KomissiyText;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\PageCalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox VidBox;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\PageCalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datestart;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\PageCalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Money;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\PageCalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox srokBox;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\PageCalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ProcentBox;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\PageCalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Value;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\PageCalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridForData;
        
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
            System.Uri resourceLocater = new System.Uri("/ItVolga;component/pagecalculator.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PageCalculator.xaml"
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
            this.BtnСalculate = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\PageCalculator.xaml"
            this.BtnСalculate.Click += new System.Windows.RoutedEventHandler(this.BtnСalculate_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SummaText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.SrokText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ProcentText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.KomissiyText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.VidBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.datestart = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 8:
            this.Money = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.srokBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.ProcentBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 11:
            this.Value = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 12:
            this.GridForData = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

