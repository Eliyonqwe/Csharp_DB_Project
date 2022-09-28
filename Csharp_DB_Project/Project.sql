create database Project
use Project

create table admin(
	adminID int primary key identity(1,1),
	username varchar(30) UNIQUE,
	password varchar(30) collate SQL_Latin1_general_cp1_cs_as NOT NULL, -- Makes password column case sensetive
);

create table users(
	userID int primary key identity(1,1),
	firstName varchar(30) NOT NULL,
	lastName varchar(30) NOT NULL,
	username varchar(30) NOT NULL UNIQUE,
	password varchar(30) collate SQL_Latin1_general_cp1_cs_as NOT NULL, -- Makes password column case sensetive
	phoneNumber varchar(15),
	balance money default 0
);

create table stockListing(
	stockID int primary key identity(1,1),
	companyID int FOREIGN KEY References Company(companyID),
	userID int FOREIGN KEY References Users(userID),
	amount money NOT NULL,

);

create table company(
	companyID int primary key identity(1,1),
	companyType varchar(30) NOT NULL,

);

create table offer(
	offerID int primary key identity(1,1),
	userID int FOREIGN KEY References Users(userID),
	stockID int FOREIGN KEY References stockListing(stockID),
	offerAmount money NOT NULL,
);

create table orders(
	orderID int primary key identity(1,1),
	userID int FOREIGN KEY References Users(userID),
	stockID int FOREIGN KEY References stockListing(stockID),
	orderAmount money NOT NULL, 
);

select *from admin
select *from users
select *from stockListing
select *from offer
select *from orders