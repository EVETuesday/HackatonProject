﻿#pragma checksum "..\..\..\Pages\TeacherPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "909F288E9C00ACA5C029A8C195888C022C0B227BC01CFA6526DA420FAAA4A026"
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
using WpfApp6.Pages;


namespace WpfApp6.Pages {
    
    
    /// <summary>
    /// TeacherPage
    /// </summary>
    public partial class TeacherPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\Pages\TeacherPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSearch;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Pages\TeacherPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dg;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Pages\TeacherPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDel;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp6;component/pages/teacherpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\TeacherPage.xaml"
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
            this.tbSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\..\Pages\TeacherPage.xaml"
            this.tbSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dg = ((System.Windows.Controls.DataGrid)(target));
            
            #line 59 "..\..\..\Pages\TeacherPage.xaml"
            this.dg.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dg_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 60 "..\..\..\Pages\TeacherPage.xaml"
            this.dg.CellEditEnding += new System.EventHandler<System.Windows.Controls.DataGridCellEditEndingEventArgs>(this.dg_CellEditEnding);
            
            #line default
            #line hidden
            
            #line 61 "..\..\..\Pages\TeacherPage.xaml"
            this.dg.RowEditEnding += new System.EventHandler<System.Windows.Controls.DataGridRowEditEndingEventArgs>(this.dg_RowEditEnding);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnDel = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\Pages\TeacherPage.xaml"
            this.BtnDel.Click += new System.Windows.RoutedEventHandler(this.BtnDel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

