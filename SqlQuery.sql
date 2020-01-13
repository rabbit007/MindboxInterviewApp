select 
p.Name as ProductName, 
c.Name as CategoryName
from Product p
left join ProductByCategory pc on p.Id = pc.ProductId
left join Category c on c.Id = pc.CategoryId