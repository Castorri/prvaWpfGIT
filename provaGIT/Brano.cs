using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provaGIT
{
    internal class Brano
    {
        //proprietà
        internal string Titolo { get; set; }
        internal string Autore { get; set; }
        internal int Durata { get; set; }

        //costruttore, alla creazione di un nuovo oggetto bisogna inserire titolo, autore e durata (in secondi)
        internal Brano (string titolo, string autore, int durata)
        {
            this.Titolo = titolo;
            this.Autore = autore;
            this.Durata = durata;
        }

        //metodo che restituisce true se il brano dura meno di 3 minuti (180 secondi), oppure false se dura più di 3 minuti
        internal bool shortSong()
        {
            if (Durata < 180)
            {
                return true;
            }
            return false;
        }

        //override del metodo toString(), stampa direttamente la stringa con titolo, autore e durata
        public override string ToString()
        {
            return "Titolo: " + Titolo + "\nAutore: " + Autore + "\nDurata: " + Durata + "s";
        }
    }
}
