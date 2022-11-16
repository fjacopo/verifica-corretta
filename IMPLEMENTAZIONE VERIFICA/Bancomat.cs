using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMPLEMENTAZIONE_VERIFICA
{
    class Bancomat
    {
        private string _id;
        private string _pin;
        private ContoCorrente conto;

        public Bancomat(string id, string pin, ContoCorrente Conto)
        {
             Id = id;
            Pin = pin;
            conto = Conto;
        }

       

        public string Id
        {
            get 
            {
                return _id;
            }

            set
            {
                _id = value;
            }

        }
        public string Pin;

        public void Depositare(float somma, string verifica)
        {
            if (verifica==Pin) {
                conto.Deposita(somma);
            }
            else
            {
                throw new Exception("Pin Errato");
            }
        }
        public void Prelevare(float somma, string verifica)
        {
            if (verifica == Pin)
            {
                conto.Preleva(somma);
            }
            else
            {
                throw new Exception("Pin Errato");
    }
}
        
        public float getSaldo(string verifica)
        {
            if (verifica == Pin)
            {
                return conto.getSaldo();
            }
            else
            {
                throw new Exception("Pin Errato");
            }
        }
        public string getId()
        {
            return _id;
        }
    }
}
