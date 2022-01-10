
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/16/2021 15:21:23
-- Generated from EDMX file: C:\Users\IgorKvakan\Desktop\OICAR_App\ClassLibrary\Model\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [OICAR_DB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CategoryCompany]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Company] DROP CONSTRAINT [FK_CategoryCompany];
GO
IF OBJECT_ID(N'[dbo].[FK_ClientAppointment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Appointment] DROP CONSTRAINT [FK_ClientAppointment];
GO
IF OBJECT_ID(N'[dbo].[FK_ClientGDPRClient]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Client] DROP CONSTRAINT [FK_ClientGDPRClient];
GO
IF OBJECT_ID(N'[dbo].[FK_ClientLoginsClient]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Client] DROP CONSTRAINT [FK_ClientLoginsClient];
GO
IF OBJECT_ID(N'[dbo].[FK_CompanyAppointment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Appointment] DROP CONSTRAINT [FK_CompanyAppointment];
GO
IF OBJECT_ID(N'[dbo].[FK_CompanyLoginCompany]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Company] DROP CONSTRAINT [FK_CompanyLoginCompany];
GO
IF OBJECT_ID(N'[dbo].[FK_CompanyService_Type]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Service_Type] DROP CONSTRAINT [FK_CompanyService_Type];
GO
IF OBJECT_ID(N'[dbo].[FK_CompanyWorker]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Worker] DROP CONSTRAINT [FK_CompanyWorker];
GO
IF OBJECT_ID(N'[dbo].[FK_CompanyWorking_Hours]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Working_Hours] DROP CONSTRAINT [FK_CompanyWorking_Hours];
GO
IF OBJECT_ID(N'[dbo].[FK_Service_TypeService]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Service] DROP CONSTRAINT [FK_Service_TypeService];
GO
IF OBJECT_ID(N'[dbo].[FK_StatusAppointment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Appointment] DROP CONSTRAINT [FK_StatusAppointment];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Appointment]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Appointment];
GO
IF OBJECT_ID(N'[dbo].[Category]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Category];
GO
IF OBJECT_ID(N'[dbo].[Client]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Client];
GO
IF OBJECT_ID(N'[dbo].[ClientGDPR]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClientGDPR];
GO
IF OBJECT_ID(N'[dbo].[ClientLogin]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClientLogin];
GO
IF OBJECT_ID(N'[dbo].[Company]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Company];
GO
IF OBJECT_ID(N'[dbo].[CompanyLogin]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CompanyLogin];
GO
IF OBJECT_ID(N'[dbo].[Service]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Service];
GO
IF OBJECT_ID(N'[dbo].[Service_Type]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Service_Type];
GO
IF OBJECT_ID(N'[dbo].[Status]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Status];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[Worker]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Worker];
GO
IF OBJECT_ID(N'[dbo].[Working_Hours]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Working_Hours];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Service_Type'
CREATE TABLE [dbo].[Service_Type] (
    [IdServiceType] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [CompanyIdCompany] int  NOT NULL
);
GO

-- Creating table 'Service'
CREATE TABLE [dbo].[Service] (
    [IdService] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Price] int  NOT NULL,
    [Duration] int  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [Service_TypeIdServiceType] int  NOT NULL
);
GO

-- Creating table 'Worker'
CREATE TABLE [dbo].[Worker] (
    [IdWorker] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Surname] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Contact] nvarchar(max)  NOT NULL,
    [CompanyIdCompany] int  NOT NULL
);
GO

-- Creating table 'Appointment'
CREATE TABLE [dbo].[Appointment] (
    [IdAppointment] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NOT NULL,
    [Time] datetime  NOT NULL,
    [Duration] int  NOT NULL,
    [Remark] nvarchar(max)  NULL,
    [ClientIdClient] int  NOT NULL,
    [StatusIdStatus] int  NOT NULL,
    [CompanyIdCompany] int  NOT NULL
);
GO

-- Creating table 'Client'
CREATE TABLE [dbo].[Client] (
    [IdClient] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Surname] nvarchar(50)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Contact] nvarchar(50)  NOT NULL,
    [Adress] nvarchar(100)  NOT NULL,
    [OIB] nvarchar(max)  NOT NULL,
    [City] nvarchar(max)  NOT NULL,
    [ClientLoginsIdClientLogin] int  NOT NULL,
    [ClientGDPRIdClientGDPR] int  NOT NULL
);
GO

-- Creating table 'Status'
CREATE TABLE [dbo].[Status] (
    [IdStatus] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Company'
CREATE TABLE [dbo].[Company] (
    [IdCompany] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Adress] nvarchar(max)  NOT NULL,
    [City] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Contact] nvarchar(max)  NOT NULL,
    [PicPath] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [CategoryIdCategory] int  NOT NULL,
    [CompanyLoginIdCompanyLogin] int  NOT NULL
);
GO

-- Creating table 'Working_Hours'
CREATE TABLE [dbo].[Working_Hours] (
    [IdWorkingHours] int IDENTITY(1,1) NOT NULL,
    [Day] nvarchar(max)  NOT NULL,
    [Start_Time] datetime  NOT NULL,
    [End_Time] datetime  NOT NULL,
    [Is_NonWorking] bit  NOT NULL,
    [CompanyIdCompany] int  NOT NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'Category'
CREATE TABLE [dbo].[Category] (
    [IdCategory] int IDENTITY(1,1) NOT NULL,
    [CategoryName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ClientLogin'
CREATE TABLE [dbo].[ClientLogin] (
    [IdClientLogin] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CompanyLogin'
CREATE TABLE [dbo].[CompanyLogin] (
    [IdCompanyLogin] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Surname] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Contact] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [UserName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ClientGDPR'
CREATE TABLE [dbo].[ClientGDPR] (
    [IdClientGDPR] int IDENTITY(1,1) NOT NULL,
    [AuthorizePersonalInformation] bit  NOT NULL,
    [TargetedAdvertisement] bit  NOT NULL,
    [AccessDeviceData] bit  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdServiceType] in table 'Service_Type'
ALTER TABLE [dbo].[Service_Type]
ADD CONSTRAINT [PK_Service_Type]
    PRIMARY KEY CLUSTERED ([IdServiceType] ASC);
GO

-- Creating primary key on [IdService] in table 'Service'
ALTER TABLE [dbo].[Service]
ADD CONSTRAINT [PK_Service]
    PRIMARY KEY CLUSTERED ([IdService] ASC);
GO

-- Creating primary key on [IdWorker] in table 'Worker'
ALTER TABLE [dbo].[Worker]
ADD CONSTRAINT [PK_Worker]
    PRIMARY KEY CLUSTERED ([IdWorker] ASC);
GO

-- Creating primary key on [IdAppointment] in table 'Appointment'
ALTER TABLE [dbo].[Appointment]
ADD CONSTRAINT [PK_Appointment]
    PRIMARY KEY CLUSTERED ([IdAppointment] ASC);
GO

-- Creating primary key on [IdClient] in table 'Client'
ALTER TABLE [dbo].[Client]
ADD CONSTRAINT [PK_Client]
    PRIMARY KEY CLUSTERED ([IdClient] ASC);
GO

-- Creating primary key on [IdStatus] in table 'Status'
ALTER TABLE [dbo].[Status]
ADD CONSTRAINT [PK_Status]
    PRIMARY KEY CLUSTERED ([IdStatus] ASC);
GO

-- Creating primary key on [IdCompany] in table 'Company'
ALTER TABLE [dbo].[Company]
ADD CONSTRAINT [PK_Company]
    PRIMARY KEY CLUSTERED ([IdCompany] ASC);
GO

-- Creating primary key on [IdWorkingHours] in table 'Working_Hours'
ALTER TABLE [dbo].[Working_Hours]
ADD CONSTRAINT [PK_Working_Hours]
    PRIMARY KEY CLUSTERED ([IdWorkingHours] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [IdCategory] in table 'Category'
ALTER TABLE [dbo].[Category]
ADD CONSTRAINT [PK_Category]
    PRIMARY KEY CLUSTERED ([IdCategory] ASC);
GO

-- Creating primary key on [IdClientLogin] in table 'ClientLogin'
ALTER TABLE [dbo].[ClientLogin]
ADD CONSTRAINT [PK_ClientLogin]
    PRIMARY KEY CLUSTERED ([IdClientLogin] ASC);
GO

-- Creating primary key on [IdCompanyLogin] in table 'CompanyLogin'
ALTER TABLE [dbo].[CompanyLogin]
ADD CONSTRAINT [PK_CompanyLogin]
    PRIMARY KEY CLUSTERED ([IdCompanyLogin] ASC);
GO

-- Creating primary key on [IdClientGDPR] in table 'ClientGDPR'
ALTER TABLE [dbo].[ClientGDPR]
ADD CONSTRAINT [PK_ClientGDPR]
    PRIMARY KEY CLUSTERED ([IdClientGDPR] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ClientIdClient] in table 'Appointment'
ALTER TABLE [dbo].[Appointment]
ADD CONSTRAINT [FK_ClientAppointment]
    FOREIGN KEY ([ClientIdClient])
    REFERENCES [dbo].[Client]
        ([IdClient])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientAppointment'
CREATE INDEX [IX_FK_ClientAppointment]
ON [dbo].[Appointment]
    ([ClientIdClient]);
GO

-- Creating foreign key on [StatusIdStatus] in table 'Appointment'
ALTER TABLE [dbo].[Appointment]
ADD CONSTRAINT [FK_StatusAppointment]
    FOREIGN KEY ([StatusIdStatus])
    REFERENCES [dbo].[Status]
        ([IdStatus])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StatusAppointment'
CREATE INDEX [IX_FK_StatusAppointment]
ON [dbo].[Appointment]
    ([StatusIdStatus]);
GO

-- Creating foreign key on [CompanyIdCompany] in table 'Working_Hours'
ALTER TABLE [dbo].[Working_Hours]
ADD CONSTRAINT [FK_CompanyWorking_Hours]
    FOREIGN KEY ([CompanyIdCompany])
    REFERENCES [dbo].[Company]
        ([IdCompany])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CompanyWorking_Hours'
CREATE INDEX [IX_FK_CompanyWorking_Hours]
ON [dbo].[Working_Hours]
    ([CompanyIdCompany]);
GO

-- Creating foreign key on [CategoryIdCategory] in table 'Company'
ALTER TABLE [dbo].[Company]
ADD CONSTRAINT [FK_CategoryCompany]
    FOREIGN KEY ([CategoryIdCategory])
    REFERENCES [dbo].[Category]
        ([IdCategory])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoryCompany'
CREATE INDEX [IX_FK_CategoryCompany]
ON [dbo].[Company]
    ([CategoryIdCategory]);
GO

-- Creating foreign key on [CompanyLoginIdCompanyLogin] in table 'Company'
ALTER TABLE [dbo].[Company]
ADD CONSTRAINT [FK_CompanyLoginCompany]
    FOREIGN KEY ([CompanyLoginIdCompanyLogin])
    REFERENCES [dbo].[CompanyLogin]
        ([IdCompanyLogin])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CompanyLoginCompany'
CREATE INDEX [IX_FK_CompanyLoginCompany]
ON [dbo].[Company]
    ([CompanyLoginIdCompanyLogin]);
GO

-- Creating foreign key on [ClientLoginsIdClientLogin] in table 'Client'
ALTER TABLE [dbo].[Client]
ADD CONSTRAINT [FK_ClientLoginsClient]
    FOREIGN KEY ([ClientLoginsIdClientLogin])
    REFERENCES [dbo].[ClientLogin]
        ([IdClientLogin])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientLoginsClient'
CREATE INDEX [IX_FK_ClientLoginsClient]
ON [dbo].[Client]
    ([ClientLoginsIdClientLogin]);
GO

-- Creating foreign key on [CompanyIdCompany] in table 'Worker'
ALTER TABLE [dbo].[Worker]
ADD CONSTRAINT [FK_CompanyWorker]
    FOREIGN KEY ([CompanyIdCompany])
    REFERENCES [dbo].[Company]
        ([IdCompany])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CompanyWorker'
CREATE INDEX [IX_FK_CompanyWorker]
ON [dbo].[Worker]
    ([CompanyIdCompany]);
GO

-- Creating foreign key on [CompanyIdCompany] in table 'Appointment'
ALTER TABLE [dbo].[Appointment]
ADD CONSTRAINT [FK_CompanyAppointment]
    FOREIGN KEY ([CompanyIdCompany])
    REFERENCES [dbo].[Company]
        ([IdCompany])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CompanyAppointment'
CREATE INDEX [IX_FK_CompanyAppointment]
ON [dbo].[Appointment]
    ([CompanyIdCompany]);
GO

-- Creating foreign key on [CompanyIdCompany] in table 'Service_Type'
ALTER TABLE [dbo].[Service_Type]
ADD CONSTRAINT [FK_CompanyService_Type]
    FOREIGN KEY ([CompanyIdCompany])
    REFERENCES [dbo].[Company]
        ([IdCompany])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CompanyService_Type'
CREATE INDEX [IX_FK_CompanyService_Type]
ON [dbo].[Service_Type]
    ([CompanyIdCompany]);
GO

-- Creating foreign key on [Service_TypeIdServiceType] in table 'Service'
ALTER TABLE [dbo].[Service]
ADD CONSTRAINT [FK_Service_TypeService]
    FOREIGN KEY ([Service_TypeIdServiceType])
    REFERENCES [dbo].[Service_Type]
        ([IdServiceType])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Service_TypeService'
CREATE INDEX [IX_FK_Service_TypeService]
ON [dbo].[Service]
    ([Service_TypeIdServiceType]);
GO

-- Creating foreign key on [ClientGDPRIdClientGDPR] in table 'Client'
ALTER TABLE [dbo].[Client]
ADD CONSTRAINT [FK_ClientGDPRClient]
    FOREIGN KEY ([ClientGDPRIdClientGDPR])
    REFERENCES [dbo].[ClientGDPR]
        ([IdClientGDPR])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientGDPRClient'
CREATE INDEX [IX_FK_ClientGDPRClient]
ON [dbo].[Client]
    ([ClientGDPRIdClientGDPR]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------