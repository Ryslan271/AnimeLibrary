using AnimeAX.Models.DataBase;
using AnimeAX.View.Windows;
using MaterialDesignThemes.Wpf;
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
using Wpf.Ui.Controls;

namespace AnimeAX.View.ForClient.Pages
{
    /// <summary>
    /// Логика взаимодействия для AnimeUser.xaml
    /// </summary>
    public partial class AnimeUser : UiPage
    {
        public AnimeUser()
        {
            Animes = new CollectionViewSource { Source = App.Db.AnimeStatusFromUser.Local.Where(s => s.User == App.CurrentUser).Select(a => a.Anime) }.View;
            Animes.GroupDescriptions.Add(new PropertyGroupDescription("AnimeStatusGroup"));

            InitializeComponent();
        }

        private void AllAnime(object sender, RoutedEventArgs e)
            => MainWindow.Instance.MainFrame.Navigate(new ListAnime());

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Instance.MainFrame.Navigate(new ViewAnime(AnimeListBox.SelectedItem as Anime));
        }
    }
}
