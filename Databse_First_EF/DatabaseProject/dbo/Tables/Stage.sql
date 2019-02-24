CREATE TABLE [dbo].[Stage] (
    [ID]                    INT          IDENTITY (1, 1) NOT NULL,
    [Name]                  VARCHAR (50) NOT NULL,
    [Price]                 INT          NULL,
    [Duration (month)]      INT          NOT NULL,
    [Language]              VARCHAR (20) NULL,
    [Trainer_ID]            INT          NOT NULL,
    [ClassRoom_ID]          INT          NOT NULL,
    [Programming_Course_ID] INT          NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    FOREIGN KEY ([ClassRoom_ID]) REFERENCES [dbo].[ClassRoom] ([ID]),
    FOREIGN KEY ([Programming_Course_ID]) REFERENCES [dbo].[ProgrammingCourses] ([ID]),
    FOREIGN KEY ([Trainer_ID]) REFERENCES [dbo].[Trainers] ([ID])
);

