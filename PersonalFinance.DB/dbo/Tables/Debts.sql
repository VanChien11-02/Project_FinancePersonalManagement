CREATE TABLE [dbo].[Debts] (
    [DebtID]       VARCHAR (7)     NOT NULL,
    [UserID]       VARCHAR (7)     NOT NULL,
    [PersonName]   NVARCHAR (100)  NOT NULL,
    [Amount]       DECIMAL (18, 2) NOT NULL,
    [InterestRate] FLOAT (53)      DEFAULT ((0)) NULL,
    [StartDate]    DATETIME        DEFAULT (getdate()) NULL,
    [DueDate]      DATETIME        NULL,
    [DebtType]     NVARCHAR (20)   NOT NULL,
    [Status]       NVARCHAR (20)   DEFAULT ('Active') NULL,
    [AccountID]    VARCHAR (7)     NULL,
    [PaidAmount]   DECIMAL (18, 2) DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([DebtID] ASC),
    CHECK ([DebtType]=N'Đi vay' OR [DebtType]=N'Cho mượn'),
    CHECK ([Status]='Finished' OR [Status]='Active'),
    FOREIGN KEY ([AccountID]) REFERENCES [dbo].[Accounts] ([AccountID]),
    FOREIGN KEY ([UserID]) REFERENCES [dbo].[Users] ([UserID])
);

