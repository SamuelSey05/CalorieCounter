CREATE PROCEDURE [dbo].[addFoodEntry]
	@Username varchar,
	@Date date,
	@Time int, 
	@FoodID int,
	@Custom bit,
	@Amount real
AS
	INSERT INTO tblFoodEntry(Username, Date, Time, FoodID, Custom, Amount)
	VALUES (@Username, @Date, @Time, @FoodID, @Custom, @Amount)
RETURN 0