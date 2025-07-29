using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STK2
{
    public class ZakladniInfo
    {
        public string znacka { get; set; }
        public string druh { get; set; }
        public string spz { get; set; }
        public string vin { get; set; }
        public DateTime prvni_registrace { get; set; }
        public string typ { get; set; }
        public string barva { get; set; }
    }
    public class StavSTK
    { 
        public string typSTK { get; set; }
        public DateTime posledniSTK { get; set; }
        public DateTime platnostSTK { get; set; }
        public DateTime platnostEmise { get; set; }
        public string vysledekSTK { get; set; }
        public string vysledekEmise { get; set; }
        public string poznamka { get; set; }

    }
    public class  TechnickeUdaje
    {
        public string rozmery { get; set; }
        public int hmotnost { get; set; }
        public int vykon { get; set; }
        public string palivo { get; set; }
        public string pohon { get; set; }
        public int pocetMist { get; set; }
        public string pneumatiky { get; set; }
    }
    public class  Majitel
    {
        public string jmeno_vlastnik { get; set; }
        public string provozovatel { get; set; }
        public string kontakt { get; set; }
        public string zmena_vlastnictvi { get; set; }
        public string poznamky { get; set; }
    }
    public class Nehody
    {
        public string zaznam { get; set; }
        public string poznamkykSTK { get; set; }
    }
}
