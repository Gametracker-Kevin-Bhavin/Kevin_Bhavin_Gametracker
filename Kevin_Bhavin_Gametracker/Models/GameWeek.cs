namespace Kevin_Bhavin_Gametracker.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GameWeek")]
    public partial class GameWeek
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int weekId { get; set; }

        public int? weekNo { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int gameId { get; set; }

        public virtual Game Game { get; set; }
    }
}
