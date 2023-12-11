using AnimeAX.View.Pages;
using Wpf.Ui.Controls;

namespace AnimeAX.View.Windows
{
    public partial class Entrance : UiWindow
    {
        public static Entrance Instance;
        public Entrance()
        {
            InitializeComponent();

            Instance = this;

            EntranceFrame.Navigate(new Login());
        }
    }
}
