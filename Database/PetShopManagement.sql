USE MASTER
CREATE DATABASE PetShopManagement
GO

USE PetShopManagement
GO

CREATE TABLE Employee
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

--Thêm khách hàng
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

INSERT INTO [Category]([CategoryName]) VALUES ('Thuc an, Dinh Duong')
INSERT INTO [Category]([CategoryName]) VALUES ('Ve sinh, cham soc')
INSERT INTO [Category]([CategoryName]) VALUES ('Nha, Chuong, Nem')
INSERT INTO [Category]([CategoryName]) VALUES ('Đo dung, phu kien')
INSERT INTO [Category]([CategoryName]) VALUES ('Thuoc')

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
VALUES ('Vong co', 70000, 'Nhỏ', 3)

INSERT INTO [Product]([ProductName],[Price], [Size], [CategoryID]) 
VALUES ('Bang ten', 50000, 'Lớn', 3)

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

INSERT INTO [Customer] ([FullName], [DateOfBirth], [Sex], [Address], [Phone])
VALUES ('Nguyen Van Trung', '1990-05-31', 'Nam', 'Quang Ngai', '0938976490')

INSERT INTO [Customer] ([FullName], [DateOfBirth], [Sex], [Address], [Phone])
VALUES ('Nguyen Kim Uyen', '1998-01-12', 'Nu', 'Ha Noi', '0927598471')

INSERT INTO [Customer] ([FullName], [DateOfBirth], [Sex], [Address], [Phone])
VALUES ('Nguyen Minh Hai', '2001-04-25', 'Nam', 'TPHCM', '0938975276')

INSERT INTO [Customer] ([FullName], [DateOfBirth], [Sex], [Address], [Phone])
VALUES ('Nguyen Ngoc Tu', '1993-02-01', 'Nu', 'TPHCM', '098584397')

