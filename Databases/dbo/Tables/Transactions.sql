CREATE TABLE [dbo].[Transactions] (
    [TransID]    VARCHAR (7)     NOT NULL,
    [UserID]     VARCHAR (7)     NOT NULL,
    [AccountID]  VARCHAR (7)     NOT NULL,
    [CategoryID] VARCHAR (7)     NULL,
    [DebtID]     VARCHAR (7)     NULL,
    [Amount]     DECIMAL (18, 2) NOT NULL,
    [TransType]  NVARCHAR (20)   NOT NULL,
    [TransDate]  DATETIME        DEFAULT (getdate()) NULL,
    [Note]       NVARCHAR (500)  NULL,
    PRIMARY KEY CLUSTERED ([TransID] ASC),
    FOREIGN KEY ([AccountID]) REFERENCES [dbo].[Accounts] ([AccountID]),
    FOREIGN KEY ([CategoryID]) REFERENCES [dbo].[Categories] ([CategoryID]),
    FOREIGN KEY ([DebtID]) REFERENCES [dbo].[Debts] ([DebtID]),
    FOREIGN KEY ([UserID]) REFERENCES [dbo].[Users] ([UserID])
);

