using AnimeAX.Models.DataBase;
using AnimeAX.View.ForAdmin.Windows;
using AnimeAX.View.Windows;
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

            AnimeGenres = App.Db.AnimeGenre.Local;
            AnimeStatuses = App.Db.AnimeStatus.Local;
            AnimeTypes = App.Db.AnimeType.Local;

            InitializeComponent();

            ComboBoxType.SelectionChanged += (e, sender) =>
            {
                if (ComboBoxType.SelectedItem != null)
                    FilterproductsDefault((ComboBoxType.SelectedItem as AnimeType).Type);
            };

            ComboBoxGenre.SelectionChanged += (e, sender) =>
            {
                if (ComboBoxGenre.SelectedItem != null)
                    FilterproductsDefault((ComboBoxGenre.SelectedItem as AnimeGenre).Genre);
            };

            ComboBoxStatus.SelectionChanged += (e, sender) =>
            {
                if (ComboBoxStatus.SelectedItem != null)
                    FilterproductsDefault((ComboBoxStatus.SelectedItem as AnimeStatus).Status);
            };

            Instance = this;
        }

        #region Фильтрация 

        private void FilterproductsDefault(string tag)
        {
            Animes.Filter = (obj) =>
            {
                var anime = obj as Anime;

                if (anime.AnimeStatus.Status.Contains(tag) == true)
                    return true;
                else if (anime.AnimeType.Type.Contains(tag) == true)
                    return true;
                else if (App.Db.AnimeGenre_Anime.Local.Where(a => a.Anime == anime).Select(s => s.AnimeGenre).Select(g => g.Genre).Contains(tag) == true)
                    return true;

                return false;
            };
        }
        #endregion

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Instance.MainFrame.Navigate(new ViewAnime(AnimeListBox.SelectedItem as Anime));
        }
    }
}
