using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//      *Change Log*
//     02/19/2014 @ 02:43
//      created Repository
//      created Convert, Clear, and Exit buttons
//      created text box for user input
//      created label for output of data
//      convert on click
//       created try and catch
//       created local variables
//       created if, else, and else if statements
//      clear on click
//       clear input and output fields
//      exit on click
//       thise.close();


namespace Roman_Numeral_Converter
{
    public partial class Form1 : Form
    {
        // assigning constand variables or use to compare user's input against
        private const decimal romanI = 1;
        private const decimal romanII = 2;
        private const decimal romanIII = 3;
        private const decimal romanIV = 4;
        private const decimal romanV = 5;
        private const decimal romanVI = 6;
        private const decimal romanVII = 7;
        private const decimal romanVIII = 8;
        private const decimal romanIX = 9;
        private const decimal romanX = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                //declaring local variables
                decimal numberInput;    //to hold user input
                string romanOutput;     //to hold data for output

                //pulling data entered by user and assigning it to a variable
                numberInput = decimal.Parse(numberInputTxt.Text);

                if (numberInput >= 1 && numberInput <= 10)          //test if user entered value within constraints.
                {
                    // these if's and else if's are comparing the value entered by the user against the constant
                    // variables assigned in the class.
                    if (numberInput == romanI)
                    {
                        romanOutput = "I";
                        romanOutputLabel.Text = romanOutput;
                    }
                    else if (numberInput == romanII)
                    {
                        romanOutput = "II";
                        romanOutputLabel.Text = romanOutput;
                    }
                    else if (numberInput == romanIII)
                    {
                        romanOutput = "III";
                        romanOutputLabel.Text = romanOutput;
                    }
                    else if (numberInput == romanIV)
                    {
                        romanOutput = "IV";
                        romanOutputLabel.Text = romanOutput;
                    }
                    else if (numberInput == romanV)
                    {
                        romanOutput = "V";
                        romanOutputLabel.Text = romanOutput;
                    }
                    else if (numberInput == romanVI)
                    {
                        romanOutput = "VI";
                        romanOutputLabel.Text = romanOutput;
                    }
                    else if (numberInput == romanVII)
                    {
                        romanOutput = "VII";
                        romanOutputLabel.Text = romanOutput;
                    }
                    else if (numberInput == romanVIII)
                    {
                        romanOutput = "VIII";
                        romanOutputLabel.Text = romanOutput;
                    }
                    else if (numberInput == romanIX)
                    {
                        romanOutput = "IX";
                        romanOutputLabel.Text = romanOutput;
                    }
                    else if (numberInput == romanX)
                    {
                        romanOutput = "X";
                        romanOutputLabel.Text = romanOutput;
                    }
                }
                    //error message for value entered that is outside constraints
                else
                {
                    MessageBox.Show("You entered a number that is not between 1 and 10. Please try again.");
                }
            }
            catch (Exception ex)    //catch error message
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear all the fields
            numberInputTxt.Text = "";
            romanOutputLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closing the program
            this.Close();
        }
    }
}
