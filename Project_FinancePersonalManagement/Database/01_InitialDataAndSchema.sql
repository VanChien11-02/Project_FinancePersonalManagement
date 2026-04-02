USE [master]
GO

-- 1. TẠO DATABASE
CREATE DATABASE [PersonalFinanceDB]
GO

USE [PersonalFinanceDB]
GO

-- 2. TẠO BẢNG USERS
CREATE TABLE [dbo].[Users](
	[UserID] [varchar](7) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[PasswordHash] [varchar](255) NOT NULL,
	[Email] [nvarchar](100) NULL,
	[PhoneNumber] [varchar](15) NULL,
    PRIMARY KEY CLUSTERED ([UserID] ASC),
    UNIQUE ([Username] ASC)
) ON [PRIMARY]
GO

-- 3. TẠO BẢNG ACCOUNTS
CREATE TABLE [dbo].[Accounts](
	[AccountID] [varchar](7) NOT NULL,
	[UserID] [varchar](7) NOT NULL,
	[AccountName] [nvarchar](100) NOT NULL,
	[Balance] [decimal](18, 2) DEFAULT ((0)),
	[AccountType] [nvarchar](50) NULL,
	[BankDetail] [nvarchar](200) NULL,
    PRIMARY KEY CLUSTERED ([AccountID] ASC),
    UNIQUE ([AccountName] ASC)
) ON [PRIMARY]
GO

-- 4. TẠO BẢNG CATEGORIES
CREATE TABLE [dbo].[Categories](
	[CategoryID] [varchar](7) NOT NULL,
	[UserID] [varchar](7) NOT NULL,
	[CategoryName] [nvarchar](100) NOT NULL,
	[CategoryType] [nvarchar](20) NOT NULL,
	[Note] [nvarchar](255) NULL,
    PRIMARY KEY CLUSTERED ([CategoryID] ASC)
) ON [PRIMARY]
GO

-- 5. TẠO BẢNG BUDGETS
CREATE TABLE [dbo].[Budgets](
	[BudgetID] [varchar](7) NOT NULL,
	[UserID] [varchar](7) NOT NULL,
	[CategoryID] [varchar](7) NOT NULL,
	[Amount] [decimal](18, 2) NOT NULL,
	[Month] [int] NOT NULL,
	[Year] [int] NOT NULL,
    PRIMARY KEY CLUSTERED ([BudgetID] ASC)
) ON [PRIMARY]
GO

-- 6. TẠO BẢNG DEBTS
CREATE TABLE [dbo].[Debts](
	[DebtID] [varchar](7) NOT NULL,
	[UserID] [varchar](7) NOT NULL,
	[PersonName] [nvarchar](100) NOT NULL,
	[Amount] [decimal](18, 2) NOT NULL,
	[InterestRate] [float] DEFAULT ((0)),
	[StartDate] [datetime] DEFAULT (getdate()),
	[DueDate] [datetime] NULL,
	[DebtType] [nvarchar](20) NOT NULL CHECK ([DebtType]=N'Đi vay' OR [DebtType]=N'Cho mượn'),
	[Status] [nvarchar](20) DEFAULT ('Active') CHECK ([Status]='Finished' OR [Status]='Active'),
	[AccountID] [varchar](7) NULL,
	[PaidAmount] [decimal](18, 2) DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([DebtID] ASC)
) ON [PRIMARY]
GO

-- 7. TẠO BẢNG TRANSACTIONS
CREATE TABLE [dbo].[Transactions](
	[TransID] [varchar](7) NOT NULL,
	[UserID] [varchar](7) NOT NULL,
	[AccountID] [varchar](7) NOT NULL,
	[CategoryID] [varchar](7) NULL,
	[DebtID] [varchar](7) NULL,
	[Amount] [decimal](18, 2) NOT NULL,
	[TransType] [nvarchar](20) NOT NULL,
	[TransDate] [datetime] DEFAULT (getdate()),
	[Note] [nvarchar](500) NULL,
    PRIMARY KEY CLUSTERED ([TransID] ASC)
) ON [PRIMARY]
GO

-- 8. THIẾT LẬP KHÓA NGOẠI (FOREIGN KEYS)
ALTER TABLE [dbo].[Accounts] ADD FOREIGN KEY([UserID]) REFERENCES [dbo].[Users] ([UserID])
ALTER TABLE [dbo].[Budgets] ADD FOREIGN KEY([CategoryID]) REFERENCES [dbo].[Categories] ([CategoryID])
ALTER TABLE [dbo].[Budgets] ADD FOREIGN KEY([UserID]) REFERENCES [dbo].[Users] ([UserID])
ALTER TABLE [dbo].[Categories] ADD FOREIGN KEY([UserID]) REFERENCES [dbo].[Users] ([UserID])
ALTER TABLE [dbo].[Debts] ADD FOREIGN KEY([AccountID]) REFERENCES [dbo].[Accounts] ([AccountID])
ALTER TABLE [dbo].[Debts] ADD FOREIGN KEY([UserID]) REFERENCES [dbo].[Users] ([UserID])
ALTER TABLE [dbo].[Transactions] ADD FOREIGN KEY([AccountID]) REFERENCES [dbo].[Accounts] ([AccountID])
ALTER TABLE [dbo].[Transactions] ADD FOREIGN KEY([CategoryID]) REFERENCES [dbo].[Categories] ([CategoryID])
ALTER TABLE [dbo].[Transactions] ADD FOREIGN KEY([DebtID]) REFERENCES [dbo].[Debts] ([DebtID])
ALTER TABLE [dbo].[Transactions] ADD FOREIGN KEY([UserID]) REFERENCES [dbo].[Users] ([UserID])
GO

