using AnimeAX.Models.DataBase;
using AnimeAX.View.ForAdmin.Windows;
using AnimeAX.View.Windows;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using Wpf.Ui.Controls;

namespace AnimeAX.View.ForClient.Pages
{
    public partial class ListAnime : UiPage
    {
        public static ListAnime Instance;
        public ListAnime()
        {
            Animes = new CollectionViewSource { Source = App.Db.Anime.Local }.View;

            AnimeGenres = new ObservableCollection<AnimeGenre> (App.Db.AnimeGenre.Local);
            AnimeStatuses = new ObservableCollection<AnimeStatus>(App.Db.AnimeStatus.Local);
            AnimeTypes = new ObservableCollection<AnimeType>(App.Db.AnimeType.Local);

            AnimeGenres.Insert(0, new AnimeGenre() { Id = 0, Genre = "Все" });
            AnimeStatuses.Insert(0, new AnimeStatus() { Id = 0, Status = "Все" });
            AnimeTypes.Insert(0, new AnimeType() { Id = 0, Type = "Все" });

            InitializeComponent();

            ComboBoxType.SelectionChanged += (e, sender) =>
            {
                if (ComboBoxType.SelectedItem != null)
                    FilterAnimeDefault((ComboBoxType.SelectedItem as AnimeType).Type);
            };

            ComboBoxGenre.SelectionChanged += (e, sender) =>
            {
                if (ComboBoxGenre.SelectedItem != null)
                    FilterAnimeDefault((ComboBoxGenre.SelectedItem as AnimeGenre).Genre);
            };

            ComboBoxStatus.SelectionChanged += (e, sender) =>
            {
                if (ComboBoxStatus.SelectedItem != null)
                    FilterAnimeDefault((ComboBoxStatus.SelectedItem as AnimeStatus).Status);
            };

            Instance = this;
        }

        #region Фильтрация 

        private void FilterAnimeDefault(string tag)
        {
            Animes.Filter = (obj) =>
            {
                var anime = obj as Anime;

                if (anime.AnimeStatus.Status.Contains(tag) == false ||
                    anime.AnimeType.Type.Contains(tag) == false ||
                    App.Db.AnimeGenre_Anime.Local.Where(a => a.Anime == anime).Select(s => s.AnimeGenre).Select(g => g.Genre).Contains(tag) == false)
                    return false;

                return true;
            };
        }
        #endregion

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Instance.MainFrame.Navigate(new ViewAnime(AnimeListBox.SelectedItem as Anime));
        }

        private void ViewFavorities(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.MainFrame.Navigate(new ViewFavoriteAnime());
        }

        private void UserAnimes(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.MainFrame.Navigate(new AnimeUser());
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            App.CurrentUser = null;
            new Entrance().Show();
            MainWindow.Instance.Close();
        }
    }
}
