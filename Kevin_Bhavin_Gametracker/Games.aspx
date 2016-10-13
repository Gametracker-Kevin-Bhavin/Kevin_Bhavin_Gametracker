<%@ Page Title="Games" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Games.aspx.cs" Inherits="Kevin_Bhavin_Gametracker.Services" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="conatainer">
        <div class="row">
            <div class="col-md-offset-3 col-md-6" id="games">
                <h2>Current Week: <asp:Label runat="server" ID="weekno" Text="40"></asp:Label></h2>  
                <asp:Button CssClass="btn-default" text="40" runat="server"  OnClick="week40_Click"/>
                <asp:Button CssClass="btn-default" text="41" runat="server" OnClick="week41_Click"/>
                <asp:Button CssClass="btn-default" text="42" runat="server" OnClick="week42_Click"/>
                <asp:Button CssClass="btn-default" text="43" runat="server" OnClick="week43_Click"/>
                <asp:Button CssClass="btn-default" text="44" runat="server" OnClick="week44_Click"/>
                <asp:Button CssClass="btn-default" text="45" runat="server" OnClick="week45_Click"/>
                <asp:Button CssClass="btn-default" text="46" runat="server" OnClick="week46_Click"/>
            <div class="col-md-12" runat="server">
                <div class="panel panel-default" runat="server">
                    <div class="panel-body" runat="server">
                        <div class="row"  id="gamesdata" runat="server">
                            
                        </div>
                   </div>
               </div>
           </div>
            </div>
           
                <!--
                <asp:Label ID="testlabel" runat="server"></asp:Label>
                <asp:Panel ID="testpanel" runat="server" CssClass="panel panel-default">
                    <div class="panel-heading"><asp:Label ID="testgamename" runat="server" CssClass="h3"></asp:Label></div>
                    <div class="panel-body">
                        <asp:Image ID="testteam1logo" runat="server"/>
                        <h2>VS</h2>
                        <asp:Image ID="testteam2logo" runat="server" />
                        <asp:Label ID="team1name" runat="server" CssClass="h4"></asp:Label><br />
                        Wins:<asp:Label ID="team1wins" runat="server"></asp:Label> &nbsp Loses:<asp:Label ID="team1loses" runat="server"></asp:Label> <br />
                        <asp:Label ID="team2name" runat="server" CssClass="h4"></asp:Label> <br />
                        Wins:<asp:Label ID="team2wins" runat="server"></asp:Label> &nbsp Loses:<asp:Label ID="team2loses" runat="server"></asp:Label>
                     </div>
                </asp:Panel>  
                 <asp:GridView ID="GamesGridView" runat="server" AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField DataField="gameName" HeaderText="Game Name" Visible="true" />
                        <asp:BoundField DataField="winteamId" HeaderText="Winning Team" Visible="true" />
                        <asp:BoundField DataField="loseteamId" HeaderText="Losing Team" Visible="true" />
                    </Columns>
                </asp:GridView>


               Dummy Layout Commented out for reference
                
            </div>
            <div class="col-md-12">
            <div class="panel panel-default">
            <div class="panel-body">
            <div class="row">
                <div class="col-md-2">
                    <div class="panel panel-default">
                        <div class="panel-heading"><h3>Game Name</h3></div>
                        <div class="panel-body">
                            Team 1
                            <img src="Assets/images/kevinlogo.png" />
                            <h3>VS</h3>
                            Team 2
                            <img src="Assets/images/bhavinlogo.png" /> <br />
                            Team 1:<br />
                            Wins:1 Loses: 5 <br />
                            Team 2: <br />
                            Wins 5 Loses 1<br />
                        </div>
                    </div>
                </div>
            </div>
            </div>       
           </div>
           -->
        </div>

        </div>
    </div>
    
</asp:Content>
