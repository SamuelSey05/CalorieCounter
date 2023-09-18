CREATE PROCEDURE [dbo].[getCustomFood]
	@FoodID int,
	@Username varchar(9)
AS
	SELECT tblCustomFood.Name, tblCustomFood.Serve, tblCustomFood.Cals, tblCustomFood.Carbs, tblCustomFood.Fats, tblCustomFood.Proteins
	FROM tblCustomFood
	WHERE tblCustomFood.Username = @Username AND tblCustomFood.CFoodID = @FoodID AND tblCustomFood.Username = @Username
RETURN 0