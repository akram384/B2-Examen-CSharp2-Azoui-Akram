﻿using MyApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Service
{
    public class DepartementService
    {
        private DemandeALutilisateur _demandeALutilisateur;

        public  DepartementService(DemandeALutilisateur demandealutilisateur)
        {
            this._demandeALutilisateur = demandealutilisateur;
            
        }
        public Departement ajouterDepartement()
        {
            Departement d = new Departement();
            d.nom = _demandeALutilisateur.saisieNom("Saisissez le nom de votre departement");
            d.code = _demandeALutilisateur.saisieEntier("Saisissez le code du departement");

            return d;
        }

        public void afficheDept(List<Departement> listdept)
        {
            Console.WriteLine("Departements:");
            foreach (Departement d in listdept)
            {
                string message = "Nom: " + d.nom + ", code: " + d.code;
                Console.WriteLine(message);
            }
        }

   
    }
 }
