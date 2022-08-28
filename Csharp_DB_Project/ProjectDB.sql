create database ProjectDB

use ProjectDB

create table tournament(
	tournamentID int PRIMARy key identity(1000,1),
	name varchar(30),
	type varchar(30) Default 'professional',
	x int default 8,
	location varchar(30) default 'addis ababa',
	gender varchar(30) default 'M'
	
);

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

insert into team values('Alpha Males',1004)
insert into team values('Alpha Males')
insert into team values('Alpha Males')

update team set teamName = 'tate'





























