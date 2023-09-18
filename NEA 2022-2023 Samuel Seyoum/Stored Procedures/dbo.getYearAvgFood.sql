CREATE PROCEDURE [dbo].[getYearAvgFood]
	@Year varchar,
	@sDate date,
	@eDate date
AS
	SELECT SUM(tblFoodEntry.Amount * tblFood.Cals /100) AS sumCals, SUM(tblFoodEntry.Amount * tblFood.Carbs/100) AS sumCarbs, SUM(tblFoodEntry.Amount * tblFood.Fats/100) AS sumFats, SUM(tblFoodEntry.Amount * tblFood.Proteins/100) AS sumProteins
	FROM tblFoodEntry, tblFood
	WHERE tblFood.FoodID = tblFoodEntry.FoodID AND tblFoodEntry.Custom = 0 AND tblFoodEntry.Username LIKE '@Year*' AND tblFoodEntry.Date BETWEEN @sDate AND @eDate
RETURN 0