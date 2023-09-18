CREATE PROCEDURE [dbo].[updateAmount]
	@Username varchar(9),
	@Date date,
	@Time int,
	@FoodID int,
	@Custom bit,
	@Amount real
AS
	UPDATE tblFoodEntry
	SET Amount = @Amount
	WHERE tblFoodEntry.Username = @Username AND tblFoodEntry.Date = @Date AND tblFoodEntry.Time = @Time AND tblFoodEntry.Custom = @Custom
RETURN 0
