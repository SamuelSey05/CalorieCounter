CREATE PROCEDURE [dbo].[addFood]
	@Name varchar,
	@Cals real,
	@Carbs real,
	@Fats real,
	@Proteins real,
	@Serve real,
	@Units real
AS
	Insert into tblFood(Name, Cals, Carbs, Fats, Proteins, Serve, Units)
	Values(@Name, @Cals, @Carbs, @Fats, @Proteins, @Serve, @Units)
SELECT SCOPE_IDENTITY()
