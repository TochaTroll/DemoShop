﻿#pragma checksum "..\..\..\Windows\ProductView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A2099C3C1A0273E891FD0493E16D32B7F44CA8277BFE37ED0FE1441B6F199A66"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using DemoTooooop;
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


namespace DemoTooooop {
    
    
    /// <summary>
    /// ProductView
    /// </summary>
    public partial class ProductView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\Windows\ProductView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonMainWindow;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Windows\ProductView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAddProduct;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Windows\ProductView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonEditProduct;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Windows\ProductView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonRemoveProduct;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Windows\ProductView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxSearhName;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Windows\ProductView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxCost;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Windows\ProductView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxSale;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Windows\ProductView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockUserFullName;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Windows\ProductView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockUserRole;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Windows\ProductView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBockNowCountProduct;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Windows\ProductView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBockCountProduct;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Windows\ProductView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBoxProduct;
        
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
            System.Uri resourceLocater = new System.Uri("/DemoTooooop;component/windows/productview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\ProductView.xaml"
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
            
            #line 8 "..\..\..\Windows\ProductView.xaml"
            ((DemoTooooop.ProductView)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Window_IsVisibleChanged);
            
            #line default
            #line hidden
            
            #line 8 "..\..\..\Windows\ProductView.xaml"
            ((DemoTooooop.ProductView)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ButtonMainWindow = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.ButtonAddProduct = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Windows\ProductView.xaml"
            this.ButtonAddProduct.Click += new System.Windows.RoutedEventHandler(this.ButtonAddProduct_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonEditProduct = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Windows\ProductView.xaml"
            this.ButtonEditProduct.Click += new System.Windows.RoutedEventHandler(this.ButtonEditProduct_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButtonRemoveProduct = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Windows\ProductView.xaml"
            this.ButtonRemoveProduct.Click += new System.Windows.RoutedEventHandler(this.ButtonRemoveProduct_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TextBoxSearhName = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\..\Windows\ProductView.xaml"
            this.TextBoxSearhName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxSearhName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ComboBoxCost = ((System.Windows.Controls.ComboBox)(target));
            
            #line 35 "..\..\..\Windows\ProductView.xaml"
            this.ComboBoxCost.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxCost_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ComboBoxSale = ((System.Windows.Controls.ComboBox)(target));
            
            #line 40 "..\..\..\Windows\ProductView.xaml"
            this.ComboBoxSale.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxSale_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.TextBlockUserFullName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.TextBlockUserRole = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.TextBockNowCountProduct = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.TextBockCountProduct = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 13:
            this.ListBoxProduct = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

