using AnimeAX.Models.DataBase;
using System.Collections.Generic;
using System.Windows;

namespace AnimeAX.View.ForClient.Pages
{
    partial class ViewFavoriteAnime
    {
        public IEnumerable<Anime> Favorites
        {
            get { return (IEnumerable<Anime>)GetValue(FavoritesAnimeProperty); }
            set { SetValue(FavoritesAnimeProperty, value); }
        }

        public static readonly DependencyProperty FavoritesAnimeProperty =
            DependencyProperty.Register("Favorites", typeof(IEnumerable<Anime>), typeof(ViewFavoriteAnime));
    }
}
