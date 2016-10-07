using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// Database Model connection Line
using Kevin_Bhavin_Gametracker.Models;
using System.Web.ModelBinding;

namespace Kevin_Bhavin_Gametracker
{
    public partial class Services : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // load page first time
            if (!IsPostBack)
            {
                // get Gameweek Data
                this.GetGame();
            }
        }

        private void GetGame()
        {
            // Connect to EF
            using (LeaugeTrackerContext database = new LeaugeTrackerContext())
            {

                // Query Game week tables
                var game = (from allgame in database.Games 
                            join allwinningteam in database.WinningTeams on allgame.winTeamId equals allwinningteam.winTeamId
                                  select new GameViewModel {Game = allgame,WinningTeam = allwinningteam }).ToList();


                // Bind results to page
                GamesGridView.DataSource = game;
                GamesGridView.DataBind();
            }
        }
    }
}