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
VALUES ('Quang', 'Tùng', '2000-09-20', 'Nam', 'Buôn Mê Thuột', 'tung12@gmail.com', '0909123099')

INSERT INTO Employee(FirstName, LastName, DateOfBirth, Sex, [Address], [Email], [Phone])
VALUES ('Trúc', 'Lâm', '2000-09-21', 'Nữ', 'Bình Dương', 'lam12@gmail.com', '0909123098')

INSERT INTO Employee(FirstName, LastName, DateOfBirth, Sex, [Address], [Email], [Phone])
VALUES ('Hà', 'Duyên', '2000-09-22', 'Nữ', 'Ninh Thuận', 'duyen12@gmail.com', '0909123097')

INSERT INTO Employee(FirstName, LastName, DateOfBirth, Sex, [Address], [Email], [Phone])
VALUES ('Lê', 'Ngân', '2000-09-23', 'Nữ', 'Long An', 'ngan12@gmail.com', '0909123096')

INSERT INTO Employee(FirstName, LastName, DateOfBirth, Sex, [Address], [Email], [Phone])
VALUES ('Hồ', 'Duyên', '2000-09-24', 'Nữ', 'Long An', 'duyen12@gmail.com', '0909123095')

INSERT INTO [Category]([CategoryName]) VALUES ('Thức Ăn, Dinh Dưỡng')
INSERT INTO [Category]([CategoryName]) VALUES ('Vệ sinh, chăm sóc')
INSERT INTO [Category]([CategoryName]) VALUES ('Nhà, Chuồng, Nệm')
INSERT INTO [Category]([CategoryName]) VALUES ('Đồ dùng, phụ kiện')
INSERT INTO [Category]([CategoryName]) VALUES ('Thuốc')

INSERT INTO [Product]([ProductName],[Price], [Size], [CategoryID]) 
VALUES ('Thức ăn ROYAL CANIN', 185000, 'Nhỏ', 1)

INSERT INTO [Product]([ProductName],[Price], [Size], [CategoryID]) 
VALUES ('Bánh thưởng', 25000, 'Trung', 1)

INSERT INTO [Product]([ProductName],[Price], [Size], [CategoryID]) 
VALUES ('Pate IRIS One', 35000, 'Lớn', 1)

INSERT INTO [Product]([ProductName],[Price], [CategoryID]) 
VALUES ('Clicker huấn luyện', 60000, 2)

INSERT INTO [Product]([ProductName],[Price], [CategoryID]) 
VALUES ('Khăn tắm', 90000, 2)

INSERT INTO [Product]([ProductName],[Price], [CategoryID]) 
VALUES ('Cây lăn lông', 45000, 2)

INSERT INTO [Product]([ProductName],[Price], [Size], [CategoryID]) 
VALUES ('Vòng cổ', 70000, 'Nhỏ', 3)

INSERT INTO [Product]([ProductName],[Price], [Size], [CategoryID]) 
VALUES ('Bảng tên', 50000, 'Lớn', 3)

INSERT INTO [Product]([ProductName],[Price], [Size], [CategoryID]) 
VALUES ('Xích', 80000, 'Trung', 3)

INSERT INTO [Product]([ProductName],[Price], [Size], [CategoryID]) 
VALUES ('Nhà nhựa', 1250000, 'Nhỏ', 4)

INSERT INTO [Product]([ProductName],[Price], [Size], [CategoryID]) 
VALUES ('Chuồng sắt', 500000, 'Lớn', 4)

INSERT INTO [Product]([ProductName],[Price], [Size], [CategoryID]) 
VALUES ('Nệm', 200000, 'Trung', 4)

INSERT INTO [Product]([ProductName],[Price], [CategoryID]) 
VALUES ('Thuốc tẩy giun', 45000, 5)

INSERT INTO [Product]([ProductName],[Price], [CategoryID]) 
VALUES ('Thuốc trị nấm', 155000, 5)

INSERT INTO [Product]([ProductName],[Price], [CategoryID]) 
VALUES ('Thuốc nhỏ gáy', 270000, 5)

INSERT INTO [Customer] ([FullName], [DateOfBirth], [Sex], [Address], [Phone])
VALUES ('Nguyen Van Trung', '1990-05-31', 'Nam', 'Quang Ngai', '0938976490')

INSERT INTO [Customer] ([FullName], [DateOfBirth], [Sex], [Address], [Phone])
VALUES ('Nguyen Kim Uyen', '1998-01-12', 'Nu', 'Ha Noi', '0927598471')

INSERT INTO [Customer] ([FullName], [DateOfBirth], [Sex], [Address], [Phone])
VALUES ('Nguyen Minh Hai', '2001-04-25', 'Nam', 'TPHCM', '0938975276')

INSERT INTO [Customer] ([FullName], [DateOfBirth], [Sex], [Address], [Phone])
VALUES ('Nguyen Ngoc Tu', '1993-02-01', 'Nu', 'TPHCM', '098584397')

