using AnimeAX.Models.DataBase;
using AnimeAX.View.Windows;
using System.Linq;
using System.Windows.Input;
using Wpf.Ui.Controls;

namespace AnimeAX.View.ForClient.Pages
{
    /// <summary>
    /// Логика взаимодействия для ViewFavoriteAnime.xaml
    /// </summary>
    public partial class ViewFavoriteAnime : UiPage
    {
        public ViewFavoriteAnime()
        {
            Favorites = App.Db.FavoritesAnime.Local.Where(x => x.User == App.CurrentUser).Select(s => s.Anime);

            InitializeComponent();
        }

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Instance.MainFrame.Navigate(new ViewAnime(AnimeListBox.SelectedItem as Anime));
        }

        private void AllAnime(object sender, System.Windows.RoutedEventArgs e)
            => MainWindow.Instance.MainFrame.Navigate(new ListAnime());
    }
}
