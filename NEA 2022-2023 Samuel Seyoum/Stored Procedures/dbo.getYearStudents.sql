CREATE PROCEDURE [dbo].[getYearStudents]
	@Year varchar,
	@sDate date,
	@eDate date
AS
	SELECT COUNT(tblFoodEntry.Username)
	FROM tblFoodEntry
	WHERE tblFoodEntry.Username LIKE '@Year*' AND tblFoodEntry.Date BETWEEN @sDate AND @eDate
RETURN 0
