using AnimeAX.View.ForClient.Pages;
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

            MainFrame.Navigate(new ListAnime());
        }
    }
}
