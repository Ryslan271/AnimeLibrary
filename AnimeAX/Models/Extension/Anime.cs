using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AnimeAX.Models.DataBase
{
    partial class Anime
    {
        public Uri VideoFile
        {
            get
            {
                string tempFilePath = Path.GetTempPath() + Guid.NewGuid().ToString() + ".mp4";
                File.WriteAllBytes(tempFilePath, FileBit);

                return new Uri(tempFilePath);
            }
        }

        public IEnumerable<AnimeGenre> Genres => AnimeGenre_Anime.Select(g => g.AnimeGenre);
    }
}
