using System;

using System.Windows.Forms;

namespace Spel
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private Random random; // declarerar att det �r en privat variabel
        private int secretNumber;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int maxNumber = Convert.ToInt32(comboBox1.Text);
            secretNumber = random.Next(0, maxNumber + 1); // genererar tal fr�n 0 till max number 

            MessageBox.Show("Ett hemligt tal har slumpats fram. B�rja gissa!");
            guessTextBox.Enabled = true;
            guessButton.Enabled = true;
            startButton.Enabled = false;





        }

        public void guessButton_Click(object sender, EventArgs e)
        {
            int userGuess = Convert.ToInt32(guessTextBox.Text);// converterar texten "guessTextBox till int och ger den till UserGuess

            if (userGuess == secretNumber)
            {
                textBox1.Text = "Grattis du gissade r�tt tal";
                ResetGame(sender);
                textBox3.Text = secretNumber.ToString();
                startaom.Enabled = true;
                listBox1.Items.Add("Anv�ndarn vann");


            }
            else if (userGuess < secretNumber)
            {
                textBox1.Text = ("F�r l�gt! F�rs�k igen.");
                textBox3.Text = secretNumber.ToString();
                startaom.Enabled = true;
                listBox1.Items.Add("Datorn vann");

            }
            else
            {
                textBox1.Text = ("F�r h�gt! F�rs�k igen.");
                textBox3.Text = secretNumber.ToString();
                startaom.Enabled = true;
                listBox1.Items.Add("Datorn vann");
            }



            guessTextBox.Clear();


        }
        public void ResetGame(object sender)
        {
            guessTextBox.Clear();
            guessTextBox.Enabled = false;
            guessButton.Enabled = false;
            startButton.Enabled = true;


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            guessTextBox.Clear();
            guessTextBox.Enabled = false;
            guessButton.Enabled = false;
            startButton.Enabled = true;
        }
    }
}
