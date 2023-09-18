CREATE PROCEDURE [dbo].[getYearAvgCustom]
	@Year varchar,
	@sDate date,
	@eDate date
AS
	SELECT SUM(tblFoodEntry.Amount * tblCustomFood.Cals /100) AS sumCals, SUM(tblFoodEntry.Amount * tblCustomFood.Carbs/100) AS sumCarbs, SUM(tblFoodEntry.Amount * tblCustomFood.Fats/100) AS sumFats, SUM(tblFoodEntry.Amount * tblCustomFood.Proteins/100) AS sumProteins
	FROM tblFoodEntry, tblCustomFood
	WHERE tblCustomFood.CFoodID = tblFoodEntry.FoodID AND tblCustomFood.Username = tblFoodEntry.Username AND tblFoodEntry.Custom = 1 AND tblFoodEntry.Username LIKE '@Year*' AND tblFoodEntry.Date BETWEEN @sDate AND @eDate
RETURN 0