using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoLoops
{
    public partial class Form1 : Form
    {
        int selectedLoop = -1;
        int selectedAction = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblErrorMessage.Text = "";

            if (ValidData())
            {
                txtResult.Text = "how do I get the number from the validate class????";
               

                if (selectedAction == 1)
                {
                    Calculate();

                }
                else if (selectedAction == 2)
                {
                    SumAllEvenNumbers();

                }
                else if (selectedAction == 3)
                {
                    SumAllOddNumbers();
                }
            }
        }

        private void SumAllOddNumbers()
        {
           
                int maxNumber = Convert.ToInt32(txtUserEntry.Text);
                int minNumber = 1;
                int result = 0;

                if (selectedLoop == 1)
                {
                    for (int i = minNumber; i <= maxNumber; i++)
                    {
                        if (i % 2 != 0)  
                        {
                            result += i;
                        }
                    }
                }
                else if (selectedLoop == 2)
                {
                    // while loop
                    while (minNumber <= maxNumber)
                    {
                        if (minNumber % 2 != 0)  
                        {
                            result += minNumber;
                        }
                        minNumber++;
                    }
                }
                else if (selectedLoop == 3)
                {
                    // do-while loop
                    do
                    {
                        if (minNumber % 2 != 0)  
                        {
                            result += minNumber;
                        }
                        minNumber++;
                    } while (minNumber <= maxNumber);
                }
                else if (selectedLoop == 4)
                {
                    List<int> listOfInts = new List<int>();
                    for (int i = minNumber; i <= maxNumber; i++)
                    {
                        if (i % 2 != 0)  
                        {
                            listOfInts.Add(i);
                        }
                    }

                    foreach (int num in listOfInts)
                    {
                        result += num;
                    }
                }

                txtResult.Text = result.ToString();
            

        }

        private void SumAllEvenNumbers()
        {
            int maxNumber = Convert.ToInt32(txtUserEntry.Text);
            int minNumber = 1;
            int result = 0;

            if (selectedLoop == 1)
            {
                for (int i = minNumber; i <= maxNumber; i++)
                {
                    if (i % 2 == 0)  
                    {
                        result += i;
                    }
                }
            }
            else if (selectedLoop == 2)
            {
                // while loop
                while (minNumber <= maxNumber)
                {
                    if (minNumber % 2 == 0)  
                    {
                        result += minNumber;
                    }
                    minNumber++;
                }
            }
            else if (selectedLoop == 3)
            {
                // do-while loop
                do
                {
                    if (minNumber % 2 == 0)  
                    {
                        result += minNumber;
                    }
                    minNumber++;
                } while (minNumber <= maxNumber);
            }
            else if (selectedLoop == 4)
            {
                List<int> listOfInts = new List<int>();
                for (int i = minNumber; i <= maxNumber; i++)
                {
                    if (i % 2 == 0)  
                    {
                        listOfInts.Add(i);
                    }
                }

                foreach (int num in listOfInts)
                {
                    result += num;
                }
            }

            txtResult.Text = result.ToString();
        }


        private void Calculate()
        {
            int maxNumber = Convert.ToInt32(txtUserEntry.Text);
            int minNumber = 1;
            int result = 0;

            if (selectedLoop == 1)
            {
                for (int i = minNumber; i <= maxNumber; i++)
                {
                    result += i;
                }
            }
            else if (selectedLoop == 2)
            {
                //while
                while (minNumber <= maxNumber)
                {
                    result += minNumber;
                    minNumber++;
                }
            }
            else if (selectedLoop == 3)
            {
                //dowhile
                do
                {
                    result += minNumber;
                    minNumber++;
                } while (minNumber <= maxNumber);
            }
            else if (selectedLoop == 4)
            {
                List<int> listOfInts = new List<int>();
                for (int i = minNumber; i <= maxNumber; i++)
                {
                    listOfInts.Add(i);
                }

                foreach (int num in listOfInts)
                {
                    result += num;
                }
            }


            txtResult.Text = result.ToString();

        }

        private bool ValidData()
        {
            if (Validator.IsIntegerGreaterThanZero(txtUserEntry.Text))
            {
                return true;
            }
            else
            {
                lblErrorMessage.Text = "Please enter integer greater than zero";
                txtUserEntry.Focus();
                return false;   
            }
        }


        private void cboLoopType_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedLoop = cboLoopType.SelectedIndex;
        }

        private void cboActions_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAction = cboActions.SelectedIndex;
        }
    }
}
