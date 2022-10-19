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
 
  alter view viewListing as select  username, stockID, c.companyID, companyName, companyType, amount, price from company c join stockListing s on c.companyID = s.companyID join users u on s.userID = u.userID
  select*from viewListing 
  
alter view viewAllListing as select  userID, stockID, companyName, companyType, amount, price, status from stockListing s join company c on s.companyID = c.companyID
select *from viewAllListing
create table offer(
	offerID int primary key identity(1,1),
	offeringUserID int FOREIGN KEY References Users(userID),
	sellerUserID int FOREIGN KEY References Users(userID),
	stockID int FOREIGN KEY References stockListing(stockID),
	offerAmount money NOT NULL,
	offerStatus varchar(30) default 'pending'
);
alter view viewOffers as select companyName, companyType, amount, price as askingPrice, offeramount, offerstatus, offerID, offeringUserid, selleruserID, s.stockID from offer o join stockListing s on o.stockID = s.stockID join company c on c.companyID = s.companyID
select *from viewOffers where selleruserId = 2 and offerstatus = 'pending'
create table orders(
	orderID int primary key identity(1,1),
	orderingUserID int FOREIGN KEY References Users(userID),
	selleruserID int FOREIGN KEY References Users(userID),
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

create proc updateStock
@stockID int, @amount money, @price money
as
begin
	update stockListing set amount = @amount, price = @price where stockID = @stockID
end
	
create proc updateCompany
@companyID int, @companyName varchar(30),@companyType varchar(30)
as
begin
	update Company set companyName = @companyName, companyType= @companyType where companyID = @companyID
end

create proc deleteStock
@stockID int
as
begin
	delete from stockListing where stockID = @stockID
end
	
create proc deleteCompany
@companyID int
as
begin
	delete from Company where companyID = @companyID
end


alter proc addOffer
@offeringID int, @sellerID int, @stockID int,@offerAmount money
as
begin
   declare @balance money 
	select @balance = balance from users where userID = @offeringID

   if @balance < @offerAmount
		Raiserror('Error: Insufficient Balance!',11,1)
   
   else
	 insert into offer(offeringUserID, sellerUserID, stockID,offerAmount) values(@offeringID, @sellerID, @stockID,@offerAmount)
end


alter proc addOrder
@orderingID int, @sellerID int, @stockID int,@orderAmount money, @offerID int
as
begin

   declare @balance money 
	DECLARE @errValue int	
	select @balance = balance from users where userID = @orderingID

   if @balance < @orderAmount
		Raiserror('Error: Buyer has insufficient Balance!',11,1)
    
   else
	begin
	
	begin transaction
		update offer set offerstatus = 'Accepted' where offerID = @offerID
		SET @errValue = @@ERROR
		IF @errValue > 0
			ROLLBACK TRANSACTION
		
		update stockListing set status = 'Sold' where stockID = @stockID
		SET @errValue = @@ERROR
		IF @errValue > 0
			ROLLBACK TRANSACTION
		
		update users set balance-= @orderAmount where userID = @orderingID
		SET @errValue = @@ERROR
		IF @errValue > 0
			ROLLBACK TRANSACTION
		
		update users set balance+= @orderAmount where userID = @sellerID
		SET @errValue = @@ERROR
		IF @errValue > 0
			ROLLBACK TRANSACTION
		insert into orders(orderingUserID, sellerUserID, stockID,orderAmount) values(@orderingID, @sellerID, @stockID,@orderAmount)
		SET @errValue = @@ERROR
		IF @errValue > 0
			ROLLBACK TRANSACTION
	commit transaction
	
	end
end

-------------------------------------------------------------------
use Project

create login UserLogin with password='user'

create user StockUser for login UserLogin

create login AdminLogin with password='admin'

create user AdminUser for login AdminLogin

