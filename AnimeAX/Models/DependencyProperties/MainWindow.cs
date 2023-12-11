using AnimeAX.Models.DataBase;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace AnimeAX.View.Windows
{
    partial class MainWindow
    {
        public List<AnimeType> AnimeTypes
        {
            get { return (List<AnimeType>)GetValue(AnimeTypesProperty); }
            set { SetValue(AnimeTypesProperty, value); }
        }

        public static readonly DependencyProperty AnimeTypesProperty =
            DependencyProperty.Register("AnimeTypes", typeof(List<AnimeType>), typeof(MainWindow));

        public List<AnimeStatus> AnimeStatuses
        {
            get { return (List<AnimeStatus>)GetValue(AnimeStatusesProperty); }
            set { SetValue(AnimeStatusesProperty, value); }
        }

        public static readonly DependencyProperty AnimeStatusesProperty =
            DependencyProperty.Register("AnimeStatuses", typeof(List<AnimeStatus>), typeof(MainWindow));

        public List<AnimeGenre> AnimeGenres
        {
            get { return (List<AnimeGenre>)GetValue(AnimeGenresProperty); }
            set { SetValue(AnimeGenresProperty, value); }
        }

        public static readonly DependencyProperty AnimeGenresProperty =
            DependencyProperty.Register("AnimeGenres", typeof(List<AnimeGenre>), typeof(MainWindow));

        public ObservableCollection<AnimeGenre> CurrentAnimeGenres
        {
            get { return (ObservableCollection<AnimeGenre>)GetValue(CurrentAnimeGenresProperty); }
            set { SetValue(AnimeGenresProperty, value); }
        }

        public static readonly DependencyProperty CurrentAnimeGenresProperty =
            DependencyProperty.Register("CurrentAnimeGenres", typeof(ObservableCollection<AnimeGenre>), typeof(MainWindow));

        public ObservableCollection<Anime> Animes
        {
            get { return (ObservableCollection<Anime>)GetValue(AnimesProperty); }
            set { SetValue(AnimesProperty, value); }
        }

        public static readonly DependencyProperty AnimesProperty =
            DependencyProperty.Register("Animes", typeof(ObservableCollection<Anime>), typeof(MainWindow));

    }
}
