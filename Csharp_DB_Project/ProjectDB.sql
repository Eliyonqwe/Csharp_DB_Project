create database ProjectDB

use ProjectDB

create table Tournaments(
	TournamentID int PRIMARy key identity(1000,1),
	TournamentName varchar(30),
	Type varchar(30),
	Location varchar(30),
	MaxTeams int,
	NumberOfTeams int
);

create table TournamentEnteries(
	EnteriesID int primary key identity(1000,1),
	TournamentID int FOREIGN KEY REFERENCES Tournaments(TournamentID),
	TeamID int FOREIGN KEY REFERENCES Teams(TeamID)
);

create table Prizes(
	PrizeID int primary key identity(1000,1),
	PlaceNumber int ,
	PrizeAmount int
);

create table TournamentPrizes(
	id int primary key identity(1000,1),
	TournamentID int FOREIGN KEY REFERENCES Tournaments(TournamentID),
	PrizeID int FOREIGN KEY REFERENCES Prizes(PrizeID)
);

create table Teams (
	TeamID int primary key identity(1000,1),
	TeamName varchar(30)
);

create table TeamMembers (
	id int primary key identity(1000,1),
	TeamID int FOREIGN KEY REFERENCES Teams(TeamID),
	PlayerID int FOREIGN KEY REFERENCES Players(PlayersID)
);

create table Players (
	PlayersID int primary key identity(1000,1),
	FirstName varchar(30),
	LastName varchar(30),
	Position varchar(30),
);

create table Matchups (
	MatchupID int primary key identity(1000,1),
	WinnerID int FOREIGN KEY REFERENCES Teams(TeamID),
	MatchupRound varchar(30)
);

create table MatchupEntries (
	id int primary key identity(1000,1),
	MatchupID int FOREIGN KEY REFERENCES Matchups(MatchupID),
	ParentMatchupID int FOREIGN KEY REFERENCES Matchups(MatchupID),
	TeamcompetingID int FOREIGN KEY REFERENCES Teams(TeamID),
	Score int 
	);
	
create proc InsertTeam_sp 
@TeamName varchar(30)
as 
begin
	insert into Teams (TeamName) values (@TeamName)
end

create proc UpdateTeam_sp 
@oldTeamName varchar(30),
@NewTeamName varchar(30)

as 
begin
	Update  Teams set TeamName=@NewTeamName where TeamName=@oldTeamName
end

create proc ViewTeam_sp 
as
begin
select * from Teams
end

alter proc DeleteTeam_sp 
@TeamNameToBeDeleted varchar(30)
as
begin

declare @id int,@@errValue int
set @id =(select TeamID from Teams where TeamName=@TeamNameToBeDeleted )

	begin transaction
		Delete MatchupEntries where ParentMatchupID=@id or TeamcompetingID=@id
		Delete Matchups where WinnerID=@id
		Delete TournamentEnteries where TeamID=@id
		delete TeamMembers where TeamID=@id
		Delete Teams where TeamID=@id

		set @@errValue=@@ERROR
		if @@errValue>0
			begin 
			rollback transaction
			print'error'
			end

	commit transaction
end

exec DeleteTeam_sp 'mutd'












insert into Tournament(Name) values('name')
update tournament set name = 'droozzy' where id = 1002
select *from tournament
truncate table tournament
drop table Tournament


insert into tournament()





Create table team(
	teamID int primary key identity(1000,1),
	teamName varchar(30),
	tournamentID int foreign key references tournament(tournamentID),

);

drop table team
select *from team
truncate table team

update team set teamName = 'tate'





























