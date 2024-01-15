CREATE DATABASE Bdd_Ado
GO
 
-- On se positionne dans la data base
USE Bdd_Ado;
GO
 
-- Creatuion de la table personne
CREATE TABLE personne (
id INT IDENTITY (1,1) PRIMARY KEY,
prenom VARCHAR(50) NOT NULL,
nom	VARCHAR(50) NOT NULL,
email VARCHAR (255) NOT NULL 
);
GO
 
-- ajout d'un enregistrmeent dans la table
INSERT INTO personne(prenom, nom, email)
VALUES ('toto', 'titi', 'toto@titi.fr');
GO
 
