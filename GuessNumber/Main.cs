using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumber
{
    public partial class Main : Form
    {

        Random randomNumber = new Random();
        int number = 0;
        int guess = 0;





        public Main()
        {
            InitializeComponent();

            loadQuestion();
        }

        private void TryB_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(GTb.Text);
            guess += 1;
            GuessLbl.Text = "You guessed" +  guess +   "times";


            if (i== number)
            {
                MessageBox.Show("You guessed correct.You can try another.");
                loadQuestion();

                GTb.Text = "";
                guess = 0;
            }
            else if(i< number)
            {
                MessageBox.Show("Higher");
            }
            else
            {
                MessageBox.Show("Lower");
            }



        }

        private void loadQuestion()
        {
            number = randomNumber.Next(0, 20);

            NumberLbl.Text = "I am thinking of a number between 0 and 20.";


        }
    }
}
