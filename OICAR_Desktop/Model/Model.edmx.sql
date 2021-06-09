
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/03/2021 19:09:40
-- Generated from EDMX file: C:\Users\IgorKvakan\Desktop\OICAR_Desktop\OICAR_Desktop\Model\Model.edmx
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

IF OBJECT_ID(N'[dbo].[FK_ClientAppointment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Appointment] DROP CONSTRAINT [FK_ClientAppointment];
GO
IF OBJECT_ID(N'[dbo].[FK_Service_TypeService]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Service] DROP CONSTRAINT [FK_Service_TypeService];
GO
IF OBJECT_ID(N'[dbo].[FK_ServiceAppointment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Appointment] DROP CONSTRAINT [FK_ServiceAppointment];
GO
IF OBJECT_ID(N'[dbo].[FK_StatusAppointment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Appointment] DROP CONSTRAINT [FK_StatusAppointment];
GO
IF OBJECT_ID(N'[dbo].[FK_WorkerAppointment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Appointment] DROP CONSTRAINT [FK_WorkerAppointment];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Appointment]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Appointment];
GO
IF OBJECT_ID(N'[dbo].[Client]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Client];
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
IF OBJECT_ID(N'[dbo].[Worker]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Worker];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Service_Type'
CREATE TABLE [dbo].[Service_Type] (
    [IdServiceType] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
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
    [Contact] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Appointment'
CREATE TABLE [dbo].[Appointment] (
    [IdAppointment] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NOT NULL,
    [Time] datetime  NOT NULL,
    [Duration] int  NOT NULL,
    [Remark] nvarchar(max)  NULL,
    [WorkerIdWorker] int  NOT NULL,
    [ClientIdClient] int  NOT NULL,
    [ServiceIdService] int  NOT NULL,
    [StatusIdStatus] int  NOT NULL
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
    [City] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Status'
CREATE TABLE [dbo].[Status] (
    [IdStatus] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
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

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [WorkerIdWorker] in table 'Appointment'
ALTER TABLE [dbo].[Appointment]
ADD CONSTRAINT [FK_WorkerAppointment]
    FOREIGN KEY ([WorkerIdWorker])
    REFERENCES [dbo].[Worker]
        ([IdWorker])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_WorkerAppointment'
CREATE INDEX [IX_FK_WorkerAppointment]
ON [dbo].[Appointment]
    ([WorkerIdWorker]);
GO

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

-- Creating foreign key on [ServiceIdService] in table 'Appointment'
ALTER TABLE [dbo].[Appointment]
ADD CONSTRAINT [FK_ServiceAppointment]
    FOREIGN KEY ([ServiceIdService])
    REFERENCES [dbo].[Service]
        ([IdService])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ServiceAppointment'
CREATE INDEX [IX_FK_ServiceAppointment]
ON [dbo].[Appointment]
    ([ServiceIdService]);
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

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------