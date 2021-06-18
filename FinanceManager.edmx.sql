
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/27/2021 20:59:52
-- Generated from EDMX file: C:\Users\MSI GAMING\source\repos\EnterpriseCourseworkTwo\FinanceManager.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [UsersDatabase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UserContact]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Contacts] DROP CONSTRAINT [FK_UserContact];
GO
IF OBJECT_ID(N'[dbo].[FK_LiabilityContact]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Liabilities] DROP CONSTRAINT [FK_LiabilityContact];
GO
IF OBJECT_ID(N'[dbo].[FK_UserIncome]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Incomes] DROP CONSTRAINT [FK_UserIncome];
GO
IF OBJECT_ID(N'[dbo].[FK_UserExpense]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Expenses] DROP CONSTRAINT [FK_UserExpense];
GO
IF OBJECT_ID(N'[dbo].[FK_ContactIncome]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Incomes] DROP CONSTRAINT [FK_ContactIncome];
GO
IF OBJECT_ID(N'[dbo].[FK_ContactExpense]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Expenses] DROP CONSTRAINT [FK_ContactExpense];
GO
IF OBJECT_ID(N'[dbo].[FK_UserAsset]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Assets] DROP CONSTRAINT [FK_UserAsset];
GO
IF OBJECT_ID(N'[dbo].[FK_UserLiability]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Liabilities] DROP CONSTRAINT [FK_UserLiability];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[Contacts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Contacts];
GO
IF OBJECT_ID(N'[dbo].[Incomes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Incomes];
GO
IF OBJECT_ID(N'[dbo].[Expenses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Expenses];
GO
IF OBJECT_ID(N'[dbo].[Liabilities]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Liabilities];
GO
IF OBJECT_ID(N'[dbo].[Assets]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Assets];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Username] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [FName] nvarchar(max)  NOT NULL,
    [LName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Contacts'
CREATE TABLE [dbo].[Contacts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FName] nvarchar(max)  NOT NULL,
    [LName] nvarchar(max)  NOT NULL,
    [UserId] int  NOT NULL,
    [Email] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Incomes'
CREATE TABLE [dbo].[Incomes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Amount] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [isRecurring] nvarchar(max)  NOT NULL,
    [Date] nvarchar(max)  NOT NULL,
    [UserId] int  NOT NULL,
    [ContactId] int  NOT NULL
);
GO

-- Creating table 'Expenses'
CREATE TABLE [dbo].[Expenses] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Amount] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [isRecurring] nvarchar(max)  NOT NULL,
    [Date] nvarchar(max)  NOT NULL,
    [UserId] int  NOT NULL,
    [ContactId] int  NOT NULL
);
GO

-- Creating table 'Liabilities'
CREATE TABLE [dbo].[Liabilities] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Value] nvarchar(max)  NOT NULL,
    [Date] nvarchar(max)  NOT NULL,
    [UserId] int  NOT NULL,
    [Contact_Id] int  NOT NULL
);
GO

-- Creating table 'Assets'
CREATE TABLE [dbo].[Assets] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Value] nvarchar(max)  NOT NULL,
    [Date] nvarchar(max)  NOT NULL,
    [UserId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Contacts'
ALTER TABLE [dbo].[Contacts]
ADD CONSTRAINT [PK_Contacts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Incomes'
ALTER TABLE [dbo].[Incomes]
ADD CONSTRAINT [PK_Incomes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Expenses'
ALTER TABLE [dbo].[Expenses]
ADD CONSTRAINT [PK_Expenses]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Liabilities'
ALTER TABLE [dbo].[Liabilities]
ADD CONSTRAINT [PK_Liabilities]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Assets'
ALTER TABLE [dbo].[Assets]
ADD CONSTRAINT [PK_Assets]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserId] in table 'Contacts'
ALTER TABLE [dbo].[Contacts]
ADD CONSTRAINT [FK_UserContact]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserContact'
CREATE INDEX [IX_FK_UserContact]
ON [dbo].[Contacts]
    ([UserId]);
GO

-- Creating foreign key on [Contact_Id] in table 'Liabilities'
ALTER TABLE [dbo].[Liabilities]
ADD CONSTRAINT [FK_LiabilityContact]
    FOREIGN KEY ([Contact_Id])
    REFERENCES [dbo].[Contacts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LiabilityContact'
CREATE INDEX [IX_FK_LiabilityContact]
ON [dbo].[Liabilities]
    ([Contact_Id]);
GO

-- Creating foreign key on [UserId] in table 'Incomes'
ALTER TABLE [dbo].[Incomes]
ADD CONSTRAINT [FK_UserIncome]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserIncome'
CREATE INDEX [IX_FK_UserIncome]
ON [dbo].[Incomes]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'Expenses'
ALTER TABLE [dbo].[Expenses]
ADD CONSTRAINT [FK_UserExpense]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserExpense'
CREATE INDEX [IX_FK_UserExpense]
ON [dbo].[Expenses]
    ([UserId]);
GO

-- Creating foreign key on [ContactId] in table 'Incomes'
ALTER TABLE [dbo].[Incomes]
ADD CONSTRAINT [FK_ContactIncome]
    FOREIGN KEY ([ContactId])
    REFERENCES [dbo].[Contacts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ContactIncome'
CREATE INDEX [IX_FK_ContactIncome]
ON [dbo].[Incomes]
    ([ContactId]);
GO

-- Creating foreign key on [ContactId] in table 'Expenses'
ALTER TABLE [dbo].[Expenses]
ADD CONSTRAINT [FK_ContactExpense]
    FOREIGN KEY ([ContactId])
    REFERENCES [dbo].[Contacts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ContactExpense'
CREATE INDEX [IX_FK_ContactExpense]
ON [dbo].[Expenses]
    ([ContactId]);
GO

-- Creating foreign key on [UserId] in table 'Assets'
ALTER TABLE [dbo].[Assets]
ADD CONSTRAINT [FK_UserAsset]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserAsset'
CREATE INDEX [IX_FK_UserAsset]
ON [dbo].[Assets]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'Liabilities'
ALTER TABLE [dbo].[Liabilities]
ADD CONSTRAINT [FK_UserLiability]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserLiability'
CREATE INDEX [IX_FK_UserLiability]
ON [dbo].[Liabilities]
    ([UserId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------