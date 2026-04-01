CREATE TABLE [dbo].[Users] (
    [UserID]       VARCHAR (7)    NOT NULL,
    [Username]     NVARCHAR (50)  NOT NULL,
    [PasswordHash] VARCHAR (255)  NOT NULL,
    [Email]        NVARCHAR (100) NULL,
    [PhoneNumber]  VARCHAR (15)   NULL,
    PRIMARY KEY CLUSTERED ([UserID] ASC),
    UNIQUE NONCLUSTERED ([Username] ASC)
);