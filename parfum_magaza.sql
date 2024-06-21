create database parfum_magaza;
use parfum_magaza;

CREATE TABLE Customers (
    CustomerID INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL
);

CREATE TABLE Products (
    ProductID INT AUTO_INCREMENT PRIMARY KEY,
    ProductName VARCHAR(100) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
    Stock INT NOT NULL
);

CREATE TABLE Orders (
    OrderID INT AUTO_INCREMENT PRIMARY KEY,
    CustomerID INT,
    OrderDate DATETIME NOT NULL,
    TotalAmount DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

CREATE TABLE OrderDetails (
    OrderDetailID INT AUTO_INCREMENT PRIMARY KEY,
    OrderID INT,
    ProductID INT,
    Quantity INT NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

INSERT INTO Customers (FirstName, LastName) VALUES
('John', 'Doe'),
('Jane', 'Smith'),
('Michael', 'Johnson'),
('Emily', 'Davis'),
('David', 'Wilson'),
('Sarah', 'Taylor'),
('Daniel', 'Moore'),
('Laura', 'Brown'),
('Robert', 'Anderson'),
('Linda', 'Thomas');

INSERT INTO Products (ProductName, Price, Stock) VALUES
('Parfum A', 50.00, 100),
('Parfum B', 60.00, 80),
('Parfum C', 70.00, 90),
('Parfum D', 80.00, 60),
('Parfum E', 90.00, 70),
('Parfum F', 100.00, 50),
('Parfum G', 110.00, 40),
('Parfum H', 120.00, 30),
('Parfum I', 130.00, 20),
('Parfum J', 140.00, 10);

INSERT INTO Orders (CustomerID, OrderDate, TotalAmount) VALUES
(1, '2023-06-01 10:00:00', 150.00),
(2, '2023-06-02 11:00:00', 100.00),
(3, '2023-06-03 12:00:00', 200.00),
(4, '2023-06-04 13:00:00', 50.00),
(5, '2023-06-05 14:00:00', 300.00),
(6, '2023-06-06 15:00:00', 250.00),
(7, '2023-06-07 16:00:00', 120.00),
(8, '2023-06-08 17:00:00', 220.00),
(9, '2023-06-09 18:00:00', 180.00),
(10, '2023-06-10 19:00:00', 90.00);

INSERT INTO OrderDetails (OrderID, ProductID, Quantity, Price) VALUES
(1, 1, 2, 50.00),
(1, 2, 1, 50.00),
(2, 3, 1, 100.00),
(3, 4, 2, 70.00),
(3, 5, 1, 60.00),
(4, 6, 1, 50.00),
(5, 7, 3, 100.00),
(6, 8, 2, 100.00),
(7, 9, 1, 120.00),
(8, 10, 2, 110.00),
(9, 1, 1, 50.00),
(9, 2, 2, 65.00),
(10, 3, 1, 90.00);