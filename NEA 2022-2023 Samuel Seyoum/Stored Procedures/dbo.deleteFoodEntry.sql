CREATE PROCEDURE [dbo].[deleteFoodEntry]
	@Username varchar(9),
	@Date date,
	@Time int, 
	@FoodID int,
	@Custom bit
AS
	DELETE
	FROM tblFoodEntry
	WHERE tblFoodEntry.Username = @Username and tblFoodEntry.Date=@Date and tblFoodEntry.Time = @Time AND tblFoodEntry.FoodID = @FoodID and tblFoodEntry.Custom = @Custom
RETURN 0