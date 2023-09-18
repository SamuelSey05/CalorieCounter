CREATE PROCEDURE [dbo].[getStudentDayFood]
	@Username varchar(9),
	@Date date
AS
	SELECT SUM(tblFoodEntry.Amount * tblFood.Cals) AS sumCals, SUM(tblFoodEntry.Amount * tblFood.Carbs) AS sumCarbs, SUM(tblFoodEntry.Amount * tblFood.Fats) AS sumFats, SUM(tblFoodEntry.Amount * tblFood.Proteins) AS sumProteins
	FROM tblFoodEntry, tblFood
	WHERE tblFood.FoodID = tblFoodEntry.FoodID AND tblFoodEntry.Username = @Username AND tblFoodEntry.Date = @Date AND tblFoodEntry.Custom = 0
RETURN 0
