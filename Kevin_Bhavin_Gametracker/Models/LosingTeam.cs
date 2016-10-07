namespace Kevin_Bhavin_Gametracker.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LosingTeam")]
    public partial class LosingTeam
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LosingTeam()
        {
            Games = new HashSet<Game>();
        }

        [Key]
        public int loseTeamId { get; set; }

        public int? teamId { get; set; }

        public int? wins { get; set; }

        public int? loses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Game> Games { get; set; }

        public virtual Team Team { get; set; }
    }
}
