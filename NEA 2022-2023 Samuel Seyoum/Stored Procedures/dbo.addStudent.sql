CREATE PROCEDURE [dbo].addStudent
	@Username varchar(9),
	@Forename varchar(50),
	@Surname varchar(50),
	@Password varchar(50),
	@DOB date,
	@Gender varchar(1),
	@Weight real,
	@Height real,
	@BFP real,
	@PAL real,
	@Goal int,
	@mCals real,
	@Cals real,
	@Carbs real,
	@Fats real,
	@Proteins real
AS
	INSERT INTO tblStudent(Username, Forename, Surname, Password, DOB, Gender, Weight, Height, BFP, PAL, Goal, mCals, Cals, Carbs, Fats, Proteins)
	VALUES (@Username, @Forename, @Surname, @Password, @DOB, @Gender, @Weight, @Height, @BFP, @PAL, @Goal, @mCals, @Cals, @Carbs, @Fats, @Proteins)
RETURN 0