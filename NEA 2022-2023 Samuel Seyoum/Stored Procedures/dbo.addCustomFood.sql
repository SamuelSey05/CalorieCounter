CREATE PROCEDURE [dbo].[addCustomFood]
	@Username varchar,
	@Name varchar,
	@Cals real,
	@Carbs real,
	@Fats real,
	@Proteins real,
	@Serve real,
	@Units real
AS
	Insert into tblCustomFood(Username, Name, Cals, Carbs, Fats, Proteins, Serve, Units)
	Values(@Username, @Name, @Cals, @Carbs, @Fats, @Proteins, @Serve, @Units)
SELECT SCOPE_IDENTITY()
