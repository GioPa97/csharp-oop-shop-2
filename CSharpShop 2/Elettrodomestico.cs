﻿namespace CSharpShop_2
{
    public class Elettrodomestico : prodotto
    {
        //Attributi/proprietà
        private string condizione;
        //Getter
        public string Getcondizione()
        {
            return condizione;
        }

        public bool Getacceso()
        {
            return acceso;
        }
        //Setter
        public void Setcondizione(string condizione)
        {
            this.condizione = condizione;
        }
        public void Setacceso(bool acceso)
        {
            this.acceso = acceso;
        }
        //Costruttori
        public Elettrodomestico(string nome, string descrizione, string condizione, double prezzo, float iva) : base(nome, descrizione, prezzo, iva)
        {
            this.condizione = condizione;

        }
        //stato
        private bool acceso = false;
        //Metodi
        public void AccendiElettrodomestico()
        {
            if (this.acceso=false)
            {
                Setacceso(true);
                Console.WriteLine("In funzione!");
            }
            else
            {
                Console.WriteLine("Gia acceso!");
            }
        }

        public override void stampaProdotto()
        {
            base.stampaProdotto();
            if (Getacceso())
            {
                Console.WriteLine("Prodotto testato!");
            }
            else
            {
                Console.WriteLine("Prodotto mai acceso!");
            }
        }
    }


}
