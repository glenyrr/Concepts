CREATE TABLE [dbo].[TrucksMonitor]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [LoadNumber] INT NULL, 
    [Invoice] VARCHAR(50) NULL, 
    [Date] DATETIME NULL, 
    [TruckNumber] VARCHAR(50) NULL, 
    [TrailerNumber] VARCHAR(50) NULL, 
    [Customer] VARCHAR(80) NULL, 
    [CustomerReference] VARCHAR(50) NULL, 
    [BaseCity] VARCHAR(50) NULL, 
    [FileNumber] VARCHAR(50) NULL, 
    [From] VARCHAR(50) NULL, 
    [To] VARCHAR(50) NULL, 
    [TruckOwner] VARCHAR(50) NULL, 
    [Dispatcher] VARCHAR(50) NULL, 
    [DriverId] INT NULL, 
    [BrokerId] INT NULL, 
    [PickUpId] INT NULL, 
    [LoadId] INT NULL, 
    [DeliveryId] INT NULL
)
