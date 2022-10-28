create database Project
use Project


create table admin(
	adminID int primary key identity(1,1),
	username varchar(30) UNIQUE,
	password varchar(30) collate SQL_Latin1_general_cp1_cs_as NOT NULL -- Makes password column case sensetive
);

create table users(
	userID int primary key identity(1,1),
	firstName varchar(30) NOT NULL,
	lastName varchar(30) NOT NULL,
	gender varchar(10),	
	username varchar(30) NOT NULL UNIQUE,
	password varchar(30) collate SQL_Latin1_general_cp1_cs_as NOT NULL, -- Makes password column case sensetive
	phoneNumber varchar(15),
	balance money default 0,
	picLocation varchar(30),
	age int check(age>=18)
);
select *from users

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
 
create table offer(
	offerID int primary key identity(1,1),
	offeringUserID int FOREIGN KEY References Users(userID),
	sellerUserID int FOREIGN KEY References Users(userID),
	stockID int FOREIGN KEY References stockListing(stockID),
	offerAmount money NOT NULL,
	offerStatus varchar(30) default 'pending'
);

create table orders(
	orderID int primary key identity(1,1),
	orderingUserID int FOREIGN KEY References Users(userID),
	selleruserID int FOREIGN KEY References Users(userID),
	stockID int FOREIGN KEY References stockListing(stockID),
	orderAmount money NOT NULL, 
);
	
drop table admin
drop table offer
drop table orders
drop table stockListing
drop table users
drop table company

select *from admin
select *from users
select *from stockListing
select *from company
select *from offer
select *from orders

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


--Views

alter view offerData as select  ou.FIrstName+' '+ ou.LastName as Offerer,su.FIrstName+' '+ su.LastName as Offeree, offerID ,offeringUserID, sellerUserID, companyName, companyType, amount, price, offerAmount,offerStatus  from offer o join stockListing s on o.StockID = s.stockID join company c on c.companyID = s.CompanyID join users ou on ou.UserID = o.offeringUserID join users su on su.UserID = o.sellerUserID;
alter view offerList as select offerID ,offeringUserID, companyName, companyType, amount, price, offerAmount,offerStatus from offer o join stockListing s on o.StockID = s.stockID join company c on c.companyID = s.CompanyID;
alter view orderData as select  ou.FIrstName+' '+ ou.LastName as Orderer,su.FIrstName+' '+ su.LastName as Orderee, orderID ,orderingUserID, sellerUserID, companyName, companyType, amount, price, orderAmount  from orders o join stockListing s on o.StockID = s.stockID join company c on c.companyID = s.CompanyID join users ou on ou.UserID = o.orderingUserID join users su on su.UserID = o.sellerUserID;
alter view orderList as select orderinguserID, sellerUserID, companyName, companyType, amount as stockAmount,orderAmount as orderingPrice, orderID from orders o join stockListing s on o.StockID = s.stockID join company c on c.companyID = s.CompanyID;
alter view viewAllListing as select  userID, stockID, companyName, companyType, amount, price, status from stockListing s join company c on s.companyID = c.companyID;
alter view viewListing as select  username, stockID, c.companyID, companyName, companyType, amount, price from company c join stockListing s on c.companyID = s.companyID join users u on s.userID = u.userID;
alter view viewListings as select  username, stockID, c.companyID, companyName, companyType, amount, price,status from company c join stockListing s on c.companyID = s.companyID join users u on s.userID = u.userID;
alter view viewOffers as select companyName, companyType, amount, price as askingPrice, offeramount, offerstatus, offerID, offeringUserid, selleruserID, s.stockID from offer o join stockListing s on o.stockID = s.stockID join company c on c.companyID = s.companyID;


--Procs
-------------------------------------------------------------------------------------------------------------------------------------------
--User Procedures begin
-------------------------------------------------------------------------------------------------------------------------------------------

alter procedure registerUser
@fname varchar(30), @lname varchar(30), @gender varchar(10),@uname varchar(30),@passwd varchar(30), @phoneno varchar(30), @balance money, @imgLocation varchar(30), @dateofBirth date
as
begin
	declare @age int  = (select dbo.getAge(@dateOfBirth))
	insert into users values(@fname,@lname, @gender,@uname,@passwd, @phoneno, @balance, @imgLocation , @age)
end

create proc updateBalance
@uname varchar(30), @balance money
as
	update users set balance = @balance where username = @uname

alter proc updateUser
@id int, @fname varchar(30),@lname varchar(30), @gender varchar(10), @uname varchar(30),@password varchar(30),@phone varchar(15), @age int
as
	update users set firstName = @fname, lastName = @lname, gender = @gender, username = @uname, password = @password, phoneNumber = @phone, age = @age where userID = @id


create procedure viewAllUsers
as
	select *from users
	

