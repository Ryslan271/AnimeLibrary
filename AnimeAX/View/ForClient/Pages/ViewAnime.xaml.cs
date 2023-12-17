using AnimeAX.Models.DataBase;
using AnimeAX.View.Windows;
using System.Linq;
using System.Windows;
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

            AnimeStatus = App.Db.Status.Local;

            if (App.Db.FavoritesAnime.Local.FirstOrDefault(a => a.User == App.CurrentUser && a.Anime == CurrentAnime) == null)
            {
                VisibilityStarOutlineContentBtn = Visibility.Visible;
                VisibilityStartContentBtn = Visibility.Hidden;
            }
            else
            {
                VisibilityStarOutlineContentBtn = Visibility.Hidden;
                VisibilityStartContentBtn = Visibility.Visible;
            }

            InitializeComponent();

            ComboBoxStatus.SelectionChanged += (e, sender) =>
            {
                AddNewAnimeStatusFromUser();
            };
        }

        private void AddNewAnimeStatusFromUser()
        {
            if (ComboBoxStatus.SelectedItem == null)
                return;

            var statusAnime = App.Db.AnimeStatusFromUser.Local.FirstOrDefault(s => s.User == App.CurrentUser && s.Anime == CurrentAnime);

            if (statusAnime != null)
            {
                statusAnime.Status = ComboBoxStatus.SelectedItem as Status;
                App.Db.SaveChanges();
                return;
            }

            App.Db.AnimeStatusFromUser.Local.Add(new AnimeStatusFromUser()
            {
                Anime = CurrentAnime,
                Status = ComboBoxStatus.SelectedItem as Status,
                User = App.CurrentUser
            });

            App.Db.SaveChanges();
        }

        private void PlayPlayer(object sender, RoutedEventArgs e)
            => mePlayer.Play();

        private void PausePlayer(object sender, RoutedEventArgs e)
            => mePlayer.Pause();

        private void AllAnime(object sender, RoutedEventArgs e)
            => MainWindow.Instance.MainFrame.Navigate(new ListAnime());

        private void AddInFavorites(object sender, RoutedEventArgs e)
        {
            if (App.Db.FavoritesAnime.Local.FirstOrDefault(a => a.User == App.CurrentUser && a.Anime == CurrentAnime) == null)
            {
                VisibilityStarOutlineContentBtn = Visibility.Hidden;
                VisibilityStartContentBtn = Visibility.Visible;

                App.CurrentUser.FavoritesAnime.Add(new FavoritesAnime
                {
                    Anime = CurrentAnime,
                    User = App.CurrentUser
                });
            }
            else 
            {
                VisibilityStarOutlineContentBtn = Visibility.Visible;
                VisibilityStartContentBtn = Visibility.Hidden;

                App.Db.FavoritesAnime.Local.Remove(App.Db.FavoritesAnime.Local.FirstOrDefault(a => a.User == App.CurrentUser && a.Anime == CurrentAnime));
            }
            App.Db.SaveChanges();
        }
    }
}
