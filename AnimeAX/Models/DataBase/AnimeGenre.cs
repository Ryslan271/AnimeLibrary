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
    
    public partial class AnimeGenre
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AnimeGenre()
        {
            this.Anime = new HashSet<Anime>();
        }
    
        public int Id { get; set; }
        public string Genre { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Anime> Anime { get; set; }
    }
}
