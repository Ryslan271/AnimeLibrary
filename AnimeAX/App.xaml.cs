using AnimeAX.Models.DataBase;
using System.Data.Entity;
using System.Windows;

namespace AnimeAX
{
    public partial class App : Application
    {
        public static AnimebdEntities Db = new AnimebdEntities();

        public static User CurrentUser;
        public static Administrator Admin;

        public App()
        {
            Db.Administrator.Load();
            Db.AgeLimit.Load();
            Db.Anime.Load();
            Db.AnimeGenre.Load();
            Db.AnimeStatus.Load();
            Db.AnimeStatusFromUser.Load();
            Db.AnimeType.Load();
            Db.User.Load();
            Db.Status.Load();
            Db.FavoritesAnime.Load();
        }
    }
}
