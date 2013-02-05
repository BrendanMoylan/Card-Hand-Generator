using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PlayingCards
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Card[] cards = new Card[52];
        int count = 0;

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i <= 3; i++)
            {
                for (int y = 1; y <= 13; y++)
                {
                    cards[count] = new Card((Suits)i, (Values)y);
                    count++;
                    Console.WriteLine(count);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            for (int i = 0; i < 5; i++)
            {
                label1.Text += cards[random.Next(cards.Length)].Name + "\r\n";
            }
        }
    }
}
