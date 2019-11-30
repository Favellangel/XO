using System;
using System.Windows.Forms;

namespace XO
{
    internal partial class FormMain : Form
    {
        internal FormMain()
        {
            InitializeComponent();
        }
        short binX = 0, binO = 0, bin = 0;
        bool playerOne = true;
        bool playerTwo = false;

        internal void RefreshGame()
        {
            binX = 0;
            binO = 0;
            bin = 0;
            playerOne = true;
            playerTwo = false;
            labelStep.Text = "player One";
            labelWin.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            buttonRefresh.Hide();
        }

        internal string DrawXO()
        {
            if(playerOne)
            {           
                playerOne = false;
                playerTwo = true;
                labelStep.Text = "player Two";     
                return "X";
            }
            else
            {               
                playerOne = true;
                playerTwo = false;
                labelStep.Text = "player One";
                return "O";
            }
        }
      
        internal void Steplayer(short numButton)
        {
            if (playerOne)
            {
                binO |= numButton;
            }
            else if (playerTwo)
            {
                binX |= numButton;
            }
            bin |= numButton;
        }

        internal bool Win(short bin)
        {
            bool b = false;
            int il = 0;
            short[] binWin = new short[] { 7, 56, 73, 84, 146, 273, 292, 448 };
            foreach (short i in binWin)
            {
                il = (int)bin & (int)i;
                if ( il == i )
                {
                    b = true;
                    break;
                }
            }
            return b;
        }

        internal void PrintWin()
        {
            if (Win(binX))
            {
                labelWin.Text = "Win Player One";
                buttonRefresh.Show();
            }
            else if (Win(binO))
            {
                labelWin.Text = "Win Player Two";
                buttonRefresh.Show();
            }
            else if (bin == 511)
            {
                labelWin.Text = "No win";
                buttonRefresh.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = DrawXO();
            button1.Enabled = false;
            Steplayer(1);
            PrintWin();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = DrawXO();
            button2.Enabled = false;
            Steplayer(2);
            PrintWin();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = DrawXO();
            button3.Enabled = false;
            Steplayer(4);
            PrintWin();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = DrawXO();
            button4.Enabled = false;
            Steplayer(8);
            PrintWin();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = DrawXO();
            button5.Enabled = false;
            Steplayer(16);
            PrintWin();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = DrawXO();
            button6.Enabled = false;
            Steplayer(32);
            PrintWin();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = DrawXO();
            button7.Enabled = false;
            Steplayer(64);
            PrintWin();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = DrawXO();
            button8.Enabled = false;
            Steplayer(128);
            PrintWin();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = DrawXO();
            button9.Enabled = false;
            Steplayer(256);
            PrintWin();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshGame();
        }
    }
}

