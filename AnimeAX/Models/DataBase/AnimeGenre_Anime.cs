//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnimeAX.Models.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class AnimeGenre_Anime
    {
        public int AnimeId { get; set; }
        public int AnimeGenreId { get; set; }
        public int Id { get; set; }
    
        public virtual Anime Anime { get; set; }
        public virtual AnimeGenre AnimeGenre { get; set; }
    }
}