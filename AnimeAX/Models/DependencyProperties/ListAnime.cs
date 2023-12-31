﻿using AnimeAX.Models.DataBase;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

#region список Dependency Property для списка аниме клиента
namespace AnimeAX.View.ForClient.Pages
{
    partial class ListAnime
    {
        public ObservableCollection<AnimeType> AnimeTypes
        {
            get { return (ObservableCollection<AnimeType>)GetValue(AnimeTypesProperty); }
            set { SetValue(AnimeTypesProperty, value); }
        }

        public static readonly DependencyProperty AnimeTypesProperty =
            DependencyProperty.Register("AnimeTypes", typeof(ObservableCollection<AnimeType>), typeof(ListAnime));

        public ObservableCollection<AnimeStatus> AnimeStatuses
        {
            get { return (ObservableCollection<AnimeStatus>)GetValue(AnimeStatusesProperty); }
            set { SetValue(AnimeStatusesProperty, value); }
        }

        public static readonly DependencyProperty AnimeStatusesProperty =
            DependencyProperty.Register("AnimeStatuses", typeof(ObservableCollection<AnimeStatus>), typeof(ListAnime));

        public ObservableCollection<AnimeGenre> AnimeGenres
        {
            get { return (ObservableCollection<AnimeGenre>)GetValue(AnimeGenresProperty); }
            set { SetValue(AnimeGenresProperty, value); }
        }

        public static readonly DependencyProperty AnimeGenresProperty =
            DependencyProperty.Register("AnimeGenres", typeof(ObservableCollection<AnimeGenre>), typeof(ListAnime));

        public ObservableCollection<AnimeGenre> CurrentAnimeGenres
        {
            get { return (ObservableCollection<AnimeGenre>)GetValue(CurrentAnimeGenresProperty); }
            set { SetValue(AnimeGenresProperty, value); }
        }

        public static readonly DependencyProperty CurrentAnimeGenresProperty =
            DependencyProperty.Register("CurrentAnimeGenres", typeof(ObservableCollection<AnimeGenre>), typeof(ListAnime));

        public ICollectionView Animes
        {
            get { return (ICollectionView)GetValue(AnimesProperty); }
            set { SetValue(AnimesProperty, value); }
        }

        public static readonly DependencyProperty AnimesProperty =
            DependencyProperty.Register("Animes", typeof(ICollectionView), typeof(ListAnime));
    }
}
#endregion

#region список Dependency Property для списка аниме администратора
namespace AnimeAX.View.ForAdmin.Pages
{
    partial class ListAnime
    {
        public ObservableCollection<AnimeType> AnimeTypes
        {
            get { return (ObservableCollection<AnimeType>)GetValue(AnimeTypesProperty); }
            set { SetValue(AnimeTypesProperty, value); }
        }

        public static readonly DependencyProperty AnimeTypesProperty =
            DependencyProperty.Register("AnimeTypes", typeof(ObservableCollection<AnimeType>), typeof(ListAnime));

        public ObservableCollection<AnimeStatus> AnimeStatuses
        {
            get { return (ObservableCollection<AnimeStatus>)GetValue(AnimeStatusesProperty); }
            set { SetValue(AnimeStatusesProperty, value); }
        }

        public static readonly DependencyProperty AnimeStatusesProperty =
            DependencyProperty.Register("AnimeStatuses", typeof(ObservableCollection<AnimeStatus>), typeof(ListAnime));

        public ObservableCollection<AnimeGenre> AnimeGenres
        {
            get { return (ObservableCollection<AnimeGenre>)GetValue(AnimeGenresProperty); }
            set { SetValue(AnimeGenresProperty, value); }
        }

        public static readonly DependencyProperty AnimeGenresProperty =
            DependencyProperty.Register("AnimeGenres", typeof(ObservableCollection<AnimeGenre>), typeof(ListAnime));

        public ObservableCollection<AnimeGenre> CurrentAnimeGenres
        {
            get { return (ObservableCollection<AnimeGenre>)GetValue(CurrentAnimeGenresProperty); }
            set { SetValue(AnimeGenresProperty, value); }
        }

        public static readonly DependencyProperty CurrentAnimeGenresProperty =
            DependencyProperty.Register("CurrentAnimeGenres", typeof(ObservableCollection<AnimeGenre>), typeof(ListAnime));

        public ICollectionView Animes
        {
            get { return (ICollectionView)GetValue(AnimesProperty); }
            set { SetValue(AnimesProperty, value); }
        }

        public static readonly DependencyProperty AnimesProperty =
            DependencyProperty.Register("Animes", typeof(ICollectionView), typeof(ListAnime));
    }
}
#endregion
