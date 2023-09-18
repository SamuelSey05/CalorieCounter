CREATE TABLE [dbo].[tblCustomFood] (
    [CFoodID]  INT           NOT NULL,
    [Username] VARCHAR (9)   NOT NULL,
    [Name]     VARCHAR (100) NOT NULL,
    [Cals]     REAL          NOT NULL,
    [Carbs]    REAL          NOT NULL,
    [Fats]     REAL          NOT NULL,
    [Proteins] REAL          NOT NULL,
    [Serve]    REAL          NOT NULL,
    CONSTRAINT [CompCustomFood] PRIMARY KEY CLUSTERED ([Username] ASC, [CFoodID] ASC),
    FOREIGN KEY ([Username]) REFERENCES [dbo].[tblStudent] ([Username]) ON DELETE CASCADE
);

