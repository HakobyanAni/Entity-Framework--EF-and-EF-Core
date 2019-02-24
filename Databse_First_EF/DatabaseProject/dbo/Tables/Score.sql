CREATE TABLE [dbo].[Score] (
    [ID]                 INT IDENTITY (1, 1) NOT NULL,
    [Activity]           INT NOT NULL,
    [Github performance] INT NOT NULL,
    [Knowledge sharing]  INT NOT NULL,
    [Homework]           INT NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

