USE MASTER
CREATE DATABASE PetShopManagement
GO

USE PetShopManagement
GO

CREATE TABLE [Employee]
(
	EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	DateOfBirth DATE NOT NULL,
	Sex NVARCHAR(50) NOT NULL,
	[Address] NVARCHAR(100) NOT NULL,
	Email NVARCHAR(100) NULL,
	Phone NVARCHAR(10) NOT NULL,
	UserName NVARCHAR(50) NULL,
	[Password] NVARCHAR(50) NULL,
	Position NVARCHAR(50) NULL,
)
GO

CREATE TABLE Customer
(
	CustomerID INT IDENTITY(1,1) PRIMARY KEY,
	FullName NVARCHAR(100) NOT NULL,
	DateOfBirth DATE NOT NULL,
	Sex NVARCHAR(50) NOT NULL,
	[Address] NVARCHAR(100) NOT NULL,
	Phone NVARCHAR(10) NOT NULL,
)
GO

CREATE TABLE Category
(
	CategoryID INT IDENTITY(1,1) PRIMARY KEY,
	CategoryName NVARCHAR(100) NOT NULL,
	[Description] NVARCHAR(100),
)
GO

CREATE TABLE Product
(
	ProductID INT IDENTITY(1,1) PRIMARY KEY,
	ProductName NVARCHAR(100) NOT NULL,
	Price BIGINT NOT NULL,
	Size NVARCHAR(50) NOT NULL,
	[Description] NVARCHAR(100),
	[Image] IMAGE,
	CategoryID INT NOT NULL,
	CONSTRAINT fk_Product_Category
	FOREIGN KEY (CategoryID) REFERENCES Category(CategoryID)
)
GO

CREATE TABLE [Order]
(
	OrderID INT IDENTITY(1,1) PRIMARY KEY,
	CreatedDate DATE NOT NULL,
	EmployeeID INT NOT NULL,
	CustomerID INT NOT NULL,
	
	CONSTRAINT fk_Order_Employee
	FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID),
	
	CONSTRAINT fk_Order_Customer
	FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
)
GO

CREATE TABLE [OrderDetail]
(
	OrderDetailID INT IDENTITY(1,1) PRIMARY KEY,
	UnitPrice INT NOT NULL,
	Quantity INT NOT NULL,
	OrderID INT NOT NULL,
	ProductID INT NOT NULL,
	
	CONSTRAINT fk_OrderDetail_Order
	FOREIGN KEY (OrderID) REFERENCES [Order](OrderID),
	
	CONSTRAINT fk_OrderDetail_Product
	FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
)
GO

--Thêm nhân viên
INSERT INTO Employee(FirstName, LastName, DateOfBirth, Sex, [Address], [Email], [Phone])
VALUES ('Quang', 'Tung', '2000-09-20', 'Nam', 'Buon Me Thuot', 'tung12@gmail.com', '0909123099')

INSERT INTO Employee(FirstName, LastName, DateOfBirth, Sex, [Address], [Email], [Phone])
VALUES ('Truc', 'Lam', '2000-09-21', 'Nu', 'Binh Duong', 'lam12@gmail.com', '0909123098')

INSERT INTO Employee(FirstName, LastName, DateOfBirth, Sex, [Address], [Email], [Phone])
VALUES ('Ha', 'Duyen', '2000-09-22', 'Nu', 'Ninh Thuan', 'duyen12@gmail.com', '0909123097')

INSERT INTO Employee(FirstName, LastName, DateOfBirth, Sex, [Address], [Email], [Phone])
VALUES ('Le', 'Ngan', '2000-09-23', 'Nu', 'Long An', 'ngan12@gmail.com', '0909123096')

INSERT INTO Employee(FirstName, LastName, DateOfBirth, Sex, [Address], [Email], [Phone])
VALUES ('Ho', 'Duyen', '2000-09-24', 'Nu', 'Long An', 'duyen12@gmail.com', '0909123095')

INSERT INTO Employee(FirstName, LastName, DateOfBirth, Sex, [Address], [Email], [Phone])
VALUES ('Nguyen', 'An', '1998-05-24', 'Nam', 'Ha Noi', 'an24@gmail.com', '0986498236')

INSERT INTO Employee(FirstName, LastName, DateOfBirth, Sex, [Address], [Email], [Phone])
VALUES ('Tran', 'Tu', '1995-06-30', 'Nu', 'Hai Phong', 'tu.tt06@gmail.com', '0909123095')


--Thêm loại sản phẩm
INSERT INTO [Category]([CategoryName]) VALUES ('Thuc an, Dinh Duong')
INSERT INTO [Category]([CategoryName]) VALUES ('Ve sinh, cham soc')
INSERT INTO [Category]([CategoryName]) VALUES ('Nha, Chuong, Nem')
INSERT INTO [Category]([CategoryName]) VALUES ('Đo dung, phu kien')
INSERT INTO [Category]([CategoryName]) VALUES ('Thuoc')


--Thêm sản phẩm
INSERT INTO [Product]([ProductName],[Price], [Size], [CategoryID]) 
VALUES ('Thuc an ROYAL CANIN', 185000, 'Nho', 1)

INSERT INTO [Product]([ProductName],[Price], [Size], [CategoryID]) 
VALUES ('Banh thuong', 25000, 'Trung', 1)

INSERT INTO [Product]([ProductName],[Price], [Size], [CategoryID]) 
VALUES ('Pate IRIS One', 35000, 'Lon', 1)

