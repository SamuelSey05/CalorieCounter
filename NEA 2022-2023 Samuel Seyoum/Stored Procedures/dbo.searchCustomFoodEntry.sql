CREATE PROCEDURE [dbo].[searchCustomFoodEntry]
	@Username varchar(9),
	@Date date,
	@Name varchar(40)
AS
	SELECT tblFoodEntry.FoodID, tblCustomFood.Name, (tblFoodEntry.Amount * tblCustomFood.Cals /100), tblFoodEntry.Time, tblFoodEntry.Custom
	FROM tblCustomFood, tblFoodEntry
	WHERE tblFoodEntry.FoodID = tblCustomFood.CFoodID AND tblFoodEntry.Username = @Username AND tblCustomFood.Username = @Username AND tblFoodEntry.Date = @Date AND tblCustomFood.Name LIKE '*@Name*' AND tblFoodEntry.Custom = 1 
	ORDER BY LEN(tblCustomFood.Name) ASC
RETURN 0