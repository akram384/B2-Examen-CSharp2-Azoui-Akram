using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Model
{
    class Region
    {
        public string nom;
        public int code;
        public List<Departement> Departements { get; set; }
    }
}
