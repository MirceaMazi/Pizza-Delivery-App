using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzaDelivery.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PizzaDelivery.Forms { 

    internal enum tipPizza
    {
        Neapolitan,
        Margherita,
        Marinara,
        Romana
    }

    public partial class FormComanda : Form
    {
        private List<Pizza> _pizzas;
        public FormComanda()
        {
            InitializeComponent(); 

            foreach(tipPizza pizza in Enum.GetValues(typeof(tipPizza))) {
                tipCb.Items.Add(pizza);
            }

            _pizzas = new List<Pizza>();
  
        }

        private void FromComanda_Load(object sender, EventArgs e)
        {
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipPizza selectedPizza = (tipPizza)tipCb.SelectedItem;

            Console.WriteLine("Selected Pizza: " + selectedPizza);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void counterCantitate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void counterCantitate_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private int numarComanda = 0;
        private void butonAdaugare_Click(object sender, EventArgs e)
        {
            string tipCbValue = tipCb.Text;
            int counterCantitateValue = (int)counterCantitate.Value;
            
            ListViewItem item = new ListViewItem();
            item.Text = numarComanda.ToString();
            item.SubItems.Add(tipCbValue);
            item.SubItems.Add(counterCantitateValue.ToString());
            numarComanda++;
            lvPizza.Items.Add(item);

        }
    }
}
