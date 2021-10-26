create DATABASE CaPheMng
USE CaPheMng
GO





CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,	
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	--Type INT NOT NULL  DEFAULT 0 -- 1: admin && 0: staff
)
GO

CREATE TABLE FoodCategory
(
	idCategory INT IDENTITY(1,1) PRIMARY KEY,
	nameCategory NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

CREATE TABLE Food
(
	idFood INT IDENTITY(1,1) PRIMARY KEY,
	nameFood NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0
	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(idCategory)
)
GO
CREATE TABLE NHANVIEN
(

	idNV nvarchar(50)  PRIMARY KEY,
	Ten nvarchar(150) not null,
	sdt int not null ,
	diachi nvarchar(250) not null,
	
	--status INT NOT NULL DEFAULT 0 -- 1: đã thanh toán && 0: chưa thanh toán	
)
CREATE TABLE Bill
(
	idBill INT IDENTITY(1,1) PRIMARY KEY,
	DateIn DATE NOT NULL DEFAULT GETDATE(),
	--idNV INT  NOT NULL,
	idFood INT NOT NULL,
	idNV nvarchar(50) not null ,
	TongTien float,
	 
	FOREIGN KEY (idNV) REFERENCES dbo.NHANVIEN(idNV),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(idFood)
	--status INT NOT NULL DEFAULT 0 -- 1: đã thanh toán && 0: chưa thanh toán	
)

CREATE TABLE BillinFo
(
	idBillinFo INT IDENTITY(1,1) PRIMARY KEY,
	idBill INT Not null,
	
	idFood INT NOT NULL,
	SL int not null,
		 
	ThanhTien float,
	FOREIGN KEY (idFood) REFERENCES dbo.Food(idFood),
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(idBill)
	--status INT NOT NULL DEFAULT 0 -- 1: đã thanh toán && 0: chưa thanh toán	
)

GO



