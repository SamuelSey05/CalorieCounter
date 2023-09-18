CREATE PROCEDURE [dbo].[getFood]
	@FoodID int
AS
	SELECT tblFood.Name, tblFood.Serve, tblFood.Cals, tblFood.Carbs, tblFood.Fats, tblFood.Proteins, tblFood.Units
	FROM tblFood
	WHERE tblFood.FoodID = @FoodID
RETURN 0
