using AnimeAX.Models.DataBase;
using AnimeAX.View.ForAdmin.Windows;
using AnimeAX.View.Windows;
using System;
using System.Collections;
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
using Wpf.Ui.Controls;

namespace AnimeAX.View.ForAdmin.Pages
{
    public partial class ListAnime : UiPage
    {
        public static ListAnime Instance;
        public ListAnime()
        {
            Animes = App.Db.Anime.Local;

            AnimeGenres = App.Db.AnimeGenre.Local;
            AnimeStatuses = App.Db.AnimeStatus.Local;
            AnimeTypes = App.Db.AnimeType.Local;

            InitializeComponent();

            Instance = this;
        }

        private void ComboBoxGenre_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            new EditAnime(AnimeListBox.SelectedItem as Anime).Show();
        }

        private void AddNewAnime(object sender, RoutedEventArgs e)
        {

        }
    }
}
