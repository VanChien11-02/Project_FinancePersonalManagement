CREATE DATABASE PersonalFinanceDB;
GO

USE PersonalFinanceDB;
GO

CREATE TABLE Users (
    UserID VARCHAR(7) PRIMARY KEY ,        -- USER001
    Username NVARCHAR(50) NOT NULL UNIQUE, -- unique: Chống trùng lặp
    PasswordHash VARCHAR(255) NOT NULL
);

CREATE TABLE Accounts (
    AccountID VARCHAR(7) PRIMARY KEY,      -- ACC001
    UserID VARCHAR(7) NOT NULL,
    AccountName NVARCHAR(100) NOT NULL UNIQUE,
    Balance DECIMAL(18, 2) DEFAULT 0, 
    AccountType NVARCHAR(50),              -- VD: 'Cash', 'Bank', 'E-Wallet'
    BankDetail NVARCHAR(200),              -- Tên ngân hàng, số thẻ... (Optional)
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

CREATE TABLE Categories (
    CategoryID VARCHAR(7) PRIMARY KEY,     -- C001
    UserID VARCHAR(7) NOT NULL,
    CategoryName NVARCHAR(100) NOT NULL,
    CategoryType NVARCHAR(20) NOT NULL,    -- 'Income' hoặc 'Expense' hoặc Transfer
    Note NVARCHAR(255),
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

CREATE TABLE Debts (
    DebtID VARCHAR(7) PRIMARY KEY,         -- DEB001
    UserID VARCHAR(7) NOT NULL,
    PersonName NVARCHAR(100) NOT NULL,     -- Tên người vay/cho vay
    Amount DECIMAL(18, 2) NOT NULL,        -- Số tiền gốc
    InterestRate FLOAT DEFAULT 0,          -- Lãi suất
    StartDate DATETIME DEFAULT GETDATE(),
    DueDate DATETIME,
    DebtType NVARCHAR(20) NOT NULL CHECK (DebtType IN (N'Cho mượn',N'Đi vay')),        -- Cho vay hoặc Đi vay
    Status NVARCHAR(20) DEFAULT 'Active' CHECK (Status IN ('Active','Finished')),      -- 'Active', 'Finished' --> 'Đang cho', 'Hoàn thành'
    AccountID VARCHAR(7),
    PaidAmount DECIMAL(18, 2) NOT NULL DEFAULT 0,       -- Tiền thanh toán 1 phần


    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (AccountID) REFERENCES Accounts(AccountID)
);

CREATE TABLE Transactions (
    TransID VARCHAR(7) PRIMARY KEY,        -- TXN0001
    UserID VARCHAR(7) NOT NULL,
    AccountID VARCHAR(7) NOT NULL,
    CategoryID VARCHAR(7),                 -- Có thể Null nếu là chuyển khoản nội bộ không cần category
    DebtID VARCHAR(7),                     -- Null nếu không phải trả nợ/vay nợ
    Amount DECIMAL(18, 2) NOT NULL,
    TransType NVARCHAR(20) NOT NULL,       -- 'Income', 'Expense', Transfer
    TransDate DATETIME DEFAULT GETDATE(),
    Note NVARCHAR(500),
    
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (AccountID) REFERENCES Accounts(AccountID),
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID),
    FOREIGN KEY (DebtID) REFERENCES Debts(DebtID)
);

CREATE TABLE Budgets (
    BudgetID VARCHAR(7) PRIMARY KEY,    --B001
    UserID VARCHAR(7) NOT NULL,
    CategoryID VARCHAR(7) NOT NULL,
    Amount DECIMAL(18,2) NOT NULL,
    Month INT NOT NULL,
    Year INT NOT NULL,

    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);


INSERT INTO Users(UserID, Username, PasswordHash) VALUES
('USER001',N'chien','12345'),
('USER002',N'an','54321');

INSERT INTO Accounts(AccountID, UserID, AccountName, Balance, AccountType, BankDetail) VALUES
('ACC001','USER001',N'Ví tiền mặt',2000000,'Cash',NULL),
('ACC002','USER001',N'MB Bank',5000000,'Bank',N'MB Bank'),
('ACC003','USER001',N'Momo',1000000,'E-Wallet',N'Momo'),
('ACC004','USER002',N'Ví cá nhân',3000000,'Cash',NULL);

INSERT INTO Categories(CategoryID, UserID, CategoryName, CategoryType, Note) VALUES
('C001','USER001',N'Lương','Income',NULL),
('C002','USER001',N'Ăn uống','Expense',NULL),
('C003','USER001',N'Đi lại','Expense',NULL),
('C004','USER001',N'Mua sắm','Expense',NULL),
('C005','USER001',N'Thưởng','Income',NULL);

INSERT INTO Debts(DebtID, UserID, PersonName, Amount, InterestRate, StartDate, DueDate, DebtType, Status, AccountID) VALUES
('DEB001','USER001',N'Nguyễn Văn A',2000000,0.2,'2026-03-01','2026-06-01',N'Đi vay','Active','ACC001'),
('DEB002','USER001',N'Trần Văn B',1500000,0.05,'2026-03-10','2026-05-10',N'Cho mượn','Active','ACC002');


INSERT INTO Transactions(TransID, UserID,AccountID, CategoryID,DebtID, Amount, TransType, TransDate, Note) VALUES
('TXN0001','USER001','ACC001','C001',NULL,10000000,'Income','2026-03-01',N'Lương tháng 3'),

('TXN0002','USER001','ACC001','C002',NULL,150000,'Expense','2026-03-02',N'Ăn trưa'),

('TXN0003','USER001','ACC002','C003',NULL,50000,'Expense','2026-03-03',N'Đổ xăng'),

('TXN0004','USER001','ACC003','C004',NULL,300000,'Expense','2026-03-04',N'Mua áo'),

('TXN0005','USER001','ACC001',NULL,'DEB001',500000,'Expense','2026-03-05',N'Trả nợ'),

('TXN0006','USER001','ACC001',NULL,'DEB002',1000000,'Income','2026-03-06',N'Được trả nợ'),

('TXN0007','USER001','ACC001','C001',NULL,5000000,'Income','2026-01-02',N'Lương tháng 1');

INSERT INTO Budgets(BudgetID, UserID, CategoryID, Amount, Month, Year) VALUES
('B001','USER001','C002',2000000,3, 2026),
('B002','USER001','C003',1000000,3, 2026),
('B003','USER001','C004',1500000,3, 2026);

