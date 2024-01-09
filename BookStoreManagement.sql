create database BookStoreManagement
go
use BookStoreManagement
go

-- Thể loại
create table Category
(
	CategoryID nvarchar(20) not null,
	CategoryName nvarchar(50)
	constraint PK_Category primary key(CategoryID)
)
go

-- Nhà xuất bản
create table Publisher
(
	PublisherID nvarchar(20) not null,
	PublisherName nvarchar(50)
	constraint PK_Publisher primary key(PublisherID)
)
go

-- Sách
create table Book
(
	BookID nvarchar(20) not null,
	BookName nvarchar(50),
	Author nvarchar(50),
	CategoryID nvarchar(20),
	PublisherID nvarchar(20),
	ImportPrice float, -- Đơn giá nhập
	Price float, -- Đơn giá bán
	StoreAmount int, -- Số lượng sách ở cửa hàng 
	StockAmount int, -- Số lượng sách trong kho 
	PublishYear int,
	Description nvarchar(max),
	constraint PK_Book primary key(BookID),
	constraint FK_Book_CategoryID foreign key(CategoryID) references Category(CategoryID),
	constraint FK_Book_PublisherID foreign key(PublisherID) references Publisher(PublisherID)
)
go

-- Chức vụ
create table Role
(
	RoleID nvarchar(20) not null,
	RoleName nvarchar(50),
	constraint PK_Role primary key(RoleID)
)
go

-- Nhân viên
create table Employee 
(
	EmployeeID nvarchar(20) not null,
	FullName nvarchar(50),
	DateOfBirth date,
	Address nvarchar(100),
	Email nvarchar(50),
	PhoneNumber nvarchar(50),
	StartWorkDate date,
	RoleID nvarchar(20),
	Picture varbinary(max)
	constraint PK_Employee primary key(EmployeeID),
	constraint FK_Employee_RoleID foreign key(RoleID) references Role(RoleID)
)
go

-- Tài khoản
create table Account 
(
	AccountID nvarchar(20) not null,
	EmployeeID nvarchar(20),
	Username nvarchar(50),
	Password nvarchar(50),	
	Status int,
	constraint PK_Account primary key(AccountID),
	constraint FK_Account_EmployeeID foreign key(EmployeeID) references Employee(EmployeeID)
)
go

-- Khách hàng
create table Customer 
(
	CustomerID nvarchar(20) not null,
	FullName nvarchar(50),
	Email nvarchar(50),
	PhoneNumber nvarchar(50),
	constraint PK_Customer primary key(CustomerID)
)
go

-- Hóa đơn bán
create table Bill
(
	BillID nvarchar(20) not null,
	EmployeeID nvarchar(20),
	CustomerID nvarchar(20),
	DateBill date,
	TotalBill float, -- Tổng tiền hóa đơn
	constraint PK_Bill primary key(BillID),
	constraint FK_Bill_EmployeeID foreign key(EmployeeID) references Employee(EmployeeID),
	constraint FK_Bill_CustomerID foreign key(CustomerID) references Customer(CustomerID)
)
go

-- Chi tiết Hóa đơn bán
create table BillDetail
(
	BillID nvarchar(20) not null,
	BookID nvarchar(20),
	Price float, -- Đơn giá bán lưu vào Chi tiết hóa đơn bán
	SaleAmount int,
	Discount int,
	TotalCost float  -- Thành tiền từng cuốn
	CONSTRAINT PK_BillDetail PRIMARY KEY(BillID, BookID),
	constraint FK_BillDetail_BillID foreign key(BillID) references Bill(BillID),
	constraint FK_BillDetail_BookID foreign key(BookID) references Book(BookID)
)
go

-- Nhà cung cấp
create table Vendor
(
	VendorID nvarchar(20) not null,
	VendorName nvarchar(50),
	constraint PK_Vendor primary key(VendorID)
)
go

alter table Vendor
add Status int 

-- Hóa đơn nhập
create table BillImport
(
	BillImportID nvarchar(20) not null,
	EmployeeID nvarchar(20),
	DateImport date,
	VendorID nvarchar(20),
	constraint PK_BillImport primary key(BillImportID),
	constraint FK_BillImport_EmployeeID foreign key(EmployeeID) references Employee(EmployeeID),
	constraint FK_BillImport_VendorID foreign key(VendorID) references Vendor(VendorID)
)
go
alter table BillImport
add TotalBillImport float 

-- Chi tiết hóa đơn nhập
create table BillImportDetail
(
	BillImportID nvarchar(20) not null,
	BookID nvarchar(20),
	ImportPrice float, -- Đơn giá nhập lưu vào Chi tiết hóa đơn nhập
	ImportAmount int,
	CONSTRAINT PK_BillImportDetail PRIMARY KEY(BillImportID, BookID),
	constraint FK_BillImportDetail_BillImportID foreign key(BillImportID) references BillImport(BillImportID),
	constraint FK_BillImportDetail_BookID foreign key(BookID) references Book(BookID)
)
go


create table Delivery
(
	DeliveryID nvarchar(20) not null,
	EmployeeID nvarchar(20),
	DateDelivery date
	constraint PK_Delivery primary key(DeliveryID),
	constraint FK_Delivery_EmployeeID foreign key(EmployeeID) references Employee(EmployeeID)
)

