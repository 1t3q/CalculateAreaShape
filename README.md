# CalculateAreaShape
 
Предполагаем, что имеется две таблицы Product и Category, также связанная таблица ProductsCategories

select p."name", c."name" from "Product" p left join "ProductsCategories" pc on pc.product_id = p.id left join "Category" c on pc.category_id = c.id