namespace Kevin_Bhavin_Gametracker.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Game")]
    public partial class Game
    {
        public int gameId { get; set; }

        [StringLength(255)]
        public string gameName { get; set; }

        public int? loseTeamId { get; set; }

        public int? winTeamId { get; set; }

        public int? gameweekId { get; set; }

        public virtual LosingTeam LosingTeam { get; set; }

        public virtual WinningTeam WinningTeam { get; set; }

        public virtual GameWeek GameWeek { get; set; }
    }
}
