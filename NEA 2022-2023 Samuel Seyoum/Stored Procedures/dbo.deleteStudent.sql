CREATE PROCEDURE [dbo].[deleteStudent]
	@Username varchar(9)
AS
	DELETE 
	FROM tblStudent
	WHERE tblStudent.Username = @Username
RETURN 0
