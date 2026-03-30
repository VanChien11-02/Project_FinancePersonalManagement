CREATE TABLE [dbo].[Categories] (
    [CategoryID]   VARCHAR (7)    NOT NULL,
    [UserID]       VARCHAR (7)    NOT NULL,
    [CategoryName] NVARCHAR (100) NOT NULL,
    [CategoryType] NVARCHAR (20)  NOT NULL,
    [Note]         NVARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([CategoryID] ASC),
    FOREIGN KEY ([UserID]) REFERENCES [dbo].[Users] ([UserID])
);

