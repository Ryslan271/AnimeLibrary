﻿#pragma checksum "..\..\..\..\..\View\ForAdmin\Pages\ListAnime.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F8F23D2488C23D2F1988828E040A06736905E8FD2BD1C4A1CA36A2DCF857A9F7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AnimeAX.View.ForAdmin.Pages;
using FontAwesome.WPF;
using FontAwesome.WPF.Converters;
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
using Wpf.Ui;
using Wpf.Ui.Common;
using Wpf.Ui.Controls;
using Wpf.Ui.Controls.Navigation;
using Wpf.Ui.Converters;
using Wpf.Ui.Markup;
using Wpf.Ui.ValidationRules;


namespace AnimeAX.View.ForAdmin.Pages {
    
    
    /// <summary>
    /// ListAnime
    /// </summary>
    public partial class ListAnime : Wpf.Ui.Controls.UiPage, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\..\..\View\ForAdmin\Pages\ListAnime.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox AnimeListBox;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\..\..\View\ForAdmin\Pages\ListAnime.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FontAwesome.WPF.ImageAwesome SearchBtn;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\..\..\..\View\ForAdmin\Pages\ListAnime.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxType;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\..\..\..\View\ForAdmin\Pages\ListAnime.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxStatus;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\..\..\..\View\ForAdmin\Pages\ListAnime.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxGenre;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\..\..\..\View\ForAdmin\Pages\ListAnime.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteAnime;
        
        #line default
        #line hidden
        
        
        #line 197 "..\..\..\..\..\View\ForAdmin\Pages\ListAnime.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddAnime;
        
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
            System.Uri resourceLocater = new System.Uri("/AnimeAX;component/view/foradmin/pages/listanime.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\ForAdmin\Pages\ListAnime.xaml"
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
            this.AnimeListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 37 "..\..\..\..\..\View\ForAdmin\Pages\ListAnime.xaml"
            this.AnimeListBox.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ListBox_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SearchBtn = ((FontAwesome.WPF.ImageAwesome)(target));
            return;
            case 3:
            this.ComboBoxType = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.ComboBoxStatus = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.ComboBoxGenre = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.DeleteAnime = ((System.Windows.Controls.Button)(target));
            
            #line 193 "..\..\..\..\..\View\ForAdmin\Pages\ListAnime.xaml"
            this.DeleteAnime.Click += new System.Windows.RoutedEventHandler(this.DeleteAnime_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.AddAnime = ((System.Windows.Controls.Button)(target));
            
            #line 203 "..\..\..\..\..\View\ForAdmin\Pages\ListAnime.xaml"
            this.AddAnime.Click += new System.Windows.RoutedEventHandler(this.AddNewAnime);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

