using AnimeAX.Models.DataBase;
using System.Collections.ObjectModel;
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

        public ObservableCollection<Status> AnimeStatus
        {
            get { return (ObservableCollection<Status>)GetValue(AnimeStatusProperty); }
            set { SetValue(AnimeStatusProperty, value); }
        }

        public static readonly DependencyProperty AnimeStatusProperty =
            DependencyProperty.Register("AnimeStatus", typeof(ObservableCollection<Status>), typeof(ViewAnime));

        public Visibility VisibilityStartContentBtn
        {
            get { return (Visibility)GetValue(VisibilityStartContentBtnProperty); }
            set { SetValue(VisibilityStartContentBtnProperty, value); }
        }

        public static readonly DependencyProperty VisibilityStartContentBtnProperty =
            DependencyProperty.Register("VisibilityStartContentBtn", typeof(Visibility), typeof(ViewAnime));

        public Visibility VisibilityStarOutlineContentBtn
        {
            get { return (Visibility)GetValue(VisibilityStarOutlineContentBtnProperty); }
            set { SetValue(VisibilityStarOutlineContentBtnProperty, value); }
        }

        public static readonly DependencyProperty VisibilityStarOutlineContentBtnProperty =
            DependencyProperty.Register("VisibilityStarOutlineContentBtn", typeof(Visibility), typeof(ViewAnime));
    }
}
