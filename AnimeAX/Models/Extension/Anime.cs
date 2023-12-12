using System;
using System.IO;

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
    }
}
