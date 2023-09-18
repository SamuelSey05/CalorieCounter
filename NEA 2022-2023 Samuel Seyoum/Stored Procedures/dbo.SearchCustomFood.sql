CREATE PROCEDURE [dbo].[searchCustomFood]
	@Name varchar(40),
	@Username varchar(9)
AS
	SELECT tblCustomFood.CFoodID, tblCustomFood.Name, tblCustomFood.Cals
	FROM tblCustomFood
	WHERE tblCustomFood.Name LIKE '*@Name*' AND tblCustomFood.Username = @Username
	ORDER BY LEN(tblCustomFood.Name) ASC
RETURN 0