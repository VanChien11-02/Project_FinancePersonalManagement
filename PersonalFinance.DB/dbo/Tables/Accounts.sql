CREATE TABLE [dbo].[Accounts] (
    [AccountID]   VARCHAR (7)     NOT NULL,
    [UserID]      VARCHAR (7)     NOT NULL,
    [AccountName] NVARCHAR (100)  NOT NULL,
    [Balance]     DECIMAL (18, 2) DEFAULT ((0)) NULL,
    [AccountType] NVARCHAR (50)   NULL,
    [BankDetail]  NVARCHAR (200)  NULL,
    PRIMARY KEY CLUSTERED ([AccountID] ASC),
    FOREIGN KEY ([UserID]) REFERENCES [dbo].[Users] ([UserID]),
    UNIQUE NONCLUSTERED ([AccountName] ASC)
);

