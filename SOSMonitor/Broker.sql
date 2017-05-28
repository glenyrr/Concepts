CREATE TABLE [dbo].[Broker]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NULL, 
    [PhoneNumber] VARCHAR(50) NULL, 
    [TrucksMonitorId] INT NULL,
	CONSTRAINT [FK_Broker_TrucksMonitor] FOREIGN KEY (TrucksMonitorId) REFERENCES TrucksMonitor(Id) 

)
