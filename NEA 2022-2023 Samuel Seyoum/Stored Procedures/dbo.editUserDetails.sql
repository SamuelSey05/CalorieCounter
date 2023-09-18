CREATE PROCEDURE [dbo].[editUserDetails]
	@Username varchar(9),
	@Height real,
	@Weight real,
	@DOB date,
	@BFP real,
	@PAL real,
	@Goal int,
	@mCals real, 
	@Cals real,
	@Carbs real,
	@Fats real,
	@Proteins real
AS
	UPDATE tblStudent
	SET tblstudent.Height = @Height, tblStudent.Weight= @Weight, tblStudent.BFP = @BFP, tblStudent.PAL = @PAL, tblStudent.Goal = @Goal, tblStudent.DOB = @DOB, tblStudent.mCals = @mCals, tblStudent.Cals = @Cals, tblStudent.Carbs = @Carbs, tblStudent.Fats = @Fats, tblStudent.Proteins = @Proteins
	WHERE tblStudent.Username = @Username
RETURN 0