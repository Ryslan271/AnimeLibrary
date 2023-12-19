using AnimeAX.View.Windows;
using System.Windows;
using System.Windows.Controls;
using Wpf.Ui.Controls;
using MessageBox = System.Windows.MessageBox;

namespace AnimeAX.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для входа в приложение
    /// </summary>
    public partial class Login : UiPage
    {
        public Login()
            => InitializeComponent();

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            if (LoginBox.Text.Trim() == "" || PasswordBox.Password.Trim() == "")
                return;

            var user = UserSearch(LoginBox.Text.Trim(), PasswordBox.Password.Trim());
            var admin = AdminSearch(LoginBox.Text.Trim(), PasswordBox.Password.Trim());

            if (user != null)
                App.CurrentUser = user;
            else if (admin != null)
                App.Admin = admin;
            else
                MessageBox.Show("Такой пользователь не зарегистрирован");

            if (user != null || admin != null)
            {
                new MainWindow().Show();

                Entrance.Instance.Close();
            }
        }

        private void GoToRegistrationPage_Click(object sender, RoutedEventArgs e)
            => Entrance.Instance.EntranceFrame.Navigate(new Registration());
    }
}
