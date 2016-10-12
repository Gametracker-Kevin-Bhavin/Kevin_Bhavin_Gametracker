using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// Database Model connection Line
using Kevin_Bhavin_Gametracker.Models;
using System.Web.ModelBinding;
using System.Web.UI.HtmlControls;

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
                Game newgame = new Game();
                List<Game> gameList = new List<Game>();
                List<WinningTeam> winteamList = new List<WinningTeam>();
                List<LosingTeam> loseteamList = new List<LosingTeam>();
                List<Team> teamList = new List<Team>();
                List<Team> winteamnamelist = new List<Team>();
                List<Team> loseteamnamelist = new List<Team>();
                int currentweekid = 0;
                var games = (from allgames in database.Games
                                select allgames);
                gameList.AddRange(games);
                // Testing Label
                // testlabel.Text = gameList[0].gameName;
                var winningteam = (from allwinteam in database.WinningTeams
                                   join b in database.Games on allwinteam.winTeamId equals b.winTeamId
                                select allwinteam);
                winteamList.AddRange(winningteam);
                // Testing Label
                // testlabel.Text = winteamList[0].wins.ToString();
                var losingteam = (from allloseteam in database.LosingTeams
                                   join b in database.Games on allloseteam.loseTeamId equals b.loseTeamId
                                   select allloseteam);
                loseteamList.AddRange(losingteam);
                var team = (from allteams in database.Teams
                                   select allteams);
                var winteam = (from allteams in database.Teams
                               join b in database.WinningTeams on allteams.teamId equals b.teamId
                            select allteams);
                winteamnamelist.AddRange(winteam);
                var loseteam = (from allteams in database.Teams
                               join b in database.LosingTeams on allteams.teamId equals b.teamId
                               select allteams);
                loseteamnamelist.AddRange(loseteam);

                foreach (var cgame in gameList)
                {
                    // Define all controls that will be added
                    
                    TableCell td = new TableCell();
                    Panel newgamePanel = new Panel();
                    Label gamenamelabel = new Label();
                    HtmlGenericControl divpanelhead = new HtmlGenericControl("div");
                    HtmlGenericControl divpanelbody = new HtmlGenericControl("div");
                    HtmlGenericControl divmd = new HtmlGenericControl("div");
                    Label winteamname = new Label();
                    Image winteamimage = new Image();
                    Label winteamwins = new Label();
                    Label winteamloses = new Label();
                    Label vssign = new Label();
                    Label loseteamname = new Label();
                    Image loseteamimage = new Image();
                    Label loseteamwins = new Label();
                    Label loseteamloses = new Label();

                    // Let the Panels go side by side
                    divmd.Attributes.Add("class", "col-md-4");

                    // Bootstrap the Panel  
                    newgamePanel.CssClass = "panel panel-default";
                    newgamePanel.Width = 200;

                    // Define Heading Panel
                    gamenamelabel.Text = cgame.gameName;
                    gamenamelabel.CssClass = "h3";

                    // Body Contents definitions

                    // Define winning team name
                    winteamname.Text = cgame.WinningTeam.Team.teamName;
                    winteamname.CssClass = "h4";

                    // Define winning team image
                    winteamimage.ImageUrl = "Assets/images/" + cgame.WinningTeam.Team.teamLogo.ToString();

                    // Define winning team wins
                    winteamwins.Text = "Wins: " + cgame.WinningTeam.wins.ToString();

                    // Define winning team loses
                    winteamloses.Text = "Loses: " + cgame.WinningTeam.loses.ToString();

                    // The VS text
                    vssign.Text = "VS";
                    vssign.CssClass = "h3";

                    // Define losing team name
                    loseteamname.Text = cgame.LosingTeam.Team.teamName;
                    loseteamname.CssClass = "h4";

                    // Define losing team image
                    loseteamimage.ImageUrl = "Assets/images/" + cgame.LosingTeam.Team.teamLogo.ToString();

                    // Define losing team wins
                    loseteamwins.Text = "Wins: " + cgame.LosingTeam.wins.ToString();

                    // Define losing team loses
                    loseteamloses.Text = "Loses: " + cgame.LosingTeam.wins.ToString();


                    // Add a formatting div and add all new controls inside
                    // Heading Div
                    divpanelhead.Attributes.Add("class", "panel-heading");
                    divpanelhead.Controls.Add(gamenamelabel);

                    // Body Div
                    divpanelbody.Attributes.Add("class", "panel-body");
                    divpanelbody.Controls.Add(winteamname);
                    divpanelbody.Controls.Add(winteamimage);
                    divpanelbody.Controls.Add(winteamwins);
                    divpanelbody.Controls.Add(new LiteralControl("<br />"));
                    divpanelbody.Controls.Add(winteamloses);
                    divpanelbody.Controls.Add(new LiteralControl("<br />"));
                    divpanelbody.Controls.Add(vssign);
                    divpanelbody.Controls.Add(new LiteralControl("<br />"));
                    divpanelbody.Controls.Add(loseteamname);
                    divpanelbody.Controls.Add(loseteamimage);
                    divpanelbody.Controls.Add(new LiteralControl("<br />"));
                    divpanelbody.Controls.Add(loseteamwins);
                    divpanelbody.Controls.Add(new LiteralControl("<br />"));
                    divpanelbody.Controls.Add(loseteamloses);


                    // Add all the controls inside the panel
                    newgamePanel.Controls.Add(divpanelhead);
                    newgamePanel.Controls.Add(divpanelbody);

                    // Add the Panel to the md
                    divmd.Controls.Add(newgamePanel);

                    // Add the panel inside the formatted div
                    gamesdata.Controls.Add(divmd);

                }

                /*testgamename.Text = gameList[0].gameName;
                Test panel assignment
                testteam1logo.ImageUrl = "Assets/images/" + winteamnamelist[0].teamLogo;
                testteam2logo.ImageUrl = "Assets/images/" + loseteamnamelist[0].teamLogo;
                team1name.Text = winteamnamelist[0].teamName;
                team1wins.Text = winteamList[0].wins.ToString();
                team1loses.Text = loseteamList[0].loses.ToString();
                team2name.Text = loseteamnamelist[0].teamName;
                team2wins.Text = winteamList[0].wins.ToString();
                team2loses.Text = loseteamList[0].loses.ToString();
                */

                /*GamesGridView.DataSource = games.ToList();
                GamesGridView.DataBind();*/

            }
        }
    }
}