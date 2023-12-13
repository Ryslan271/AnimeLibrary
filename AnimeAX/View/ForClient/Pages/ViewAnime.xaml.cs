using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AnimeAX.Models.DataBase;
using AnimeAX.View.Windows;
using Wpf.Ui.Controls;

namespace AnimeAX.View.ForClient.Pages
{
    /// <summary>
    /// Логика взаимодействия для ViewAnime.xaml
    /// </summary>
    public partial class ViewAnime : UiPage
    {
        public ViewAnime(Anime anime)
        {

            CurrentAnime = anime;

            InitializeComponent();
        }

        private void PlayPlayer(object sender, RoutedEventArgs e)
            => mePlayer.Play();

        private void PausePlayer(object sender, RoutedEventArgs e)
            => mePlayer.Pause();

        private void AllAnime(object sender, RoutedEventArgs e)
            => MainWindow.Instance.MainFrame.Navigate(new ListAnime());

        private void AddInFavorites(object sender, RoutedEventArgs e)
        {
            App.CurrentUser.FavoritesAnime.Add(new FavoritesAnime
            {
                Anime = CurrentAnime,
                User = App.CurrentUser
            });

            App.Db.SaveChanges();
        }
    }
}