INSERT INTO [Product]([ProductName],[Price], [Size], [CategoryID]) 
VALUES ('Clicker huan luyen', 60000, 0, 2)

INSERT INTO [Product]([ProductName],[Price], [Size], [CategoryID]) 
VALUES ('Khan tam', 90000, 0, 2)

INSERT INTO [Product]([ProductName],[Price], [Size], [CategoryID]) 
VALUES ('Cay lan long', 45000, 0, 2)

INSERT INTO [Product]([ProductName],[Price], [Size], [CategoryID]) 
VALUES ('Vong co', 70000, 'Nho', 3)

INSERT INTO [Product]([ProductName],[Price], [Size], [CategoryID]) 
VALUES ('Bang ten', 50000, 'Lon', 3)

INSERT INTO [Product]([ProductName],[Price], [Size], [CategoryID]) 
VALUES ('Xich', 80000, 'Trung', 3)

INSERT INTO [Product]([ProductName],[Price], [Size], [CategoryID]) 
VALUES ('Nha nhua', 1250000, 'Nho', 4)

INSERT INTO [Product]([ProductName],[Price], [Size], [CategoryID]) 
VALUES ('Chuong sat', 500000, 'Lon', 4)

INSERT INTO [Product]([ProductName],[Price], [Size], [CategoryID]) 
VALUES ('Nem', 200000, 'Trung', 4)

INSERT INTO [Product]([ProductName],[Price], [Size], [CategoryID]) 
VALUES ('Thuoc tay giun', 45000, 0, 5)

INSERT INTO [Product]([ProductName],[Price], [Size], [CategoryID]) 
VALUES ('Thuoc tri nam', 155000, 0, 5)

INSERT INTO [Product]([ProductName],[Price], [Size], [CategoryID]) 
VALUES ('Thuoc nho gay', 270000, 0, 5)


--Thêm khách hàng
INSERT INTO [Customer] ([FullName], [DateOfBirth], [Sex], [Address], [Phone])
VALUES ('Nguyen Van Trung', '1990-05-31', 'Nam', 'Quang Ngai', '0938976490')

INSERT INTO [Customer] ([FullName], [DateOfBirth], [Sex], [Address], [Phone])
VALUES ('Nguyen Kim Uyen', '1998-01-12', 'Nu', 'Ha Noi', '0927598471')

INSERT INTO [Customer] ([FullName], [DateOfBirth], [Sex], [Address], [Phone])
VALUES ('Nguyen Minh Hai', '2001-04-25', 'Nam', 'TPHCM', '0938975276')

INSERT INTO [Customer] ([FullName], [DateOfBirth], [Sex], [Address], [Phone])
VALUES ('Nguyen Ngoc Tu', '1993-02-01', 'Nu', 'TPHCM', '098584397')

INSERT INTO [Customer] ([FullName], [DateOfBirth], [Sex], [Address], [Phone])
VALUES ('Tran Kim Thuy', '1989-09-09', 'Nu', 'Long An', '0932695378')

INSERT INTO [Customer] ([FullName], [DateOfBirth], [Sex], [Address], [Phone])
VALUES ('Tran Tuan Loi', '1995-01-23', 'Nam', 'Quan 12', '0865782389')

INSERT INTO [Customer] ([FullName], [DateOfBirth], [Sex], [Address], [Phone])
VALUES ('Le Ngoc Hoa', '1994-11-15', 'Nu', 'Quan 11', '0949176598')

--Thêm đơn hàng
INSERT INTO [Order] ([CreatedDate], [EmployeeID], [CustomerID])
VALUES ('2021-05-31', 1, 5)

INSERT INTO [Order] ([CreatedDate], [EmployeeID], [CustomerID])
VALUES ('2021-06-21', 3, 1)

INSERT INTO [Order] ([CreatedDate], [EmployeeID], [CustomerID])
VALUES ('2020-12-15', 2, 2)

INSERT INTO [Order] ([CreatedDate], [EmployeeID], [CustomerID])
VALUES ('2021-07-01', 4, 7)

INSERT INTO [Order] ([CreatedDate], [EmployeeID], [CustomerID])
VALUES ('2021-07-02', 5, 6)

INSERT INTO [Order] ([CreatedDate], [EmployeeID], [CustomerID])
VALUES ('2021-07-03', 7, 4)

INSERT INTO [Order] ([CreatedDate], [EmployeeID], [CustomerID])
VALUES ('2021-04-25', 6, 3)

--Thêm chi tiết đơn hàng
INSERT INTO [OrderDetail] ([UnitPrice], [Quantity], [OrderID], [ProductID])
VALUES (50000, 2, 1, 2)

INSERT INTO [OrderDetail] ([UnitPrice], [Quantity], [OrderID], [ProductID])
VALUES (60000, 1, 7, 4)

INSERT INTO [OrderDetail] ([UnitPrice], [Quantity], [OrderID], [ProductID])
VALUES (50000, 1, 5, 8)

INSERT INTO [OrderDetail] ([UnitPrice], [Quantity], [OrderID], [ProductID])
VALUES (180000, 2, 3, 5)

INSERT INTO [OrderDetail] ([UnitPrice], [Quantity], [OrderID], [ProductID])
VALUES (1250000, 1, 4, 10)

--Tạo Stored Procedure
CREATE PROC [dbo].[sp_KiemTraSPDonHang] @MaDH int, @MaSP int
as
begin
	SET NOCOUNT ON
	declare @sl int
	select @sl = count(*) from [dbo].[OrderDetail]
	where OrderID=@MaDH and ProductID=@MaSP
	SELECT @sl AS alias
end
GO