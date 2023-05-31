using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipPizza selectedPizza = (tipPizza)tipCb.SelectedItem;

            Console.WriteLine("Selected Pizza: " + selectedPizza);
        }

        private int numarComanda = 0;
        private void butonAdaugare_Click(object sender, EventArgs e)
        {
            
            string tipCbValue = tipCb.Text;
            int counterCantitateValue = (int)counterCantitate.Value;

            if (!string.IsNullOrEmpty(tipCbValue) && counterCantitateValue > 0)
            {
                ListViewItem item = new ListViewItem();

                item.SubItems.Add(tipCbValue);
                item.SubItems.Add(counterCantitateValue.ToString());
                item.Text = numarComanda.ToString();
                numarComanda++;
                lvPizza.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Te rog selecteaza un tip de pizza sau mareste cantitatea","Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void counterCantitate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                string tipCbValue = tipCb.Text;
                int counterCantitateValue = (int)counterCantitate.Value;

                if (!string.IsNullOrEmpty(tipCbValue) && counterCantitateValue > 0)
                {
                    ListViewItem item = new ListViewItem();

                    item.SubItems.Add(tipCbValue);
                    item.SubItems.Add(counterCantitateValue.ToString());
                    item.Text = numarComanda.ToString();
                    numarComanda++;
                    lvPizza.Items.Add(item);
                    e.Handled = true;
                }
                else
                {
                    MessageBox.Show("Te rog selecteaza un tip de pizza sau mareste cantitatea", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void backBtn1_Load(object sender, EventArgs e)
        {

        }

        private void backBtn1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt";
            saveFileDialog.Title = "Export to Text File";
            saveFileDialog.FileName = "Comanda.txt";

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using(StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                    {
                        foreach(ListViewItem item in lvPizza.Items)
                        {
                            writer.WriteLine($"{item.SubItems[0].Text}\t{item.SubItems[1].Text}\t{item.SubItems[2].Text}");
                        }
                    }
                    MessageBox.Show("Fisierul a fost exportat", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("A aparut o eroare", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
