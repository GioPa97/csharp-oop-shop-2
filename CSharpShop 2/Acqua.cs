namespace CSharpShop_2
{
    internal class Acqua : prodotto
    {

        //Attributi/proprietà
        uint litri;
        int ph;
        string sorgente;
        //getter
        public uint Getlitri()
        {
            return litri;
        }
        public int Getph()
        {
            return ph;
        }
        public string Getsorgente()
        {
            return sorgente;
        }
        //setter
        public void Setlitri(uint litri)
        {
            this.litri = litri;
        }




        //Costruttori
        public Acqua(string nome, string descrizione, double prezzo, float iva, uint litri, int ph, string sorgente) : base(nome, descrizione, prezzo, iva)
        {
            this.litri = litri;
            this.ph = ph;
            this.sorgente = sorgente;
        }
    }
}
