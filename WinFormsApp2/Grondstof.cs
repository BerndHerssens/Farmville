namespace WinFormsApp2
{
    internal class Grondstof
    {
        private int _hoeveelheidInStock;
        private int _minimumStock;
        private string _naam;
        //private DateTime _vervaldatum;
        private double _verkoopPrijs;



        public Grondstof() //basic
        { }
        public Grondstof(string eenNaam, int eenHoeveelheid, double eenPrijs) //voor aanvullen en verminderen
        {
            Naam = eenNaam;
            Aantal = eenHoeveelheid;
            Prijs = eenPrijs;
        }
        //public Grondstof(int eenHoeveelheid, string eenNaam, int eenVerkoopPrijs, DateTime eenVervaldatum) //voor aanvullen en verminderen met een verval datum
        //{
        //    Hoeveelheid = eenHoeveelheid;
        //    Naam = eenNaam;
        //    VerkoopPrijs = eenVerkoopPrijs;
        //    VervalDatum = eenVervaldatum;
        //}
        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }
        public int Aantal
        {
            get { return _hoeveelheidInStock; }
            set { _hoeveelheidInStock = value; }
        }
        //public int MinimumStock ////WORDT NOG AANGEPAST
        //{
        //    get { return _minimumStock; }
        //    set { _minimumStock = value; }
        //} 

        //public DateTime VervalDatum
        //{
        //    get { return _vervaldatum; }
        //    set { 
        //        if (value.CompareTo(DateTime.Now) <= 30)
        //        {
        //          _vervaldatum = value;
        //        }
        //        {
        //          _vervaldatum = value;
        //        }
        //    }
        //}
        public double Prijs
        {
            get { return _verkoopPrijs; }
            set
            {
                _verkoopPrijs = value;
            }
        }
        public void AanvullenStock(int aantal)
        {
            Aantal += aantal;
        }
        public void VerminderenStock(int aantal)
        { Aantal -= aantal; }
        public double Berekenprijs(int aantal)
        {
            double totaalprijs = aantal * Prijs;
            return totaalprijs;
        }
    }
}
