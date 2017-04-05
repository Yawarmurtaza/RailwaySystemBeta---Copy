
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/03/2017 21:18:01
-- Generated from EDMX file: C:\Users\Daniel\Desktop\RailwaySystemBackup - Copy\ServerWCF\RailwaySystemModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [RailwaySystem];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Admin_inherits_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users_Admin] DROP CONSTRAINT [FK_Admin_inherits_User];
GO
IF OBJECT_ID(N'[dbo].[FK_Passenger_inherits_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users_Passenger] DROP CONSTRAINT [FK_Passenger_inherits_User];
GO
IF OBJECT_ID(N'[dbo].[FK_PassengerBooking]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bookings] DROP CONSTRAINT [FK_PassengerBooking];
GO
IF OBJECT_ID(N'[dbo].[FK_TrackBooking]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bookings] DROP CONSTRAINT [FK_TrackBooking];
GO
IF OBJECT_ID(N'[dbo].[FK_TrackStation_Station]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TrackStation] DROP CONSTRAINT [FK_TrackStation_Station];
GO
IF OBJECT_ID(N'[dbo].[FK_TrackStation_Track]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TrackStation] DROP CONSTRAINT [FK_TrackStation_Track];
GO
IF OBJECT_ID(N'[dbo].[FK_TrainTrack_Track]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TrainTrack] DROP CONSTRAINT [FK_TrainTrack_Track];
GO
IF OBJECT_ID(N'[dbo].[FK_TrainTrack_Train]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TrainTrack] DROP CONSTRAINT [FK_TrainTrack_Train];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Bookings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bookings];
GO
IF OBJECT_ID(N'[dbo].[Stations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Stations];
GO
IF OBJECT_ID(N'[dbo].[Tracks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tracks];
GO
IF OBJECT_ID(N'[dbo].[TrackStation]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TrackStation];
GO
IF OBJECT_ID(N'[dbo].[Trains]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Trains];
GO
IF OBJECT_ID(N'[dbo].[TrainTrack]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TrainTrack];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[Users_Admin]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users_Admin];
GO
IF OBJECT_ID(N'[dbo].[Users_Passenger]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users_Passenger];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Trains'
CREATE TABLE [dbo].[Trains] (
    [TrainId] int IDENTITY(1,1) NOT NULL,
    [Model] nvarchar(max)  NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [Capacity] int  NOT NULL
);
GO

-- Creating table 'Stations'
CREATE TABLE [dbo].[Stations] (
    [StationId] int IDENTITY(1,1) NOT NULL,
    [City] nvarchar(max)  NOT NULL,
    [Type] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Tracks'
CREATE TABLE [dbo].[Tracks] (
    [TrackId] int IDENTITY(1,1) NOT NULL,
    [FromStation] nvarchar(max)  NOT NULL,
    [ToStation] nvarchar(max)  NOT NULL,
    [TimeToLeave] nvarchar(max)  NOT NULL,
    [TimeToArrive] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Price] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [UserId] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Username] nvarchar(max)  NOT NULL,
    [Age] int  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Bookings'
CREATE TABLE [dbo].[Bookings] (
    [BookingId] int IDENTITY(1,1) NOT NULL,
    [Time] nvarchar(max)  NOT NULL,
    [PassengerUserId] int  NOT NULL,
    [Number] nvarchar(max)  NOT NULL,
    [TrackTrackId] int  NOT NULL,
    [Price] nvarchar(max)  NOT NULL,
    [Passenger_UserId] int  NOT NULL,
    [Track_TrackId] int  NOT NULL
);
GO

-- Creating table 'Users_Passenger'
CREATE TABLE [dbo].[Users_Passenger] (
    [PassengerId] int IDENTITY(1,1) NOT NULL,
    [UserId] int  NOT NULL
);
GO

-- Creating table 'Users_Admin'
CREATE TABLE [dbo].[Users_Admin] (
    [AdminId] int IDENTITY(1,1) NOT NULL,
    [UserId] int  NOT NULL
);
GO

-- Creating table 'TrainTrack'
CREATE TABLE [dbo].[TrainTrack] (
    [Trains_TrainId] int  NOT NULL,
    [Tracks_TrackId] int  NOT NULL
);
GO

-- Creating table 'TrackStation'
CREATE TABLE [dbo].[TrackStation] (
    [Tracks_TrackId] int  NOT NULL,
    [Stations_StationId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [TrainId] in table 'Trains'
ALTER TABLE [dbo].[Trains]
ADD CONSTRAINT [PK_Trains]
    PRIMARY KEY CLUSTERED ([TrainId] ASC);
GO

-- Creating primary key on [StationId] in table 'Stations'
ALTER TABLE [dbo].[Stations]
ADD CONSTRAINT [PK_Stations]
    PRIMARY KEY CLUSTERED ([StationId] ASC);
GO

-- Creating primary key on [TrackId] in table 'Tracks'
ALTER TABLE [dbo].[Tracks]
ADD CONSTRAINT [PK_Tracks]
    PRIMARY KEY CLUSTERED ([TrackId] ASC);
GO

-- Creating primary key on [UserId] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- Creating primary key on [BookingId] in table 'Bookings'
ALTER TABLE [dbo].[Bookings]
ADD CONSTRAINT [PK_Bookings]
    PRIMARY KEY CLUSTERED ([BookingId] ASC);
GO

-- Creating primary key on [UserId] in table 'Users_Passenger'
ALTER TABLE [dbo].[Users_Passenger]
ADD CONSTRAINT [PK_Users_Passenger]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- Creating primary key on [UserId] in table 'Users_Admin'
ALTER TABLE [dbo].[Users_Admin]
ADD CONSTRAINT [PK_Users_Admin]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- Creating primary key on [Trains_TrainId], [Tracks_TrackId] in table 'TrainTrack'
ALTER TABLE [dbo].[TrainTrack]
ADD CONSTRAINT [PK_TrainTrack]
    PRIMARY KEY CLUSTERED ([Trains_TrainId], [Tracks_TrackId] ASC);
GO

-- Creating primary key on [Tracks_TrackId], [Stations_StationId] in table 'TrackStation'
ALTER TABLE [dbo].[TrackStation]
ADD CONSTRAINT [PK_TrackStation]
    PRIMARY KEY CLUSTERED ([Tracks_TrackId], [Stations_StationId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Trains_TrainId] in table 'TrainTrack'
ALTER TABLE [dbo].[TrainTrack]
ADD CONSTRAINT [FK_TrainTrack_Train]
    FOREIGN KEY ([Trains_TrainId])
    REFERENCES [dbo].[Trains]
        ([TrainId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Tracks_TrackId] in table 'TrainTrack'
ALTER TABLE [dbo].[TrainTrack]
ADD CONSTRAINT [FK_TrainTrack_Track]
    FOREIGN KEY ([Tracks_TrackId])
    REFERENCES [dbo].[Tracks]
        ([TrackId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TrainTrack_Track'
CREATE INDEX [IX_FK_TrainTrack_Track]
ON [dbo].[TrainTrack]
    ([Tracks_TrackId]);
GO

-- Creating foreign key on [Tracks_TrackId] in table 'TrackStation'
ALTER TABLE [dbo].[TrackStation]
ADD CONSTRAINT [FK_TrackStation_Track]
    FOREIGN KEY ([Tracks_TrackId])
    REFERENCES [dbo].[Tracks]
        ([TrackId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Stations_StationId] in table 'TrackStation'
ALTER TABLE [dbo].[TrackStation]
ADD CONSTRAINT [FK_TrackStation_Station]
    FOREIGN KEY ([Stations_StationId])
    REFERENCES [dbo].[Stations]
        ([StationId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TrackStation_Station'
CREATE INDEX [IX_FK_TrackStation_Station]
ON [dbo].[TrackStation]
    ([Stations_StationId]);
GO

-- Creating foreign key on [Passenger_UserId] in table 'Bookings'
ALTER TABLE [dbo].[Bookings]
ADD CONSTRAINT [FK_PassengerBooking]
    FOREIGN KEY ([Passenger_UserId])
    REFERENCES [dbo].[Users_Passenger]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PassengerBooking'
CREATE INDEX [IX_FK_PassengerBooking]
ON [dbo].[Bookings]
    ([Passenger_UserId]);
GO

-- Creating foreign key on [Track_TrackId] in table 'Bookings'
ALTER TABLE [dbo].[Bookings]
ADD CONSTRAINT [FK_TrackBooking]
    FOREIGN KEY ([Track_TrackId])
    REFERENCES [dbo].[Tracks]
        ([TrackId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TrackBooking'
CREATE INDEX [IX_FK_TrackBooking]
ON [dbo].[Bookings]
    ([Track_TrackId]);
GO

-- Creating foreign key on [UserId] in table 'Users_Passenger'
ALTER TABLE [dbo].[Users_Passenger]
ADD CONSTRAINT [FK_Passenger_inherits_User]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [UserId] in table 'Users_Admin'
ALTER TABLE [dbo].[Users_Admin]
ADD CONSTRAINT [FK_Admin_inherits_User]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------