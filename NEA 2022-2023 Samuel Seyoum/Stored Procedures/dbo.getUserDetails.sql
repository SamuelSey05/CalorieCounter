CREATE PROCEDURE [dbo].[getUserDetails]
	@Username varchar(9)
AS
	SELECT tblStudent.Forename, tblStudent.Surname, tblStudent.Password, tblStudent.DOB, tblStudent.Gender, tblStudent.Weight, tblStudent.Height, tblStudent.BFP, tblStudent.PAL, tblStudent.Goal, tblStudent.mCals, tblStudent.Cals, tblStudent.Carbs, tblStudent.Fats, tblStudent.Proteins
	FROM tblStudent
	WHERE tblStudent.Username = @Username
RETURN 0