create table Teams(
teamId int NOT NULL IDENTITY(1,1),
teamName varchar(255),
teamLogo varchar(255)
primary key (teamId));

create table WinningTeam(
winTeamId int NOT NULL IDENTITY(1,1),
teamId int FOREIGN KEY REFERENCES Teams(teamId),
wins int,
loses int,
primary Key (winTeamId));

create table LosingTeam(
loseTeamId int NOT NULL IDENTITY(1,1),
teamId int FOREIGN KEY REFERENCES Teams(teamId),
wins int,
loses int,
primary Key (loseTeamId));

create table Game(
gameId int NOT NULL IDENTITY(1,1),
gameName varchar(255),
loseTeamId int foreign key references LosingTeam(loseTeamId),
winTeamId int foreign key references WinningTeam(winTeamId)
primary key (gameId));

create table GameWeek(
weekId int NOT NULL IDENTITY(1,1),
weekNo int,
gameId int foreign key references Game(gameId),
primary key (gameId));

insert into Teams values ('Bhavin','bhavinlogo.png');
insert into Teams values ('Kevin','kevinlogo.png');


insert into WinningTeam values (1,2,5);
insert into LosingTeam values (2,4,5);


insert into Game values ('League',1,1);

insert into GameWeek values (40,3);