CREATE TABLE [dbo].[Students] (
    [ID]        INT          IDENTITY (1, 1) NOT NULL,
    [FirstName] VARCHAR (20) NOT NULL,
    [LastName]  VARCHAR (30) NOT NULL,
    [BirthDate] DATE         NULL,
    [Mark]      INT          NOT NULL,
    [Score_ID]  INT          NOT NULL,
    [Stage_ID]  INT          NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    FOREIGN KEY ([Score_ID]) REFERENCES [dbo].[Score] ([ID]),
    FOREIGN KEY ([Stage_ID]) REFERENCES [dbo].[Stage] ([ID])
);