create proc viewUser
@username varchar(30)
as
	select *from users where username = @username	
	/*
alter procedure searchUser
@search varchar(30)
as
	select *from users where (concat(firstName, lastName, phoneNumber, username)) like '%'+@search+'%'
	*/
alter proc deleteUser
@id int
as
begin
	declare @errValue int
	begin transaction
	delete from users where userId = @id
	SET @errValue = @@ERROR
		IF @errValue > 0
			ROLLBACK tran
		
	delete from  stockListing where userID = @id
	SET @errValue = @@ERROR
		IF @errValue > 0
			ROLLBACK tran
		
	delete from  offer where offeringUserID = @id or sellerUserID = @id
	SET @errValue = @@ERROR
		IF @errValue > 0
			ROLLBACK tran
		
	commit transaction
end

-------------------------------------------------------------------------------------------------------------------------------------------
--User Procedures end
-------------------------------------------------------------------------------------------------------------------------------------------



-------------------------------------------------------------------------------------------------------------------------------------------
--Company and stockListing Procedures begin
-------------------------------------------------------------------------------------------------------------------------------------------

create proc updateCompany
@companyID int, @companyName varchar(30),@companyType varchar(30)
as
begin
	update Company set companyName = @companyName, companyType= @companyType where companyID = @companyID
end

create proc deleteCompany
@companyID int
as
begin
	delete from Company where companyID = @companyID
end


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

ALTER procedure viewAllListings
as
	select*from viewListings

alter procedure searchListing -- for admin
@search varchar(30)
as
	select *from viewListings where (concat(username,companyName, companyType, status)) like '%'+@search+'%'
	
create procedure searchListings -- for user
@search varchar(30), @userID int
as
	declare @result int
	declare cursor1 READ_ONLY
	for 
	select *from viewAllListing where not userID = @userID and (concat(companyName, companyType)) like '%'+@search+'%' and status = 'pending'
	open cursor1
	fetch next from cursor1 into @result
create proc updateStock
@stockID int, @amount money, @price money
as
begin
	update stockListing set amount = @amount, price = @price where stockID = @stockID
end
	
create proc deleteStock
@stockID int
as
begin
	delete from stockListing where stockID = @stockID
end

-------------------------------------------------------------------------------------------------------------------------------------------
--Company and stockListing Procedures end
-------------------------------------------------------------------------------------------------------------------------------------------



-------------------------------------------------------------------------------------------------------------------------------------------
--Offer procedures begin
-------------------------------------------------------------------------------------------------------------------------------------------

alter proc addOffer
@offeringID int, @sellerID int, @stockID int,@offerAmount money
as
begin
	 insert into offer(offeringUserID, sellerUserID, stockID,offerAmount) values(@offeringID, @sellerID, @stockID,@offerAmount)
end
/*
create procedure searchOffersForAdmin
@search varchar(30)
as
	select *from offerData where (concat(offerer,offeree, companyName, companyType, offerStatus)) like '%'+@search+'%' 
*/
create proc searchofferforuser
@search varchar(30),@userID int
as
	select offerID,companyName, companyType, amount, price, offerAmount, offerStatus from offerList where not offerStatus='accepted' and offeringUserID = @userID and (concat(companyName, companyType)) like '%'+@search+'%' 

alter procedure viewOffersForAdmin
as
	select *from offerData
	
alter proc viewSentOffer
@userID int
as
	select offerID,companyName, companyType, amount, price, offerAmount, offerStatus from offerList where not offerStatus='accepted' and offeringUserID = @userID

	select *from offer
	select *from users
alter proc updateOffer
@offerID int, @userID int, @offerAmount money
as
begin
	 update offer set offerAmount= @offerAmount where offerID = @offerID
end

alter proc deleteOffer
@offerID int
as
begin
	 delete from offer where offerID = @offerID
end

-------------------------------------------------------------------------------------------------------------------------------------------
--Offer procedures end
-------------------------------------------------------------------------------------------------------------------------------------------




-------------------------------------------------------------------------------------------------------------------------------------------
--Order procedures Begin
-------------------------------------------------------------------------------------------------------------------------------------------


alter proc addOrder
@orderingID int, @sellerID int, @stockID int,@orderAmount money, @offerID int
as
begin
	DECLARE @errValue int	
    begin transaction
		insert into orders(orderingUserID, sellerUserID, stockID,orderAmount) values(@orderingID, @sellerID, @stockID,@orderAmount)
		SET @errValue = @@ERROR
		IF @errValue > 0
			ROLLBACK TRANSACTION
		
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
		
	commit transaction
	
	--end
end

alter proc viewMyOrder
@userID int
as
	select * from orderList where orderingUserID = @userID
	
