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
        protected int currentweekid = 8;

        protected void Page_Load(object sender, EventArgs e)
        {
            // load page first time
            if (!IsPostBack)
            {
                // get Gameweek Data
                this.GetGame();
            }
        }

        protected void week40_Click(Object sender,
                           EventArgs e)
        {
            weekno.Text = "40";
            this.currentweekid = 8;
            this.GetGame();
        }

        protected void week41_Click(Object sender,
                           EventArgs e)
        {
            weekno.Text = "41";
            this.currentweekid = 9;
            this.GetGame();
        }

        protected void week42_Click(Object sender,
                           EventArgs e)
        {
            weekno.Text = "42";
            this.currentweekid = 10;
            this.GetGame();
        }

        protected void week43_Click(Object sender,
                           EventArgs e)
        {
            weekno.Text = "43";
            this.currentweekid = 11;
            this.GetGame();
        }

        protected void week44_Click(Object sender,
                           EventArgs e)
        {
            weekno.Text = "44";
            this.currentweekid = 12;
            this.GetGame();
        }

        protected void week45_Click(Object sender,
                           EventArgs e)
        {
            weekno.Text = "45";
            this.currentweekid = 13;
            this.GetGame();
        }

        protected void week46_Click(Object sender,
                           EventArgs e)
        {
            weekno.Text = "46";
            this.currentweekid = 14;
            this.GetGame();
        }

        private void GetGame()
        {
            // Connect to EF
            using (LeaugeTrackerContext database = new LeaugeTrackerContext())
            {
                Game newgame = new Game();
                List<Game> gameList = new List<Game>();

                var games = (from allgames in database.Games where currentweekid==allgames.gameweekId
                                select allgames);
                gameList.AddRange(games);



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