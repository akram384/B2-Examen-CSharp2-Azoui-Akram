using MyApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp
{
    public class Commune
    {
        public string Nom { get; set; }
        public int CodePost;
        public int NbHab;

        public List<Departement> Departements { get; set; }
    }
}
