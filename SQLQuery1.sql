Create database StoreX
use StoreX
select * from Employee
select * from Customer
select * from Product
select * from SalesDetails
select * from Sales
select * from Role
-- Role Table
CREATE TABLE Role (
    RoleID INT IDENTITY(1,1) PRIMARY KEY,
    RoleName NVARCHAR(50) NOT NULL UNIQUE
);

-- Employee Table
CREATE TABLE Employee (
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeName NVARCHAR(255) NOT NULL,
    Username NVARCHAR(100) NOT NULL UNIQUE,
    Password NVARCHAR(255) NOT NULL,
    Role NVARCHAR(50) NOT NULL,
    FOREIGN KEY (Role) REFERENCES Role(RoleName)
);

-- Customer Table
CREATE TABLE Customer (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerName NVARCHAR(255) NOT NULL,
    PhoneNumber NVARCHAR(20) NOT NULL UNIQUE,
    Password NVARCHAR(25) NOT NULL
);

-- Product Table
CREATE TABLE Product (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName VARCHAR(255) NOT NULL,
    SellingPrice DECIMAL(10,2) NOT NULL,
    InventoryQuantity INT NOT NULL CHECK (InventoryQuantity >= 0),
    Category NVARCHAR(100) NOT NULL
);

-- Sales Table
CREATE TABLE Sales (
    SalesID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID INT NOT NULL,
    ProductName varchar(200) NOT NULL,
    TotalAmount DECIMAL(10,2) NOT NULL CHECK (TotalAmount >= 0),
    SaleDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
);

-- SalesDetails Table
CREATE TABLE SalesDetails (
    SalesDetailID INT IDENTITY(1,1) PRIMARY KEY,
    SalesID INT NOT NULL,
    ProductName NVARCHAR NOT NULL,
    Quantity INT NOT NULL CHECK (Quantity > 0),
    Price DECIMAL(10,2) NOT NULL CHECK (Price >= 0),
    FOREIGN KEY (SalesID) REFERENCES Sales(SalesID) ON DELETE CASCADE,
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID) ON DELETE CASCADE
);

