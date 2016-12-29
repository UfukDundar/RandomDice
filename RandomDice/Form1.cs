using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomDice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dice1.ImageLocation= System.IO.Path.GetFullPath("Pictures/Dice-0.png");
            Dice2.ImageLocation= System.IO.Path.GetFullPath("Pictures/Dice-0.png");
        }
        public void RollDice()
        {
            Random rnd = new Random();
            int diceValue1 = rnd.Next(1, 7);
            int diceValue2 = rnd.Next(1, 7);

            Dice1.ImageLocation = System.IO.Path.GetFullPath("Pictures/Dice-"+diceValue1.ToString()+ ".png");
            Dice2.ImageLocation = System.IO.Path.GetFullPath("Pictures/Dice-"+diceValue2.ToString()+".png");
        }

        private void Dice1_Click(object sender, EventArgs e)
        {
            RollDice();
        }

        private void Dice2_Click(object sender, EventArgs e)
        {
            RollDice();
        }
    }
}
