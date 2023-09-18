CREATE TABLE [dbo].[tblFoodEntry] (
    [Username] VARCHAR (9) NOT NULL,
    [Date]     DATE        NOT NULL,
    [Time]     INT         NOT NULL,
    [FoodID]   INT         NOT NULL,
    [Custom]   BIT         NOT NULL,
    [Amount]   REAL        NOT NULL, 
    CONSTRAINT [CompFoodEntry] PRIMARY KEY CLUSTERED ([Username] ASC, [Date] ASC, [Time] ASC, [FoodID] ASC, [Custom] ASC),
    FOREIGN KEY ([Username]) REFERENCES [dbo].[tblStudent] ([Username])
);

