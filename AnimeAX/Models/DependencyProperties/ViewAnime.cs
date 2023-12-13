using AnimeAX.Models.DataBase;
using System.Windows;

namespace AnimeAX.View.ForClient.Pages
{
    partial class ViewAnime
    {
        public Anime CurrentAnime
        {
            get { return (Anime)GetValue(CurrentAnimeProperty); }
            set { SetValue(CurrentAnimeProperty, value); }
        }

        public static readonly DependencyProperty CurrentAnimeProperty =
            DependencyProperty.Register("CurrentAnime", typeof(Anime), typeof(ViewAnime));
    }
}
