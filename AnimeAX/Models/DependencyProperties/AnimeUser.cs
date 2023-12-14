using System.ComponentModel;
using System.Windows;

namespace AnimeAX.View.ForClient.Pages
{
    partial class AnimeUser
    {
        public ICollectionView Animes
        {
            get { return (ICollectionView)GetValue(AnimesProperty); }
            set { SetValue(AnimesProperty, value); }
        }

        public static readonly DependencyProperty AnimesProperty =
            DependencyProperty.Register("Animes", typeof(ICollectionView), typeof(AnimeUser));
    }
}
