CREATE PROCEDURE [dbo].[searchFoodEntry]
	@Username varchar(9),
	@Date date,
	@Name varchar(40)
AS
	SELECT tblFoodEntry.FoodID, tblFood.Name, (tblFoodEntry.Amount * tblFood.Cals/100), tblFoodEntry.Time, tblFoodEntry.Custom
	FROM tblFood, tblFoodEntry
	WHERE tblFoodEntry.FoodID = tblFood.FoodID and tblFoodEntry.Date = @Date and tblFood.Name LIKE '*@Name*' and tblFoodEntry.Custom = 0 and tblFoodEntry.Username = @Username
	ORDER BY LEN(tblFood.Name) ASC
RETURN 0