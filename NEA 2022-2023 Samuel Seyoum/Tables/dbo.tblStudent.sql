CREATE TABLE [dbo].[tblStudent] (
    [Username] VARCHAR (9)   NOT NULL,
    [Forename] VARCHAR (50) NOT NULL,
    [Surname]  VARCHAR (50) NOT NULL,
    [Password] VARCHAR (50) NOT NULL,
    [DOB]      DATE          NOT NULL,
    [Gender]   VARCHAR (1)   NOT NULL,
    [Weight]   REAL          NOT NULL,
    [Height]   REAL          NOT NULL,
    [BFP]      REAL          NOT NULL,
    [PAL]      REAL          NOT NULL,
    [Goal]     INT           NOT NULL,
    [mCals]    REAL          NOT NULL,
    [Cals]     REAL          NOT NULL,
    [Carbs]    REAL          NOT NULL,
    [Fats]     REAL          NOT NULL,
    [Proteins] REAL          NOT NULL,
    PRIMARY KEY CLUSTERED ([Username] ASC)
);
