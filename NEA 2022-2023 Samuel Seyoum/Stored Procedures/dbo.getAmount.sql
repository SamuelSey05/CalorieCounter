CREATE PROCEDURE [dbo].[getAmount]
	@Username varchar(9),
	@Date date,
	@Time int,
	@FoodID int
AS
	SELECT tblFoodEntry.Amount, tblFood.Serve, tblFood.Cals, tblFood.Carbs, tblFood.Fats, tblFood.Proteins, tblFood.Name
	FROM tblFoodEntry, tblFood
	WHERE tblFood.FoodID = tblFoodEntry.FoodID AND tblFoodEntry.Username = @Username AND tblFoodEntry.Date = @Date AND tblFoodEntry.Time = @Time AND tblFoodEntry.Custom = 0
RETURN 0