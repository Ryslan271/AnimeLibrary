// Updated by XamlIntelliSenseFileGenerator 13.12.2023 19:43:23
#pragma checksum "..\..\..\..\..\View\ForClient\Pages\ViewAnime.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "411DA2AF14E3EA6D6173300CAC49D11AB90F5C8DBDE8DBC7FAEE6CE9FD969E4B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace AnimeAX.View.ForClient.Pages
{


    /// <summary>
    /// ViewAnime
    /// </summary>
    public partial class ViewAnime : Wpf.Ui.Controls.UiPage, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden


#line 45 "..\..\..\..\..\View\ForClient\Pages\ViewAnime.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement mePlayer;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AnimeAX;component/view/forclient/pages/viewanime.xaml", System.UriKind.Relative);

#line 1 "..\..\..\..\..\View\ForClient\Pages\ViewAnime.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 25 "..\..\..\..\..\View\ForClient\Pages\ViewAnime.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AllAnime);

#line default
#line hidden
                    return;
                case 2:

#line 30 "..\..\..\..\..\View\ForClient\Pages\ViewAnime.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddInFavorites);

#line default
#line hidden
                    return;
                case 3:
                    this.Screensaver = ((System.Windows.Controls.Image)(target));
                    return;
                case 4:
                    this.mePlayer = ((System.Windows.Controls.MediaElement)(target));
                    return;
                case 5:

#line 64 "..\..\..\..\..\View\ForClient\Pages\ViewAnime.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.PlayPlayer);

#line default
#line hidden
                    return;
                case 6:

#line 71 "..\..\..\..\..\View\ForClient\Pages\ViewAnime.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.PausePlayer);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

