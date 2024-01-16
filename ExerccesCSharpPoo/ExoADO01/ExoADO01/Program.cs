using Azure.Core;
using ExoADO01.Class;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using static System.Net.Mime.MediaTypeNames;


string connectionString = "Data Source=(localdb)\\DDB_ExoADO01; Initial Catalog = contactDB; Integrated Security = True; Connect Timeout = 30; Encrypt = True; Trust Server Certificate=False; Application Intent = ReadWrite; Multi Subnet Failover=False";

GestionEtudiants gestionEtudiants = new GestionEtudiants(connectionString);

//gestionEtudiants.CreerEtudiant();

gestionEtudiants.AfficherTousEtudiants();

gestionEtudiants.AfficherEtudiantsClasse();

gestionEtudiants.SupprimerEtudiant();

