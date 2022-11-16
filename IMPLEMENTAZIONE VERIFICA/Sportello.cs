using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMPLEMENTAZIONE_VERIFICA
{
    class Sportello
    {
        private string _id;
        private string _indirizzo;
        private string _banca;
        private bool _disp;
        private Bancomat seriale;
        string[] blocco = new string[100];
    
        public Sportello(string id, string indirizzo, string banca, bool disp)
        {
            Id = id;
            Indirizzo = indirizzo;
            Banca = banca;
            setStato(_disp);
        }
        public string Id;
        public string Indirizzo;
        public string Banca;

        public bool getStato()
        {
            return _disp;
        }
        private void setStato(bool stato)
        {
            this._disp = stato;
        }

        public void Inserisci (Bancomat carta, bool disp)
        {
            bool check=false;
            
            for (int i=0; i != 100; i++) 
            {
                if (seriale.getId() == blocco[i])
                {
                    Console.WriteLine("Carta Bloccata");
                    setStato(true);
                    check = true;
                } 
            }
            if (check == false)
            {
                setStato(false);
            }
        }
        public void Rimuovi(Bancomat carta, bool disp)
        {
            setStato(true);
        }
    }
}
