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
create table company(
	companyID int primary key identity(1,1),
	companyName varchar(30) NOT NULL,
	companyType varchar(30) NOT NULL,
);


create table stockListing(
	stockID int primary key identity(1,1),
	companyID int FOREIGN KEY References Company(companyID),
	userID int FOREIGN KEY References Users(userID),
	amount money NOT NULL,
	price money NOT NULL,
	status varchar(30) default 'Pending',
);
 

--insert into company values('Bank', 'Zemen Bank');

create table offer(
	offerID int primary key identity(1,1),
	userID int FOREIGN KEY References Users(userID),
	stockID int FOREIGN KEY References stockListing(stockID),
	offerAmount money NOT NULL,
	offerStatus varchar(30) default 'pending'
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
select *from company
select *from offer
select *from orders

drop table admin
drop table offer
drop table orders
drop table stockListing
drop table users
drop table company


----------------------------------------------------------------------------------------------------------------------------------
create procedure registerUser
@fname varchar(30), @lname varchar(30), @uname varchar(30), @passwd varchar(30), @phoneno varchar(30), @balance money
as
	insert into users values(@fname,@lname,@uname,@passwd, @phoneno, @balance)

----------------------------------------------------------------------------------------------------------------------------------
create proc viewUser
@username varchar(30)
as
	select *from users where username = @username

----------------------------------------------------------------------------------------------------------------------------------
create proc updateUser
@id int, @fname varchar(30),@lname varchar(30),@uname varchar(30),@password varchar(30),@phone varchar(15)
as
	update users set firstName = @fname, lastName = @lname, username = @uname, password = @password, phoneNumber = @phone where userID = @id

----------------------------------------------------------------------------------------------------------------------------------
create proc updateBalance
@uname varchar(30), @balance money
as
	update users set balance = @balance where username = @uname

----------------------------------------------------------------------------------------------------------------------------------
create proc deleteUser
@id int
as
	delete from users where userId = @id

----------------------------------------------------------------------------------------------------------------------------------

alter proc addCompany
@name varchar(30), @type varchar(30), @companyID int OUTPUT
as
begin
	insert into company values(@name,@type)
	set @companyID = SCOPE_IDENTITY()
end

alter proc addListing
@compID int, @userID int, @amount money,@price money
as
begin
	insert into stockListing values(@compID, @userID, @amount,@price, 'pending')
end
	
create function fetchID(@username varchar(30))
returns int
as
begin
	return (select userid from users where username = @username)
end

select dbo.fetchID('eliyonzm')