create table DeliveryDetail
(
	DeliveryID nvarchar(20) not null,
	BookID nvarchar(20),
	DeliveryAmount int
	CONSTRAINT PK_DeliveryDetail PRIMARY KEY(DeliveryID, BookID),
	constraint FK_DeliveryDetail_BookID foreign key(BookID) references Book(BookID)
)
go


create or alter trigger trigg_Total on BillDetail for insert,delete as
	IF EXISTS(SELECT * FROM inserted)
	begin
		Update Bill
			set TotalBill = ISNULL(TotalBill,0) + 
			(select inserted.TotalCost 
				from inserted inner join Bill on inserted.BillID = Bill.BillID 
				where inserted.BillID = Bill.BillID
			)
			from Bill
			WHERE Bill.BillID IN (
				SELECT DISTINCT BillID
				FROM inserted)
		Update Book
			set Book.StoreAmount = Book.StoreAmount - 
			(select inserted.Amount 
				from inserted inner join Book on inserted.BookID = Book.BookID 
				where inserted.BookID = Book.BookID 
			)
			from Book
			WHERE Book.BookID IN (
				SELECT DISTINCT BookID
				FROM inserted)
	end
	ELSE IF EXISTS(SELECT * FROM deleted)
		begin 
		Update Bill
			set TotalBill = TotalBill -
			(select deleted.TotalCost 
				from deleted inner join Bill on deleted.BillID = Bill.BillID 
				where deleted.BillID = Bill.BillID
			)
			from Bill
			WHERE Bill.BillID IN (
				SELECT DISTINCT BillID
				FROM deleted)
		Update Book
				set Book.StoreAmount = Book.StoreAmount +
					(select deleted.Amount 
						from deleted inner join Book on deleted.BookID = Book.BookID 
						where deleted.BookID = Book.BookID
					)
			from Book
			WHERE Book.BookID IN (
				SELECT DISTINCT BookID
				FROM deleted)
	end
go
create or alter trigger trigg_id on BillDetail for delete as
	begin
		update Bill  
			set Status = 0
		where Bill.BillID not in (Select BillDetail.BillID from BillDetail)
	end
go

	-- Procedure Login
CREATE or alter  PROCEDURE CheckLogin
    @username NVARCHAR(50),
    @password NVARCHAR(max)
AS
BEGIN
    select Employee.RoleID, Account.Status
	from Account
	inner join Employee on Employee.EmployeeID=Account.EmployeeID
	where Account.Username=@username and Account.Password=@password
END
go

create or alter trigger UpdateTotalBillImport
on BillImportDetail
after insert, update, delete 
as
begin
    IF EXISTS (SELECT 1 FROM inserted)
    BEGIN
        UPDATE BillImport
        SET TotalBillImport = (SELECT SUM(ImportPrice * ImportAmount)
                               FROM BillImportDetail
                               WHERE BillImportDetail.BillImportID = BillImport.BillImportID)
        FROM BillImport
        WHERE BillImportID IN (SELECT BillImportID FROM inserted);
    END

    IF EXISTS (SELECT 1 FROM deleted) AND NOT EXISTS (SELECT 1 FROM inserted)
    BEGIN
        UPDATE BillImport
        SET TotalBillImport = (SELECT SUM(ImportPrice * ImportAmount)
                               FROM BillImportDetail
                               WHERE BillImportDetail.BillImportID = BillImport.BillImportID)
        FROM BillImport
        WHERE BillImportID IN (SELECT BillImportID FROM deleted);
    END
end

select months.month as Thang, isnull(sum(TotalBill),0) as Tong 
from (select 1 as month union all 
		select 2 union all
		select 3 union all 
		select 4 union all 
		select 5 union all 
		select 6 union all 
		select 7 union all 
		select 8 union all 
		select 9 union all 
		select 10 union all 
		select 11 union all
		select 12) as months 
left join Bill on months.month = Month(DateBill) 
where status = 1 and year(DateBill) = year(getdate()) 
group by months.month


select Book.BookID, Book.BookName, 
isnull(sum(BillDetail.SaleAmount),0) as N'Tổng số lượng bán',
isnull(sum(BillImportDetail.ImportAmount), 0) as N'Tổng số lượng nhập',
abs(isnull(sum(BillDetail.SaleAmount),0) - isnull(sum(BillImportDetail.ImportAmount),0)) as N'Số lượng tồn',
abs(isnull(sum(BillDetail.SaleAmount),0) - isnull(sum(BillImportDetail.ImportAmount),0)) * isnull(Book.ImportPrice, 0) as N'Trị giá tồn kho' 
from Book 
Left join (select BookID, sum(Amount) as SaleAmount 
from BillDetail 
inner join Bill on BillDetail.BillID=Bill.BillID and year(Bill.DateBill)=2023 
group by BookID) 
BillDetail on Book.BookID = BillDetail.BookID 
Left join (select BookID, sum(ImportAmount) as ImportAmount 
from BillImportDetail 
inner join BillImport on BillImportDetail.BillImportID = BillImport.BillImportID and year(BillImport.DateImport)=2023 
group by BookID) 
BillImportDetail on Book.BookID = BillImportDetail.BookID 
group by Book.BookID, Book.BookName, Book.ImportPrice


