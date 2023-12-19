using AnimeAX.Models.DataBase;
using AnimeAX.View.Windows;
using System;
using System.Linq;
using System.Timers;
using System.Windows;
using System.Windows.Input;
using Wpf.Ui.Controls;

namespace AnimeAX.View.ForClient.Pages
{
    /// <summary>
    /// Логика взаимодействия для ViewAnime.xaml
    /// </summary>
    public partial class ViewAnime : UiPage
    {
        private static Timer _SliderTimer;

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

            _SliderTimer = new Timer(200);
            _SliderTimer.Elapsed += OnTimedEvent;
            _SliderTimer.AutoReset = true;

            InitializeComponent();

            timelineSlider.AddHandler(MouseLeftButtonDownEvent, new MouseButtonEventHandler(Slider_MouseLeftButtonDown), true);
            timelineSlider.AddHandler(MouseLeftButtonUpEvent, new MouseButtonEventHandler(Slider_MouseLeftButtonUp), true);

            string LibsPath = @"CSPlugins/FFmpeg/x86";

            videoPlayer.Init(LibsPath, "UserName", "RegKey");

            videoPlayer.Open(CurrentAnime.VideoFile);


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

        /// <summary>
        /// Stop move the slider when MouseLeftButtonDown.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Slider_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _SliderTimer.Enabled = false;
        }

        /// <summary>
        /// Stop move the slider when MouseDown.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Slider_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //Seek to the position when MouseLeftButtonUp

            int SliderValue = (int)timelineSlider.Value;

            TimeSpan ts = new TimeSpan(0, 0, 0, 0, SliderValue);
            videoPlayer.PositionSet(ts);
            _SliderTimer.Enabled = true;
        }

        private void PlayPlayer(object sender, RoutedEventArgs e)
        {
            _SliderTimer.Enabled = true;
            videoPlayer.Play();

        }

        private void PausePlayer(object sender, RoutedEventArgs e)
        {
            _SliderTimer.Enabled = true;
            videoPlayer.Pause();
        }

        /// <summary>
        /// Timer event of the slider.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            
            Dispatcher.BeginInvoke(new Action(() => { timelineSlider.Value = videoPlayer.PositionGet().TotalMilliseconds; }));
        }

        private void AllAnime(object sender, RoutedEventArgs e)
        {
            videoPlayer.Stop();
            MainWindow.Instance.MainFrame.Navigate(new ListAnime());
        }

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

        /// <summary>
        /// Speed ratio.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void ChangeMediaSpeedRatio(object sender, RoutedPropertyChangedEventArgs<double> args)
        {
            //Set the SpeedRatio
            videoPlayer.SpeedRatio((int)speedRatioSlider.Value);

        }
    }
}
