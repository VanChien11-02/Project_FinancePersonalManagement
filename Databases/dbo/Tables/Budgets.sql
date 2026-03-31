CREATE TABLE [dbo].[Budgets] (
    [BudgetID]   VARCHAR (7)     NOT NULL,
    [UserID]     VARCHAR (7)     NOT NULL,
    [CategoryID] VARCHAR (7)     NOT NULL,
    [Amount]     DECIMAL (18, 2) NOT NULL,
    [Month]      INT             NOT NULL,
    [Year]       INT             NOT NULL,
    PRIMARY KEY CLUSTERED ([BudgetID] ASC),
    FOREIGN KEY ([CategoryID]) REFERENCES [dbo].[Categories] ([CategoryID]),
    FOREIGN KEY ([UserID]) REFERENCES [dbo].[Users] ([UserID])
);

