﻿CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	Email VARCHAR(50) NOT NULL,
	Nickname VARCHAR(50) NOT NULL,
	[Password] VARCHAR(100) NOT NULL
)