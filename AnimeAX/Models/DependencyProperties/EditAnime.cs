using AnimeAX.Models.DataBase;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace AnimeAX.View.ForAdmin.Windows
{
    partial class EditAnime
    {
        public Anime CurrentAnime
        {
            get { return (Anime)GetValue(CurrentAnimeProperty); }
            set { SetValue(CurrentAnimeProperty, value); }
        }

        public static readonly DependencyProperty CurrentAnimeProperty =
            DependencyProperty.Register("CurrentAnime", typeof(Anime), typeof(EditAnime));

        public ObservableCollection<AnimeGenre> AnimeGenres
        {
            get { return (ObservableCollection<AnimeGenre>)GetValue(AnimeGenresProperty); }
            set { SetValue(AnimeGenresProperty, value); }
        }

        public static readonly DependencyProperty AnimeGenresProperty =
            DependencyProperty.Register("AnimeGenres", typeof(ObservableCollection<AnimeGenre>), typeof(EditAnime));

        public ObservableCollection<AnimeGenre> CurrentAnimeGenres
        {
            get { return (ObservableCollection<AnimeGenre>)GetValue(CurrentAnimeGenresProperty); }
            set { SetValue(CurrentAnimeGenresProperty, value); }
        }

        public static readonly DependencyProperty CurrentAnimeGenresProperty =
            DependencyProperty.Register("CurrentAnimeGenres", typeof(ObservableCollection<AnimeGenre>), typeof(EditAnime));

        public ObservableCollection<AnimeType> AnimeTypes
        {
            get { return (ObservableCollection<AnimeType>)GetValue(AnimeTypesProperty); }
            set { SetValue(AnimeTypesProperty, value); }
        }

        public static readonly DependencyProperty AnimeTypesProperty =
            DependencyProperty.Register("AnimeTypes", typeof(ObservableCollection<AnimeType>), typeof(EditAnime));

        public ObservableCollection<AnimeStatus> AnimeStatuses
        {
            get { return (ObservableCollection<AnimeStatus>)GetValue(AnimeStatusesProperty); }
            set { SetValue(AnimeStatusesProperty, value); }
        }

        public static readonly DependencyProperty AnimeStatusesProperty =
            DependencyProperty.Register("AnimeStatuses", typeof(ObservableCollection<AnimeStatus>), typeof(EditAnime));

        public ObservableCollection<AgeLimit> AgeLimets
        {
            get { return (ObservableCollection<AgeLimit>)GetValue(AgeLimetsProperty); }
            set { SetValue(AgeLimetsProperty, value); }
        }

        public static readonly DependencyProperty AgeLimetsProperty =
            DependencyProperty.Register("AgeLimets", typeof(ObservableCollection<AgeLimit>), typeof(EditAnime));
    }
}
