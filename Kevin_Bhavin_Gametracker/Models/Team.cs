namespace Kevin_Bhavin_Gametracker.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Team
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Team()
        {
            LosingTeams = new HashSet<LosingTeam>();
            WinningTeams = new HashSet<WinningTeam>();
        }

        public int teamId { get; set; }

        [StringLength(255)]
        public string teamName { get; set; }

        [StringLength(255)]
        public string teamLogo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LosingTeam> LosingTeams { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WinningTeam> WinningTeams { get; set; }
    }
}
