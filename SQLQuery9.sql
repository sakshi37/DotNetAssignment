create database BookStoreDB

create table Authors(

AuthorID int primary key not null,
Name varchar(50),
Country varchar(50)

)

create table Books(
bookID int primary key not null,
title varchar(50),
AuthorID int not null,
Price decimal, 
PublishedYear Date,
FOREIGN KEY (AuthorID) REFERENCES Authors(AuthorID)

)

create  table Customer(

CustomerID int primary key not null,
Name varchar(20) not null,
Email varchar(50) not null,
PhoneNumber varchar(20)
)

create table Orders (
OrderID int primary key not null,
CustomerID int,
OrderDate Date, 
TotalAmount decimal,
foreign key(CustomerID) references Customer(CustomerID)
) 

create table OrderItems (
OrderItemID int not null,
OrderID int not null, 
BookID int not null, 
Quantity int, 
SubTotal decimal,
FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
foreign key (BookID) references Books(BookID)
) 

INSERT INTO Authors(AuthorID, Name, Country)
VALUES
(1, 'Sakshi', 'US'),
(2, 'Vaishanavi', 'London'),
(3, 'Akshata', 'Kalyan'),
(4, 'Neha', 'Bhivandi'),
(5, 'Sarthak', 'Kalyan');

INSERT INTO Books(BookID, Title, AuthorID, Price, PublishedYear)
VALUES
(1, 'Red Blue Shark', 1, 4600, '2002-12-01'),
(23, 'Blue Light', 2, 600, '2015-01-05'),
(467, 'Welcome Home', 3, 6200, '2024-12-01'),
(500, 'Social', 4, 4100, '2018-12-01'),
(125, 'Cat-Home-Return', 5, 1000, '2013-12-01');

INSERT INTO Customer(CustomerID, Name, Email, PhoneNumber)
VALUES
(21, 'Deepali', 'demo14@gmail.com', '1234567891'),
(22, 'Pranali', 'pranali.demo4@gmail.com', '1234567893'),
(23, 'Dhanashree', 'dhanashreedemo14@gmail.com', '1234567898'),
(24, 'Somnath', 'somnathdemo14@gmail.com', '1234567899'),
(25, 'Ketan', 'ketandemo14@gmail.com', '7234567890');

INSERT INTO Orders(OrderID, CustomerID, OrderDate, TotalAmount)
VALUES
(1, 21, NULL, NULL),
(2, 22, NULL, NULL),
(3, 23, '2022-01-20', 4500),
(4, 24, '2021-02-28', 1000),  
(5, 24, '2024-03-05', 500);

INSERT INTO OrderItems(OrderItemID, OrderID, BookID, Quantity, SubTotal)
VALUES
(467, 1, 1, NULL, NULL),
(43, 2, 23, NULL, NULL),
(1456, 3, 467, 8, 4500),
(198, 4, 500, 1, 4500),
(13, 5, 125, 3, 4500);

--Update the price of a book titled "SQL Mastery" by increasing it by 
10%.
update Books
set Price = Price*1.01;

select * from Books

--Delete a customer who has not placed any orders.
Delete Customer from Customer
LEFT JOIN Orders
ON Orders.CustomerID = Customer.CustomerID
WHERE Orders.CustomerID IS NULL

select  * from Orders
select * from Customer

--Find all customers who have placed at least one order.
select distinct c.Name from Customer c
inner join Orders o  
on o.CustomerID = c.CustomerID 
--where o.OrderDate is not null

select * from Orders
select * from Customer

--Retrieve all books with a price greater than 2000.
select price
from Books
where Price>2000

--Find the total number of books available. 
select Count(BookID) as avalibale_Books
from Books

select * from Books

--Find books published between 2015 and 2023.
select bookID, title, AuthorID, Price, PublishedYear,YEAR(PublishedYear) as year_Book
from Books
WHERE YEAR(PublishedYear) BETWEEN 2013 AND 2015;

select *
from Books
where year(PublishedYear) between 2013 and 2015;

select title 
from Books
where title like '%sql%'

-- Find the most expensive book in the store. 
select max(Price) as expensive_book
from Books

select * from Orders
select * from Customer

DELETE c
FROM Customer c
LEFT JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE o.CustomerID IS NULL;

--Retrieve books where the title contains the word "SQL".
select title 
from Books
where title like '%Blue%'

-- Find the most expensive book in the store. 
select name
from Customer
where name like 'A%' or name like 'D%'

--Calculate the total revenue from all orders. 

select sum(b.Price * o.Quantity)  as total_revenue
from Books b 
join OrderItems o on b.bookID = o.BookID

--Retrieve all book titles along with their respective author names. 
select b.title , a.Name
from Books b
join Authors a on b.AuthorID = a.AuthorID

--List all customers and their orders (if any)
select c.Name, o.OrderID, o.Orderdate, o.TotalAmount
from Customer c
join Orders o on c.CustomerID = o.CustomerID

--Retrieve the total number of orders placed by each customer. 
select  c.CustomerID, count(o.OrderID) as sum_of_order
from Customer c
left join Orders o on o.CustomerID = c.CustomerID
group by c.CustomerID


--Find the books ordered along with the quantity for each order. 
select o.OrderID , sum(i.Quantity)
from Orders o 
join OrderItems i on o.OrderID = i.OrderID
group by o.OrderID 

--Display all customers, even those who haven’t placed any orders. 
select c.Name , C.CustomerID, count(o.OrderID) as order_book
from Customer c
left join Orders o on c.CustomerID = o.CustomerID
group by c.CustomerID, c.Name

Select * from Books

select title,Price
from Books 
where Price = (select max(Price) from Books)