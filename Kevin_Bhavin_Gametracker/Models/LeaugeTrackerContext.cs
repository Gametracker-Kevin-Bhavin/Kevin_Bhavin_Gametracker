namespace Kevin_Bhavin_Gametracker.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LeaugeTrackerContext : DbContext
    {
        public LeaugeTrackerContext()
            : base("name=LeaugeTrackerContext")
        {
        }

        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<GameWeek> GameWeeks { get; set; }
        public virtual DbSet<LosingTeam> LosingTeams { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<WinningTeam> WinningTeams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>()
                .Property(e => e.gameName)
                .IsUnicode(false);

            modelBuilder.Entity<Game>()
                .HasOptional(e => e.GameWeek)
                .WithRequired(e => e.Game);

            modelBuilder.Entity<Team>()
                .Property(e => e.teamName)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.teamLogo)
                .IsUnicode(false);
        }
    }
}
