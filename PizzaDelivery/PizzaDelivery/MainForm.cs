using PizzaDelivery.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaDelivery
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formComanda = new FormComanda();
            this.Hide();
            formComanda.ShowDialog();
            this.Show();
        }

        private void butonFormular_Click(object sender, EventArgs e)
        {
            var formFeedback = new FormFeedback();
            this.Hide();
            formFeedback.ShowDialog();
            this.Show();
        }

        private void butonGrafic_Click(object sender, EventArgs e)
        {
            var formGrafic = new FormGrafic();
            this.Hide();
            formGrafic.ShowDialog();
            this.Show();
        }
        
        private void btnX_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
