using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDelivery.Entities
{
    internal class Client
    {
        private int _varsta;
        private String _nume;
        public Pizza _comanda;
        public Adresa _adresa;

        public Client(int varsta, String nume, Pizza comanda, Adresa adresa) {
            _varsta = varsta;
            _nume = nume;
            _comanda = comanda;
            _adresa = adresa;
        }

        public int varsta { get; set; }
        public String nume { get; set; }
        public Pizza comanda { get; set; }
        public Adresa adresa { get;set; }

        public static bool operator >(Client client1, Client client2)
        {
            return client1._varsta > client2._varsta;
        }
        public static bool operator <(Client client1, Client client2)
        {
            return client1._varsta < client2._varsta;
        }

        public void afiseazaClient()
        {
            Console.WriteLine($"Nume client: {_nume}");
            if (_comanda != null)
            {
                Console.WriteLine("Comanda:");
                Console.WriteLine($"Tip Pizza: {_comanda.tip}");
                Console.WriteLine($"Cantitate: {_comanda.cantitate}");
                Console.WriteLine($"Pret: {_comanda.getPret()}");
            }
        }

        public bool esteMajor()
        {
            if( _varsta > 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
