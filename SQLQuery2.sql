-- Select 
Select ContactName,CompanyName,City from Customers

--Alias Kullanımı
Select ContactName Adı,CompanyName ŞirketAdı,City Şehir from Customers

--Şarta göre listeleme
Select * from Customers where City = 'London'


select * from Products where CategoryID=1 or CategoryID=3

select * from Products where CategoryID=5 and UnitPrice>=15


--Sıralama komutu Order By
select * from Products order by UnitPrice

select * from Products order by CategoryID,ProductName

select * from Products order by UnitPrice asc  --- artan sıralama yapar
select * from Products order by UnitPrice desc  --- azalan sıralama yapar

select * from Products where CategoryID=5 order by UnitPrice desc  --- azalan sıralama yapar


select count(*) from Products --sayma işlemi yapar

select count(*) Adet from Products where CategoryID=3

--group by da * yerine  daima gruplanan alan olmalıdır
select CategoryID from Products group by CategoryID

select CategoryID, COUNT(*) from Products group by CategoryID

--having
select CategoryID, COUNT(*) from Products group by CategoryID having COUNT(*)<10

---  ilk önce where ile filtreler daha sonra count ile sayısı 10 dan az olanları bulur
select CategoryID, COUNT(*) from Products where UnitPrice>20
group by CategoryID having COUNT(*)<10

-- inner join ortak özellik ile birleştirir ve sadece eşleşenleri görüntüler.

select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>50

--- left join soldaki tabloda(products) olupta sağda(order details) olmayanlarıda görüntüler
select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID

--sipariş veren müşteriler
select * from Customers c inner join Orders o on c.CustomerID = o.CustomerID
-- sipariş vermeyenlerde dahil
select * from Customers c left join Orders o on c.CustomerID = o.CustomerID

--sadece sipariş vermeyenler
select * from Customers c left join Orders o on c.CustomerID = o.CustomerID
where o.CustomerID is null
--- right yazım şekline göre değişir


select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID inner join Orders o 
on o.OrderID=od.OrderID
