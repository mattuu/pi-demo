﻿CREATE TABLE [dbo].[Items]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	[Name] VARCHAR(1000) NOT NULL,
	[Description] VARCHAR(MAX) NULL
)