create proc searchMyOrder
@userID int, @search varchar(30)
as
	select * from orderList where orderingUserID = @userID and (concat(companyName,companytype)) like '%'+@search+'%'

create proc viewRecievedOrder
@userID int
as
	select * from orderList where sellerUserID = @userID
	
create proc searchrecievedOrder
@userID int, @search varchar(30)
as
	select * from orderList where sellerUserID = @userID and (concat(companyName,companytype)) like '%'+@search+'%'
	
	
alter proc cancelOrder
@orderID int, @sellerID int, @buyerID int
as
begin
	DECLARE @errValue int
	declare @amount money 
	select @amount = orderamount from orders where selleruserID = @sellerID

	BEGIN tran
		update users set balance += @amount  where userID = @buyerID
		SET @errValue = @@ERROR
		IF @errValue > 0
			ROLLBACK tran
		
		update users set balance -= @amount  where userID = @sellerID
		SET @errValue = @@ERROR
		IF @errValue > 0
			ROLLBACK tran
		
		delete from orders where orderID = @orderID
		SET @errValue = @@ERROR
		IF @errValue > 0
			ROLLBACK tran
	commit tran
	
end


alter procedure viewOrdersForAdmin
as
	select *from orderData


	/*
create procedure searchOrdersForAdmin
@search varchar(30)
as
	select *from orderData where (concat(orderer,orderee, companyName, companyType)) like '%'+@search+'%' 
	*/

-------------------------------------------------------------------------------------------------------------------------------------------
--Order procedures end
-------------------------------------------------------------------------------------------------------------------------------------------




----------------------------------------------------------------------------------------------------------------------------------
--Functions
----------------------------------------------------------------------------------------------------------------------------------
alter function getAge ( @dateOfbirth date)
returns int
as
begin
	declare @age int
	set @age = DATEDIFF(YEAR, @dateOfBirth, GETDATE()) -
			  CASE
				WHEN ( MONTH(@dateOfBirth) > MONTH(GETDATE()) ) OR (MONTH(@dateOfBirth) = MONTH(GETDATE()) AND DAY(@dateOfBirth) > DAY(GETDATE()))
					THEN 1
				ELSE 0
	end
	return @age
end

create function fetchID(@username varchar(30))
returns int
as
begin
	return (select userid from users where username = @username)
end

create function searchListing(@search varchar(30))
returns table
as
return
(
	select *from viewListings where (concat(username,companyName, companyType, status)) like '%'+@search+'%'
)

alter function searchOffersForAdmin(@search varchar(30))
returns table
as
return
(
	select *from offerData where (concat(offerer,offeree, companyName, companyType, offerStatus)) like '%'+@search+'%' 
)

alter function searchOrdersForAdmin(@search varchar(30))
returns table
as
return
(
	select *from orderData where (concat(orderer,orderee, companyName, companyType)) like '%'+@search+'%' 
)

create function searchUser(@search varchar(30))
returns table
as
return
(
	select *from users where (concat(firstName, lastName, phoneNumber, username)) like '%'+@search+'%'	
)



------------------------------------------------------------------------------------------------------------------------------
--Triggers
------------------------------------------------------------------------------------------------------------------------------

create trigger trgDenyAccessToAdminTable
on admin
for insert, update, delete
as
begin
	declare @currentUser varchar(30) = SUSER_NAME()
	if @currentUser =  'userlogin'
	begin
		Print 'User cant access admin table'
		ROLLBACK TRANSACTION
	end
end

create trigger trgCheckBalanceForOffer
on offer
for insert, update
as
begin
	declare @balance money, @offerAmount money, @offeringID int
	set @offeringID = (select offeringUserID from inserted)
	set @offerAmount = (select offerAmount from inserted)
	select @balance = balance from users where userID = @offeringID

	if @balance < @offerAmount
	begin
		Raiserror('Error: Insufficient Balance!',11,1)
		rollback transaction
	end
end

alter trigger trgCheckGender
on users
for insert, update
as
begin
	declare @gender varchar(10) = (select gender from inserted)
	
	if @gender != 'male' and @gender != 'female'
	begin
		raiserror('Error! Invalid Gender',11,1)
		rollback transaction
	end
end


alter trigger trgCheckBalanceForOrder
on orders
for insert, update
as
begin
	declare @balance money, @orderAmount money, @orderingID int
	set @orderingID = (select orderingUserID from inserted)
	set @orderAmount = (select orderAmount from inserted)
	select @balance = balance from users where userID = @orderingID
	
	if @balance < @orderAmount
	begin
		Raiserror('Error: Buyer has insufficient Balance!',11,1)
		rollback transaction
	end
end





-------------------------------------------------------------------
use Project

create login UserLogin with password='user'

create user StockUser for login UserLogin

create login AdminLogin with password='admin'

create user AdminUser for login AdminLogin