-- 9. CHÈN DỮ LIỆU MẪU (INSERT DATA)
-- Chèn Users
INSERT [dbo].[Users] ([UserID], [Username], [PasswordHash], [Email], [PhoneNumber]) VALUES (N'USER001', N'chien', N'12345', NULL, NULL)
INSERT [dbo].[Users] ([UserID], [Username], [PasswordHash], [Email], [PhoneNumber]) VALUES (N'USER002', N'an', N'54321', NULL, NULL)

-- Chèn Accounts
INSERT [dbo].[Accounts] ([AccountID], [UserID], [AccountName], [Balance], [AccountType], [BankDetail]) VALUES (N'ACC001', N'USER001', N'Ví tiền mặt', 100000.00, N'Cash', NULL)
INSERT [dbo].[Accounts] ([AccountID], [UserID], [AccountName], [Balance], [AccountType], [BankDetail]) VALUES (N'ACC002', N'USER001', N'MB Bank', 2950000.00, N'Bank', N'MB Bank')
INSERT [dbo].[Accounts] ([AccountID], [UserID], [AccountName], [Balance], [AccountType], [BankDetail]) VALUES (N'ACC003', N'USER001', N'Momo', 1000000.00, N'E-Wallet', N'Momo')
INSERT [dbo].[Accounts] ([AccountID], [UserID], [AccountName], [Balance], [AccountType], [BankDetail]) VALUES (N'ACC004', N'USER002', N'Ví cá nhân', 3000000.00, N'Cash', NULL)
INSERT [dbo].[Accounts] ([AccountID], [UserID], [AccountName], [Balance], [AccountType], [BankDetail]) VALUES (N'ACC005', N'USER001', N'Sổ tiết kiệm', 1200000.00, N'Bank', N'')

-- Chèn Categories
INSERT [dbo].[Categories] ([CategoryID], [UserID], [CategoryName], [CategoryType], [Note]) VALUES (N'C001', N'USER001', N'Lương', N'Income', NULL)
INSERT [dbo].[Categories] ([CategoryID], [UserID], [CategoryName], [CategoryType], [Note]) VALUES (N'C002', N'USER001', N'Ăn uống', N'Expense', NULL)
INSERT [dbo].[Categories] ([CategoryID], [UserID], [CategoryName], [CategoryType], [Note]) VALUES (N'C003', N'USER001', N'Đi lại', N'Expense', NULL)
INSERT [dbo].[Categories] ([CategoryID], [UserID], [CategoryName], [CategoryType], [Note]) VALUES (N'C004', N'USER001', N'Mua sắm', N'Expense', NULL)
INSERT [dbo].[Categories] ([CategoryID], [UserID], [CategoryName], [CategoryType], [Note]) VALUES (N'C006', N'USER001', N'Cho mượn', N'Expense', N'Hệ thống tự động tạo cho nghiệp vụ Vay/Cho vay')
INSERT [dbo].[Categories] ([CategoryID], [UserID], [CategoryName], [CategoryType], [Note]) VALUES (N'C008', N'USER001', N'Đi vay', N'Income', N'Hệ thống tự động tạo cho nghiệp vụ Vay/Cho vay')

-- Chèn Budgets
INSERT [dbo].[Budgets] ([BudgetID], [UserID], [CategoryID], [Amount], [Month], [Year]) VALUES (N'B001', N'USER001', N'C002', 2000000.00, 3, 2026)
INSERT [dbo].[Budgets] ([BudgetID], [UserID], [CategoryID], [Amount], [Month], [Year]) VALUES (N'B002', N'USER001', N'C003', 1000000.00, 3, 2026)

-- Chèn Debts
INSERT [dbo].[Debts] ([DebtID], [UserID], [PersonName], [Amount], [InterestRate], [StartDate], [DueDate], [DebtType], [Status], [AccountID], [PaidAmount]) VALUES (N'DEB001', N'USER001', N'Nguyễn Văn A', 2000000.00, 0.2, '2026-03-01', '2026-06-01', N'Đi vay', N'Active', N'ACC001', 0.00)
INSERT [dbo].[Debts] ([DebtID], [UserID], [PersonName], [Amount], [InterestRate], [StartDate], [DueDate], [DebtType], [Status], [AccountID], [PaidAmount]) VALUES (N'DEB005', N'USER001', N'alr', 150000.00, 0, '2026-04-02', '2026-04-02', N'Đi vay', N'Active', N'ACC005', 0.00)

-- Chèn Transactions
INSERT [dbo].[Transactions] ([TransID], [UserID], [AccountID], [CategoryID], [DebtID], [Amount], [TransType], [TransDate], [Note]) VALUES (N'TXN0001', N'USER001', N'ACC001', N'C001', NULL, 10000000.00, N'Income', '2026-03-01', N'Lương tháng 3')
INSERT [dbo].[Transactions] ([TransID], [UserID], [AccountID], [CategoryID], [DebtID], [Amount], [TransType], [TransDate], [Note]) VALUES (N'TXN0002', N'USER001', N'ACC001', N'C002', NULL, 150000.00, N'Expense', '2026-03-02', N'Ăn trưa')
INSERT [dbo].[Transactions] ([TransID], [UserID], [AccountID], [CategoryID], [DebtID], [Amount], [TransType], [TransDate], [Note]) VALUES (N'TXN0019', N'USER001', N'ACC005', N'C008', N'DEB005', 150000.00, N'Income', '2026-04-02', N'Đi vay tiền từ: alr')
GO