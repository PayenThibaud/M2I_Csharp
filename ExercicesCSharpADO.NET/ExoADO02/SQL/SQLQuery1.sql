CREATE DATABASE gestionDesCommandes;
GO

CREATE TABLE [dbo].[Client]
(
    [ID] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [Nom] VARCHAR(50) NOT NULL,
    [Prenom] VARCHAR(50) NOT NULL,
    [Adresse] VARCHAR(100) NOT NULL,
    [CodePostal] VARCHAR(20) NOT NULL,
    [Ville] VARCHAR(50) NOT NULL,
    [Telephone] VARCHAR(20) NOT NULL
);
GO


CREATE TABLE [dbo].[Commandes]
(
    [ID] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [ClientID] INT NOT NULL,
    [Date] DATE NOT NULL,
    [Total] DECIMAL(10, 2) NOT NULL,
    CONSTRAINT FK_Client_Commandes_ClientID FOREIGN KEY([ClientID]) REFERENCES Client(ID)
);
GO

