using AnimeAX.View;
using Wpf.Ui.Controls;

namespace AnimeAX.View.Windows
{
    /// <summary>
    /// Основное окно, вывода списка
    /// </summary>
    public partial class MainWindow : UiWindow
    {
        public static MainWindow Instance { get; private set; }

        public MainWindow()
        {
            InitializeComponent();

            Instance = this;

            if (App.CurrentUser != null)
                MainFrame.Navigate(new ForClient.Pages.ListAnime());
            else
                MainFrame.Navigate(new ForAdmin.Pages.ListAnime());
        }
    }
}
