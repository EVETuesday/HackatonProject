﻿#pragma checksum "..\..\..\Windows\DocumentSearch.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9B07D1E63C992904D42062D416C3BFB25298AE6222180D98A44ED844D0569CAA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WpfApp6.Windows;


namespace WpfApp6.Windows {
    
    
    /// <summary>
    /// DocumentSearch
    /// </summary>
    public partial class DocumentSearch : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 48 "..\..\..\Windows\DocumentSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbDox;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Windows\DocumentSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbVed;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\Windows\DocumentSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblDox;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\Windows\DocumentSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblVed;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\Windows\DocumentSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCheck;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\..\Windows\DocumentSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGo;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp6;component/windows/documentsearch.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\DocumentSearch.xaml"
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
            this.tbDox = ((System.Windows.Controls.TextBox)(target));
            
            #line 48 "..\..\..\Windows\DocumentSearch.xaml"
            this.tbDox.GotFocus += new System.Windows.RoutedEventHandler(this.tbDox_GotFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbVed = ((System.Windows.Controls.TextBox)(target));
            
            #line 67 "..\..\..\Windows\DocumentSearch.xaml"
            this.tbVed.GotFocus += new System.Windows.RoutedEventHandler(this.tbVed_GotFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lblDox = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lblVed = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.btnCheck = ((System.Windows.Controls.Button)(target));
            
            #line 136 "..\..\..\Windows\DocumentSearch.xaml"
            this.btnCheck.Click += new System.Windows.RoutedEventHandler(this.btnCheck_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnGo = ((System.Windows.Controls.Button)(target));
            
            #line 166 "..\..\..\Windows\DocumentSearch.xaml"
            this.btnGo.Click += new System.Windows.RoutedEventHandler(this.btnGo_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
