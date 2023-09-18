CREATE TABLE [dbo].[tblFood]
(
	[FoodID] INT NOT NULL,
	[Name] VARCHAR NOT NULL,
	[Cals] REAL NOT NULL,
	[Carbs] REAL NOT NULL,
	[Fats] REAL NOT NULL,
	[Proteins] REAL NOT NULL,
	[Serve] REAL NOT NULL,
	PRIMARY KEY CLUSTERED ([FoodID] ASC)
)
