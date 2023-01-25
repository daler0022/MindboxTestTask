SELECT Products.Name AS 'Имя продукта', Categories.Name AS 'Имя категории'
FROM Products
LEFT JOIN ProductCategories ON Products.Id = ProductCategories.ProductId
LEFT JOIN Categories ON ProductCategories.CategoryId = Categories.Id
