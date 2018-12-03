using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateWinner_Click(object sender, EventArgs e)
        {
            string playerInput1, playerInput2;
            string rock = "r";
            string scissors = "s";
            string paper = "p";
            playerInput1 = txtPlayer1Input.Text;
            playerInput2 = txtPlayer2Input.Text;

            if (playerInput1 == playerInput2)
                lblWinner.Text = "It is a tie, nobody wins.";
            else if (playerInput1 == rock && playerInput2 == scissors)
                lblWinner.Text = "Player 1 wins";
            else if (playerInput1 == paper && playerInput2 == rock)
                lblWinner.Text = "Player 1 wins";
            else if (playerInput1 == scissors && playerInput2 == paper)
                lblWinner.Text = "Player 1 wins";
            else if (playerInput2 == rock && playerInput1 == scissors)
                lblWinner.Text = "Player 2 wins";
            else if (playerInput2 == paper && playerInput1 == rock)
                lblWinner.Text = "Player 2 wins";
            else if (playerInput2 == scissors && playerInput1 == paper)
                lblWinner.Text = "Player 2 wins";
            else
                lblWinner.Visible = false;

          
                picVs.Visible = true;

                if (playerInput1 == rock || playerInput1 == scissors || playerInput1 == paper)
                {
                    if (playerInput1 == rock)
                        picRock1.Visible = true;
                    else if (playerInput1 == scissors)
                        picPaper1.Visible = true;
                    else
                        picScissors1.Visible = true;
                }
                else
                {
                    lblErrorPlayer1.Text = "Wrong value player 1, please enter a r, s, or p";
                }

                if (playerInput2 == rock || playerInput2 == scissors || playerInput2 == paper)
                {
                    if (playerInput2 == rock)
                        picRock2.Visible = true;
                    else if (playerInput2 == scissors)
                        picScissors2.Visible = true;
                    else
                        picPaper2.Visible = true;
                }
                else
                {
                    lblErrorPlayer2.Text = "Wrong value player 2, please enter a r, s, or p";
                }

           

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            picPaper1.Visible = false;
            picPaper2.Visible = false;
            picRock1.Visible = false;
            picRock2.Visible = false;
            picPaper1.Visible = false;
            picPaper2.Visible = false;
            picVs.Visible = false;
            lblWinner.Text = " ";

        }
    }
}
