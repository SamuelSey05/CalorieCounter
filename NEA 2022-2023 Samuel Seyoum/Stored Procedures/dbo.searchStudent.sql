CREATE PROCEDURE [dbo].[searchStudent]
	@Name varchar(9)
AS
	SELECT tblStudent.Username, tblStudent.Forename, tblStudent.Surname
	FROM tblStudent
	WHERE tblStudent.Username LIKE '@Name*' OR tblStudent.Forename LIKE '@Name*' OR tblStudent.Surname LIKE '@Name*'
RETURN 0
