using AnimeAX.Models.DataBase;
using AnimeAX.View.Windows;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
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
            Animes = new CollectionViewSource { Source = App.Db.AnimeStatusFromUser.Local.Where(s => s.User == App.CurrentUser) }.View;
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
