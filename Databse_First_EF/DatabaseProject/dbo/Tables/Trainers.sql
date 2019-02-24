CREATE TABLE [dbo].[Trainers] (
    [ID]        INT          IDENTITY (1, 1) NOT NULL,
    [FirstName] VARCHAR (20) NOT NULL,
    [LastName]  VARCHAR (30) NOT NULL,
    [Language]  VARCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

