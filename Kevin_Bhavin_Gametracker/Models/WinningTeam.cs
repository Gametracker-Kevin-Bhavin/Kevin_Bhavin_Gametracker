namespace Kevin_Bhavin_Gametracker.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WinningTeam")]
    public partial class WinningTeam
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WinningTeam()
        {
            Games = new HashSet<Game>();
        }

        [Key]
        public int winTeamId { get; set; }

        public int? teamId { get; set; }

        public int? wins { get; set; }

        public int? loses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Game> Games { get; set; }

        public virtual Team Team { get; set; }
    }
}
