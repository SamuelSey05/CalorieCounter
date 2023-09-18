CREATE PROCEDURE [dbo].[searchFood]
	@Name varchar(40)
AS
	SELECT TOP 20 tblfood.FoodID, tblFood.Name, tblfood.Cals
	FROM tblFood
	WHERE tblFood.Name LIKE '*@Name*'
	ORDER BY LEN(tblFood.Name) ASC
RETURN 0