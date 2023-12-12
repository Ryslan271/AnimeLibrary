using AnimeAX.Models.DataBase;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

#region список Dependency Property для списка аниме клиента
namespace AnimeAX.View.ForClient.Pages
{
    partial class ListAnime
    {
        public List<AnimeType> AnimeTypes
        {
            get { return (List<AnimeType>)GetValue(AnimeTypesProperty); }
            set { SetValue(AnimeTypesProperty, value); }
        }

        public static readonly DependencyProperty AnimeTypesProperty =
            DependencyProperty.Register("AnimeTypes", typeof(List<AnimeType>), typeof(ListAnime));

        public List<AnimeStatus> AnimeStatuses
        {
            get { return (List<AnimeStatus>)GetValue(AnimeStatusesProperty); }
            set { SetValue(AnimeStatusesProperty, value); }
        }

        public static readonly DependencyProperty AnimeStatusesProperty =
            DependencyProperty.Register("AnimeStatuses", typeof(List<AnimeStatus>), typeof(ListAnime));

        public List<AnimeGenre> AnimeGenres
        {
            get { return (List<AnimeGenre>)GetValue(AnimeGenresProperty); }
            set { SetValue(AnimeGenresProperty, value); }
        }

        public static readonly DependencyProperty AnimeGenresProperty =
            DependencyProperty.Register("AnimeGenres", typeof(List<AnimeGenre>), typeof(ListAnime));

        public ObservableCollection<AnimeGenre> CurrentAnimeGenres
        {
            get { return (ObservableCollection<AnimeGenre>)GetValue(CurrentAnimeGenresProperty); }
            set { SetValue(AnimeGenresProperty, value); }
        }

        public static readonly DependencyProperty CurrentAnimeGenresProperty =
            DependencyProperty.Register("CurrentAnimeGenres", typeof(ObservableCollection<AnimeGenre>), typeof(ListAnime));

        public ObservableCollection<Anime> Animes
        {
            get { return (ObservableCollection<Anime>)GetValue(AnimesProperty); }
            set { SetValue(AnimesProperty, value); }
        }

        public static readonly DependencyProperty AnimesProperty =
            DependencyProperty.Register("Animes", typeof(ObservableCollection<Anime>), typeof(ListAnime));
    }
}
#endregion

#region список Dependency Property для списка аниме администратора
namespace AnimeAX.View.ForAdmin.Pages
{
    partial class ListAnime
    {
        public List<AnimeType> AnimeTypes
        {
            get { return (List<AnimeType>)GetValue(AnimeTypesProperty); }
            set { SetValue(AnimeTypesProperty, value); }
        }

        public static readonly DependencyProperty AnimeTypesProperty =
            DependencyProperty.Register("AnimeTypes", typeof(List<AnimeType>), typeof(ListAnime));

        public List<AnimeStatus> AnimeStatuses
        {
            get { return (List<AnimeStatus>)GetValue(AnimeStatusesProperty); }
            set { SetValue(AnimeStatusesProperty, value); }
        }

        public static readonly DependencyProperty AnimeStatusesProperty =
            DependencyProperty.Register("AnimeStatuses", typeof(List<AnimeStatus>), typeof(ListAnime));

        public List<AnimeGenre> AnimeGenres
        {
            get { return (List<AnimeGenre>)GetValue(AnimeGenresProperty); }
            set { SetValue(AnimeGenresProperty, value); }
        }

        public static readonly DependencyProperty AnimeGenresProperty =
            DependencyProperty.Register("AnimeGenres", typeof(List<AnimeGenre>), typeof(ListAnime));

        public ObservableCollection<AnimeGenre> CurrentAnimeGenres
        {
            get { return (ObservableCollection<AnimeGenre>)GetValue(CurrentAnimeGenresProperty); }
            set { SetValue(AnimeGenresProperty, value); }
        }

        public static readonly DependencyProperty CurrentAnimeGenresProperty =
            DependencyProperty.Register("CurrentAnimeGenres", typeof(ObservableCollection<AnimeGenre>), typeof(ListAnime));

        public ObservableCollection<Anime> Animes
        {
            get { return (ObservableCollection<Anime>)GetValue(AnimesProperty); }
            set { SetValue(AnimesProperty, value); }
        }

        public static readonly DependencyProperty AnimesProperty =
            DependencyProperty.Register("Animes", typeof(ObservableCollection<Anime>), typeof(ListAnime));
    }
}
#endregion
