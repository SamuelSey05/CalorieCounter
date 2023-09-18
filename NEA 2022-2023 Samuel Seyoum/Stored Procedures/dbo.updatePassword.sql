CREATE PROCEDURE [dbo].[updatePassword]
	@Username varchar(9),
	@Password varchar(50)
AS
	UPDATE tblStudent
	SET tblStudent.Password = @Password
	WHERE tblStudent.Username = @Username
RETURN 0
