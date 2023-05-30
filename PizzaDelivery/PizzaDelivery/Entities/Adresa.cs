using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDelivery.Entities
{
    internal class Adresa : ICloneable
    {
        private String _strada;
        private String _numar;
        private String _cartier;

        public Adresa(string strada, string numar, string cartier)
        {
            _strada = strada;
            _numar = numar;
            _cartier = cartier;
        }

        public String strada { get; set; }
        public String numar { get; set; }
        public string cartier { get; set; }

        public static Adresa operator ++(Adresa adresa)
        {
            int numarStrada = int.Parse(adresa.numar);
            numarStrada++;
            adresa.numar = numarStrada.ToString();
            return adresa;
        }

        public static Adresa operator --(Adresa adresa)
        {
            int numarStrada = int.Parse(adresa.numar);
            numarStrada--;
            adresa.numar = numarStrada.ToString();
            return adresa;
        }

        public override string ToString()
        {
            return $"Strada: {_strada}\n Numar: {_numar}\n Cartier: {_cartier}";
        }

        public object Clone()
        {
            return new Adresa(_strada, _numar, _cartier);
        }

        public void adaugaStr(Adresa adresa)
        {
            String newStrada = "Str." + adresa.strada;
        }
    }
}
