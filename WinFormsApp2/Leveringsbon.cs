namespace Groep_project_2
{
    internal class Leveringsbon
    {
        private string _naamBedrijf = "Grondstoffen.Base()";
        private string _naam;
        private int _aantal;
        private double _eenheidsprijs;
        private double _totaalPrijsGrondstof;
        private string _varia;

        public Leveringsbon() { }
        public Leveringsbon(string eenGrondstofNaam, int eenAantal, double eenEenheidsprijsGrondstof, double eenTotaalBedragGrondstof, string? eenBericht)
        {

            Naam = eenGrondstofNaam;
            Aantal = eenAantal;
            Eenheidsprijs = eenEenheidsprijsGrondstof;
            TotaalBedragGrondstof = eenTotaalBedragGrondstof;
            Bericht = eenBericht;

        }

        public string Bedrijfsnaam
        {
            get { return _naamBedrijf; }
            set { _naamBedrijf = value; }
        }
        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }
        public int Aantal
        {
            get { return _aantal; }
            set { _aantal = value; }
        }
        public double Eenheidsprijs
        {
            get { return _eenheidsprijs; }
            set { _eenheidsprijs = value; }
        }
        public double TotaalBedragGrondstof
        {
            get { return _totaalPrijsGrondstof; }
            set { _totaalPrijsGrondstof = value; }
        }
        public string Bericht
        {
            get { return _varia; }
            set { _varia = value; }
        }
    }
}

