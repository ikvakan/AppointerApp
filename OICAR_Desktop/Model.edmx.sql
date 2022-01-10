
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/18/2021 14:44:15
-- Generated from EDMX file: C:\Users\IgorKvakan\source\repos\OICAR_Desktop\OICAR_Desktop\Model.edmx
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

IF OBJECT_ID(N'[dbo].[FK_ServiceService_Type]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Service_Type] DROP CONSTRAINT [FK_ServiceService_Type];
GO
IF OBJECT_ID(N'[dbo].[FK_AppointmentService]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Service] DROP CONSTRAINT [FK_AppointmentService];
GO
IF OBJECT_ID(N'[dbo].[FK_ServiceSpecialization]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Specialization] DROP CONSTRAINT [FK_ServiceSpecialization];
GO
IF OBJECT_ID(N'[dbo].[FK_WorkerSpecialization]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Specialization] DROP CONSTRAINT [FK_WorkerSpecialization];
GO
IF OBJECT_ID(N'[dbo].[FK_WorkerAppointment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Appointment] DROP CONSTRAINT [FK_WorkerAppointment];
GO
IF OBJECT_ID(N'[dbo].[FK_ClientAppointment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Appointment] DROP CONSTRAINT [FK_ClientAppointment];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Service_Type]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Service_Type];
GO
IF OBJECT_ID(N'[dbo].[Service]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Service];
GO
IF OBJECT_ID(N'[dbo].[Specialization]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Specialization];
GO
IF OBJECT_ID(N'[dbo].[Worker]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Worker];
GO
IF OBJECT_ID(N'[dbo].[Appointment]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Appointment];
GO
IF OBJECT_ID(N'[dbo].[Client]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Client];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Service_Type'
CREATE TABLE [dbo].[Service_Type] (
    [IdServiceType] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [ServiceIdService] int  NOT NULL
);
GO

-- Creating table 'Service'
CREATE TABLE [dbo].[Service] (
    [IdService] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Price] int  NOT NULL,
    [Duration] int  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [AppointmentIdAppointment] int  NOT NULL
);
GO

-- Creating table 'Specialization'
CREATE TABLE [dbo].[Specialization] (
    [IdSpecialization] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [ServiceIdService] int  NOT NULL,
    [WorkerIdWorker] int  NOT NULL
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
    [Time] int  NOT NULL,
    [Duration] int  NOT NULL,
    [Status] nvarchar(max)  NOT NULL,
    [Remark] nvarchar(max)  NULL,
    [WorkerIdWorker] int  NOT NULL,
    [ClientIdClient] int  NOT NULL
);
GO

-- Creating table 'Client'
CREATE TABLE [dbo].[Client] (
    [IdClient] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Surname] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Contact] nvarchar(max)  NOT NULL,
    [Adress] nvarchar(max)  NOT NULL,
    [OIB] nvarchar(max)  NULL,
    [City] nvarchar(max)  NOT NULL
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

-- Creating primary key on [IdSpecialization] in table 'Specialization'
ALTER TABLE [dbo].[Specialization]
ADD CONSTRAINT [PK_Specialization]
    PRIMARY KEY CLUSTERED ([IdSpecialization] ASC);
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

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ServiceIdService] in table 'Service_Type'
ALTER TABLE [dbo].[Service_Type]
ADD CONSTRAINT [FK_ServiceService_Type]
    FOREIGN KEY ([ServiceIdService])
    REFERENCES [dbo].[Service]
        ([IdService])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ServiceService_Type'
CREATE INDEX [IX_FK_ServiceService_Type]
ON [dbo].[Service_Type]
    ([ServiceIdService]);
GO

-- Creating foreign key on [AppointmentIdAppointment] in table 'Service'
ALTER TABLE [dbo].[Service]
ADD CONSTRAINT [FK_AppointmentService]
    FOREIGN KEY ([AppointmentIdAppointment])
    REFERENCES [dbo].[Appointment]
        ([IdAppointment])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AppointmentService'
CREATE INDEX [IX_FK_AppointmentService]
ON [dbo].[Service]
    ([AppointmentIdAppointment]);
GO

-- Creating foreign key on [ServiceIdService] in table 'Specialization'
ALTER TABLE [dbo].[Specialization]
ADD CONSTRAINT [FK_ServiceSpecialization]
    FOREIGN KEY ([ServiceIdService])
    REFERENCES [dbo].[Service]
        ([IdService])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ServiceSpecialization'
CREATE INDEX [IX_FK_ServiceSpecialization]
ON [dbo].[Specialization]
    ([ServiceIdService]);
GO

-- Creating foreign key on [WorkerIdWorker] in table 'Specialization'
ALTER TABLE [dbo].[Specialization]
ADD CONSTRAINT [FK_WorkerSpecialization]
    FOREIGN KEY ([WorkerIdWorker])
    REFERENCES [dbo].[Worker]
        ([IdWorker])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_WorkerSpecialization'
CREATE INDEX [IX_FK_WorkerSpecialization]
ON [dbo].[Specialization]
    ([WorkerIdWorker]);
GO

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

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------