using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDelivery.Entities
{
    internal enum tipPizza
    {
        Neapolitan,
        Margherita,
        Marinara,
        Romana
    }
    internal class Pizza : IPretTotal, IComparable<Pizza>
    {
        private tipPizza _tip;
        private int _cantitate;
        private float _pret;
        private String[] _ingrediente;

        public Pizza(tipPizza tip, int cantitate, float pret, String[] ingrediente) {
            _tip = tip;
            _cantitate = cantitate;
            _pret = pret;
            _ingrediente = ingrediente;
        }
        public tipPizza tip { get; set; }

        public float getPret()
        {
            return _pret;
        }

        public int cantitate { get; set; }

        public int CompareTo(Pizza other)
        {
            return _pret.CompareTo(other._pret);
        }

        public static Pizza operator ++(Pizza pizza)
        {
            pizza._cantitate++;
            return pizza;
        }

        public static Pizza operator --(Pizza pizza)
        {
            pizza._cantitate--;
            return pizza;
        }

        public string this[int index]
        {
            get { return _ingrediente[index]; }
            set { _ingrediente[index] = value; }
        }

        public void adaugaIngredient(string ingredient)
        {   
            
            string[] ingredienteNoi = new string[_ingrediente.Length + 1];
            
            for(int i = 0; i <  _ingrediente.Length; i++)
            {
                ingredienteNoi[i] = _ingrediente[i];
            }

            ingredienteNoi[ingredienteNoi.Length - 1] = ingredient;

            _ingrediente = ingredienteNoi;

            Console.WriteLine("Ingredientul a fost adaugat!");
        }

        public float CalculeazaPret()
        {
            float total = _pret * cantitate;
            return total;
        }

        
    }
}
