CREATE TABLE [dbo].[PickUpAttributeStatus]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Type] VARCHAR(50) NULL, 
    [Value] VARCHAR(50) NULL, 
    [Status] BIT NULL, 
    [TrucksMonitorId] INT NULL,
	CONSTRAINT [FK_PickUpAttributeStatus_TrucksMonitor] FOREIGN KEY (TrucksMonitorId) REFERENCES TrucksMonitor(Id) 
)