-- Employee
INSERT INTO Employee (EmployeeName, Role, Username, Password) VALUES
('Black Commander', 'Admin', 'blackcmd', 'black123'),
('White Commander', 'Admin', 'whitecmd', 'white123');
('Emil Alpha', 'Sales', 'emil1', 'emil123'),
('Emil Beta', 'Sales', 'emil2', 'emil123'),
('Emil Gamma', 'Sales', 'emil3', 'emil123'),
('Emil Delta', 'Sales', 'emil4', 'emil123'),
('Emil Epsilon', 'Sales', 'emil5', 'emil123');
('Storage Keeper Alpha', 'warehouse', 'sk_alpha', 'sk123'),
('Storage Keeper Beta', 'warehouse', 'sk_beta', 'sk123'),
('Storage Keeper Gamma', 'warehouse', 'sk_gamma', 'sk123'),
('Storage Keeper Delta', 'warehouse', 'sk_delta', 'sk123'),
('Storage Keeper Epsilon', 'warehouse', 'sk_epsilon', 'sk123');
-- Product
INSERT INTO Product (ProductName, SellingPrice, InventoryQuantity, Category) VALUES
('Yorha A', 100000, 10, 'Android'),
('Yorha B', 100000, 10, 'Android'),
('Yorha C', 100000, 10, 'Android'),
('Yorha D', 100000, 10, 'Android'),
('Yorha E', 100000, 10, 'Android'),
('Yorha F', 100000, 10, 'Android'),
('Yorha G', 100000, 10, 'Android'),
('Yorha H', 100000, 10, 'Android'),
('Yorha I', 100000, 10, 'Android'),
('Yorha J', 100000, 10, 'Android'),
('Yorha K', 100000, 10, 'Android'),
('Yorha L', 100000, 10, 'Android'),
('Yorha M', 100000, 10, 'Android'),
('Yorha N', 100000, 10, 'Android'),
('Yorha O', 100000, 10, 'Android'),
('Yorha P', 100000, 10, 'Android'),
('Yorha Q', 100000, 10, 'Android'),
('Yorha R', 100000, 10, 'Android'),
('Yorha S', 100000, 10, 'Android'),
('Yorha T', 100000, 10, 'Android'),
('Yorha U', 100000, 10, 'Android'),
('Yorha V', 100000, 10, 'Android'),
('Yorha W', 100000, 10, 'Android'),
('Yorha X', 100000, 10, 'Android'),
('Yorha Y', 100000, 10, 'Android'),
('Yorha Z', 100000, 10, 'Android');
-- Part
INSERT INTO Product (ProductName, SellingPrice, InventoryQuantity, Category) VALUES
('Machine Arm Joint', 120000, 15, 'Part'),
('Broken Circuit', 80000, 20, 'Part'),
('Damaged Coil', 90000, 12, 'Part'),
('Power Gear', 110000, 18, 'Part'),
('Small Gear Assembly', 95000, 25, 'Part'),
('Servo Motor Unit', 130000, 10, 'Part'),
('Large Broken Gear', 100000, 14, 'Part'),
('Crumpled Metal Plate', 75000, 22, 'Part'),
('Rusty Bolt Cluster', 85000, 19, 'Part'),
('Core Wiring Bundle', 115000, 13, 'Part');
-- Tool
INSERT INTO Product (ProductName, SellingPrice, InventoryQuantity, Category) VALUES
('Pod Maintenance Kit', 200000, 8, 'Tool'),
('Repair Toolset', 150000, 10, 'Tool'),
('Oil Filter Wrench', 125000, 16, 'Tool'),
('YoRHa Tuning Device', 170000, 7, 'Tool'),
('Laser Calibration Tool', 190000, 5, 'Tool'),
('Pod Programming Key', 210000, 4, 'Tool'),
('Maintenance Drone Chip', 160000, 9, 'Tool'),
('Pod Expansion Mod', 230000, 6, 'Tool'),
('Sensor Debug Stick', 140000, 11, 'Tool'),
('Transmission Jammer', 180000, 8, 'Tool');
-- Chips
INSERT INTO Product (ProductName, SellingPrice, InventoryQuantity, Category) VALUES
('Auto-Heal Chip', 300000, 5, 'Chips'),
('Overclock Chip', 350000, 3, 'Chips'),
('Evade Range Up', 270000, 6, 'Chips'),
('Deadly Heal', 320000, 4, 'Chips'),
('Offensive Heal', 280000, 7, 'Chips'),
('Weapon Attack Up', 290000, 6, 'Chips'),
('Melee Defense Up', 260000, 9, 'Chips'),
('Shockwave', 310000, 3, 'Chips'),
('Anti-Chain Damage', 250000, 8, 'Chips'),
('XP Gain Up', 340000, 2, 'Chips');
-- Hair Dye
INSERT INTO Product (ProductName, SellingPrice, InventoryQuantity, Category)
VALUES 
('Lunar Silver Hair Dye', 250, 30, 'Item'),
('Emil Green Hair Dye', 180, 25, 'Item'),
('YoRHa Black Hair Dye', 200, 40, 'Item'),
('Resistance Red Hair Dye', 220, 20, 'Item');
INSERT INTO Customer (CustomerName, PhoneNumber, Password)
VALUES 
(N'2B', '0909123456', 'YoRHaNo2TypeB'),
(N'9S', '0912345678', 'ScannerUnit9S'),
(N'A2', '0987654321', 'PrototypeA2'),
(N'Pascal', '0933666999', 'PacifistRobot'),
(N'Adam & Eve', '0977123444', 'TwinsFromMachineCore')
INSERT INTO Sales (CustomerID, ProductName, TotalAmount, SaleDate) VALUES
(1, N'Machine Arm Joint', 120000, '2025-04-10'),
(2, N'Broken Circuit', 80000, '2025-04-11'),
(3, N'Damaged Coil', 90000, '2025-04-12'),
(4, N'Power Gear', 110000, '2025-04-13'),
(5, N'Small Gear Assembly', 95000, '2025-04-14');

INSERT INTO Sales (CustomerID, ProductName, TotalAmount, SaleDate) VALUES
(1, N'Machine Arm Joint', 12, '2025-04-10'),
(2, N'Broken Circuit', 80, '2025-04-11'),
(3, N'Damaged Coil', 90, '2025-04-12'),
(4, N'Power Gear', 11, '2025-04-13'),
(5, N'Small Gear Assembly', 95000, '2025-04-14');
DBCC CHECKIDENT ('Sales', RESEED, 0);
DELETE FROM Sales;
sp_help Customer;