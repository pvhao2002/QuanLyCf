CREATE DATABASE CafeShop
GO

USE CafeShop
GO

--**************************************** CREATE TABLES ****************************************--

-- Food
-- Table
-- FoodCategory
-- Account
-- Bill
-- BillInfo

CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL,
	status NVARCHAR(100) NOT NULL DEFAULT N'Trống' -- Trống / Đã có người
)
GO

CREATE TABLE AccountType
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE Account
(
	username VARCHAR(100) PRIMARY KEY,
	password VARCHAR(1000) NOT NULL DEFAULT 'c4ca4238a0b923820dcc509a6f75849b', -- default password = '1'
	displayName NVARCHAR(100) NOT NULL,
	typeID INT NOT NULL DEFAULT 2, -- 1: Quản trị viên, 2: Nhân viên
	sex NVARCHAR(5) NOT NULL DEFAULT N'Nam', -- Nam / Nữ
	birthday DATE NOT NULL,
	address NVARCHAR(100) NOT NULL,

	FOREIGN KEY(typeID) REFERENCES dbo.AccountType(id)
)
GO

CREATE TABLE State
(
	id INT IDENTITY PRIMARY KEY, -- 1: Sử dụng, 2: Ngưng sử dụng
	name NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL
)
GO

CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL,
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0,
	stateID INT NOT NULL DEFAULT 1,
	
	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id),
	FOREIGN KEY (stateID) REFERENCES dbo.State(id)
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	idTable INT NOT NULL,
	totalPrice FLOAT NOT NULL DEFAULT 0,
	discount INT NOT NULL DEFAULT 0,
	timeIn DATETIME NOT NULL DEFAULT GETDATE(),
	timeOut DATETIME DEFAULT NULL,
	status NVARCHAR(100) NOT NULL DEFAULT N'Chưa thanh toán', -- Đã thanh toán / Chưa thanh toán

	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 1,
	
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
)
GO

--**************************************** END CREATE TABLES ****************************************--


--**************************************** INSERT DATA ****************************************--

INSERT INTO dbo.AccountType
(
    name
)
VALUES
(N'Quản trị viên' -- name - nvarchar(50)
    )
GO

INSERT INTO dbo.AccountType
(
    name
)
VALUES
(N'Nhân viên' -- name - nvarchar(50)
    )
GO    

INSERT INTO dbo.Account
(
    username,
    password,
    displayName,
    typeID,
    sex,
    birthday,
    address
)
VALUES
(   'admin',        -- username - varchar(100)
    'admin',        -- password - varchar(1000) = 'admin'
    N'ADMIN',       -- displayName - nvarchar(100)
    1,         -- type - int
    N'Nam',       -- sex - nvarchar(5)
    '2002-08-23', -- birthday - date
    N'Thủ Đức'        -- address - nvarchar(50)
    )
GO

INSERT INTO dbo.Account
(
    username,
    password,
    displayName,
    typeID,
    sex,
    birthday,
    address
)
VALUES
(   'phamvanhao',        -- username - varchar(100)
    'phamvanhao',        -- password - varchar(1000) = '123'
    N'Phạm Văn Hào',       -- displayName - nvarchar(100)
    2,         -- type - int
    N'Nam',       -- sex - nvarchar(5)
    '2002-08-23', -- birthday - date
    N'Thái Bình'        -- address - nvarchar(50)
    )
GO

INSERT INTO dbo.Account
(
    username,
    password,
    displayName,
    typeID,
    sex,
    birthday,
    address
)
VALUES
(   'nongquanghuy',        -- username - varchar(100)
    'nongquanghuy',        -- password - varchar(1000) = '123'
    N'Nông Quang Huy',       -- displayName - nvarchar(100)
    1,         -- typeID - int
    N'Nam',       -- sex - nvarchar(5)
    '2002-01-01', -- birthday - date
    N'Thủ Đức'        -- address - nvarchar(100)
    )
GO

DECLARE @i INT = 1
WHILE(@i <= 20)
BEGIN
    INSERT INTO dbo.TableFood(name) VALUES (N'Bàn số ' + CAST(@i AS NVARCHAR(3)))
	SELECT @i = @i + 1
END
GO

INSERT INTO dbo.State(name) VALUES(N'Sử dụng')
INSERT INTO dbo.State(name) VALUES(N'Ngưng sử dụng')

INSERT INTO dbo.FoodCategory(name) VALUES(N'Thức ăn')
INSERT INTO dbo.FoodCategory(name) VALUES(N'Thức uống')

INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Bánh mì thịt', -- name - nvarchar(100)
    1,   -- idCategory - int
    20000.0  -- price - float
    )

INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Đen đá không đường ai nấy đi', -- name - nvarchar(100)
    1,   -- idCategory - int
    50000.0  -- price - float
    )

INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Sinh tố bơ deadline đi mà ngủ', -- name - nvarchar(100)
    2,   -- idCategory - int
    15000.0  -- price - float
    )

INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Cafe sữa', -- name - nvarchar(100)
    2,   -- idCategory - int
    20000.0  -- price - float
    )

INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Fanta chả là gì của nhau', -- name - nvarchar(100)
    2,   -- idCategory - int
    30000.0  -- price - float
    )

INSERT INTO dbo.Bill(idTable) VALUES(1)
INSERT INTO dbo.Bill(idTable) VALUES(4)
INSERT INTO dbo.Bill(idTable) VALUES(5)
INSERT INTO dbo.Bill(idTable) VALUES(10)

INSERT INTO dbo.BillInfo
(
    idBill,
    idFood,
    count
)
VALUES
(   1, -- idBill - int
    2, -- idFood - int
    5  -- count - int
    )

INSERT INTO dbo.BillInfo
(
    idBill,
    idFood,
    count
)
VALUES
(   1, -- idBill - int
    4, -- idFood - int
    5  -- count - int
)

INSERT INTO dbo.BillInfo
(
    idBill,
    idFood,
    count
)
VALUES
(   2, -- idBill - int
    1, -- idFood - int
    4  -- count - int
)

INSERT INTO dbo.BillInfo
(
    idBill,
    idFood,
    count
)
VALUES
(   2, -- idBill - int
    3, -- idFood - int
    2  -- count - int
    )

INSERT INTO dbo.BillInfo
(
    idBill,
    idFood,
    count
)
VALUES
(   2, -- idBill - int
    4, -- idFood - int
    2  -- count - int
    )

INSERT INTO dbo.BillInfo
(
    idBill,
    idFood,
    count
)
VALUES
(   3, -- idBill - int
    3, -- idFood - int
    1  -- count - int
    )

INSERT INTO dbo.BillInfo
(
    idBill,
    idFood,
    count
)
VALUES
(   3, -- idBill - int
    4, -- idFood - int
    1  -- count - int
    )

INSERT INTO dbo.BillInfo
(
    idBill,
    idFood,
    count
)
VALUES
(   3, -- idBill - int
    5, -- idFood - int
    1  -- count - int
    )

INSERT INTO dbo.BillInfo
(
    idBill,
    idFood,
    count
)
VALUES
(   4, -- idBill - int
    4, -- idFood - int
    1  -- count - int
    )

UPDATE dbo.TableFood
SET status = N'Đã có người'
WHERE id = 1 OR id = 4 OR id = 5 OR id = 10
GO

--**************************************** END INSERT DATA ****************************************--