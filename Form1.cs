using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using example.Models;

namespace example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        Fighter fighter1 = new Fighter();
        int Opponent;
        private void button1_Click(object sender, EventArgs e)
        {
            fighter1.OyuncuIsmi = TxtOyuncu.Text;
            fighter1.Brans = txtBrans.Text;
            fighter1.Irk = TxtIrk.Text;           
            fighter1.Silah = txtSilah.Text;
            
            

            
        }

        private void lblOpponent_TextChanged(object sender, EventArgs e)
        {
            Opponent = Convert.ToInt32(lblOpponent.Text);
        }

        private void btnPunch_Click(object sender, EventArgs e)
        {
            fighter1.Punch();
            Opponent -= fighter1.PunchingPower;
            lblOpponent.Width = Opponent;
            MessageBox.Show($"dusmana{fighter1.PunchingPower} kadar vurdunuz..");
            if (Opponent <= 0)
            {
                MessageBox.Show("It is all over!!!");
            }
        }
    }
}
