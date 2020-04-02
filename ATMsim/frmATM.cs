using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMsim
{
    public partial class frmATM : Form
    {
        int accountInputStage = -1;
        //Account access
        private Account[] accounts;
        int accountAccessed = 0;
        int accountCode;



        //Pin button click events
        private void btnPin3_Click(object sender, EventArgs e)
        {
            //User is intitially inputting account number
            if (interfaceStage == "Start" && accountInputStage != 5)
            {
                accountInputStage++;
                string accountNum = lblAccountInput.Text;
                accountNum = replaceAtIndex(accountInputStage, '3', accountNum);
                lblAccountInput.Text = accountNum;
            }
            //User is inputting pin
            else if(interfaceStage == "VerifyPin" && accountInputStage != 3)
            {
                accountInputStage++;
                string pinNum = lblAccountInput.Text;
                pinNum = replaceAtIndex(accountInputStage, '3', pinNum);
                lblAccountInput.Text = pinNum;
            }
        }

        private void btnPin4_Click(object sender, EventArgs e)
        {
            //User is intitially inputting account number
            if (interfaceStage == "Start" && accountInputStage != 5)
            {
                accountInputStage++;
                string accountNum = lblAccountInput.Text;
                accountNum = replaceAtIndex(accountInputStage, '4', accountNum);
                lblAccountInput.Text = accountNum;
            }
            //User is inputting pin
            else if (interfaceStage == "VerifyPin" && accountInputStage != 3)
            {
                accountInputStage++;
                string pinNum = lblAccountInput.Text;
                pinNum = replaceAtIndex(accountInputStage, '4', pinNum);
                lblAccountInput.Text = pinNum;
            }
        }

        private void btnPin5_Click(object sender, EventArgs e)
        {
            //User is intitially inputting account number
            if (interfaceStage == "Start" && accountInputStage != 5)
            {
                accountInputStage++;
                string accountNum = lblAccountInput.Text;
                accountNum = replaceAtIndex(accountInputStage, '5', accountNum);
                lblAccountInput.Text = accountNum;
            }
            //User is inputting pin
            else if (interfaceStage == "VerifyPin" && accountInputStage != 3)
            {
                accountInputStage++;
                string pinNum = lblAccountInput.Text;
                pinNum = replaceAtIndex(accountInputStage, '5', pinNum);
                lblAccountInput.Text = pinNum;
            }
        }

        private void btnPin6_Click(object sender, EventArgs e)
        {
            //User is intitially inputting account number
            if (interfaceStage == "Start" && accountInputStage != 5)
            {
                accountInputStage++;
                string accountNum = lblAccountInput.Text;
                accountNum = replaceAtIndex(accountInputStage, '6', accountNum);
                lblAccountInput.Text = accountNum;
            }
            //User is inputting pin
            else if (interfaceStage == "VerifyPin" && accountInputStage != 3)
            {
                accountInputStage++;
                string pinNum = lblAccountInput.Text;
                pinNum = replaceAtIndex(accountInputStage, '6', pinNum);
                lblAccountInput.Text = pinNum;
            }
        }

        private void btnPin7_Click(object sender, EventArgs e)
        {
            //User is intitially inputting account number
            if (interfaceStage == "Start" && accountInputStage != 5)
            {
                accountInputStage++;
                string accountNum = lblAccountInput.Text;
                accountNum = replaceAtIndex(accountInputStage, '7', accountNum);
                lblAccountInput.Text = accountNum;
            }
            //User is inputting pin
            else if (interfaceStage == "VerifyPin" && accountInputStage != 3)
            {
                accountInputStage++;
                string pinNum = lblAccountInput.Text;
                pinNum = replaceAtIndex(accountInputStage, '7', pinNum);
                lblAccountInput.Text = pinNum;
            }
        }

        private void btnPin8_Click(object sender, EventArgs e)
        {
            //User is intitially inputting account number
            if (interfaceStage == "Start" && accountInputStage != 5)
            {
                accountInputStage++;
                string accountNum = lblAccountInput.Text;
                accountNum = replaceAtIndex(accountInputStage, '8', accountNum);
                lblAccountInput.Text = accountNum;
            }
            //User is inputting pin
            else if (interfaceStage == "VerifyPin" && accountInputStage != 3)
            {
                accountInputStage++;
                string pinNum = lblAccountInput.Text;
                pinNum = replaceAtIndex(accountInputStage, '8', pinNum);
                lblAccountInput.Text = pinNum;
            }
        }

        private void btnPin9_Click(object sender, EventArgs e)
        {
            //User is intitially inputting account number
            if (interfaceStage == "Start" && accountInputStage != 5)
            {
                accountInputStage++;
                string accountNum = lblAccountInput.Text;
                accountNum = replaceAtIndex(accountInputStage, '9', accountNum);
                lblAccountInput.Text = accountNum;
            }
            //User is inputting pin
            else if (interfaceStage == "VerifyPin" && accountInputStage != 3)
            {
                accountInputStage++;
                string pinNum = lblAccountInput.Text;
                pinNum = replaceAtIndex(accountInputStage, '9', pinNum);
                lblAccountInput.Text = pinNum;
            }
        }

        private void btnPin2_Click(object sender, EventArgs e)
        {
            //User is intitially inputting account number
            if (interfaceStage == "Start" && accountInputStage != 5)
            {
                accountInputStage++;
                string accountNum = lblAccountInput.Text;
                accountNum = replaceAtIndex(accountInputStage, '2', accountNum);
                lblAccountInput.Text = accountNum;
            }
            //User is inputting pin
            else if (interfaceStage == "VerifyPin" && accountInputStage != 3)
            {
                accountInputStage++;
                string pinNum = lblAccountInput.Text;
                pinNum = replaceAtIndex(accountInputStage, '2', pinNum);
                lblAccountInput.Text = pinNum;
            }
        }

        private void btnPin1_Click(object sender, EventArgs e)
        {
            //User is intitially inputting account number
            if (interfaceStage == "Start" && accountInputStage != 5)
            {
                accountInputStage++;
                string accountNum = lblAccountInput.Text;
                accountNum = replaceAtIndex(accountInputStage, '1', accountNum);
                lblAccountInput.Text = accountNum;
            }
            //User is inputting pin
            else if (interfaceStage == "VerifyPin" && accountInputStage != 3)
            {
                accountInputStage++;
                string pinNum = lblAccountInput.Text;
                pinNum = replaceAtIndex(accountInputStage, '1', pinNum);
                lblAccountInput.Text = pinNum;
            }
        }


        //Pin function buttons
        private void btnPinEnter_Click(object sender, EventArgs e)
        {
            //user is at account input stage
            if (interfaceStage == "Start" && accountInputStage == 5)
            {
                accountInputStage = -1;
                accountCode = Int32.Parse(lblAccountInput.Text);
                //Check account number valid
                for (int i = 0; i < accounts.Length; i++)
                {
                    if(accounts[i].getAccountNum() == accountCode)
                    {
                        accountAccessed = i;
                        interfaceStage = "VerifyPin";
                        lblInitialnput.Text = "Please enter pin:";
                        lblInitialnput.Left += 75;
                        lblAccountInput.Text = "****";
                    }
                }
            }
            //User is at verify pin stage
            else if (interfaceStage == "VerifyPin" && accountInputStage == 3)
            {
                int pinEntered = Int32.Parse(lblAccountInput.Text);
                if (accounts[accountAccessed].checkPin(pinEntered) == true)
                {
                    interfaceStage = "AccountOptions";
                    displayInterface();
                }
            }
        }

        private void btnPinClear_Click(object sender, EventArgs e)
        {
            //user is at account input stage
            if (interfaceStage == "Start")
            {
                accountInputStage = -1;
                lblAccountInput.Text = "******";
            }
            //user is at verify pin stage
            if (interfaceStage == "VerifyPin")
            {
                accountInputStage = -1;
                lblAccountInput.Text = "****";
            }
        }

        private void btnPinCancel_Click(object sender, EventArgs e)
        {
            //user is at account input stage
            if (interfaceStage == "Start")
            {
                
            }
        }

        

        private void frmATM_Load(object sender, EventArgs e)
        {
            displayInterface();
            lblOptions.Visible = false;
            lblOpt1.Visible = false;
            lblOpt2.Visible = false;
            lblOpt3.Visible = false;
            lblOpt4.Visible = false;
        }

        String interfaceStage = "Start";

        public frmATM(Account[] val)
        {
            InitializeComponent();
            accounts = val;
        }

        void displayInterface()
        {
            if (interfaceStage == "Start")
            {
                lblInitialnput.Text = "Please enter your account number:";
                lblInitialnput.Location = new Point(100, 100);
                lblAccountInput.Text = "******";
                lblAccountInput.Location = new Point(230, 150);
            }
            else if(interfaceStage == "AccountOptions")
            {
                lblInitialnput.Visible = false;
                lblAccountInput.Visible = false;
                //Make labels for options menu visible
                lblOptions.Visible = true;
                lblOpt1.Visible = true;
                lblOpt2.Visible = true;
                lblOpt3.Visible = true;
                lblOpt4.Visible = true;
                //Changing positions and text of these labels
                lblOptions.Text = "Welcome, please select an option from below.";
                lblOptions.Location = new Point(50, 70);
                lblOpt1.Text = "Withdrawl";
                lblOpt2.Text = "Balance";
                lblOpt3.Text = "Balance and Withdrawl";
                lblOpt3.Location = new Point(270, 190);
                lblOpt4.Text = "Exit";
            }
            else if(interfaceStage == "Withdrawl")
            {
                
            }
            else if (interfaceStage == "Balance")
            {
                string balance = (accounts[accountAccessed].getBalance()).ToString();
                lblOptions.Text = "Your balance is: " + balance;
                lblOptions.Location = new Point(150, 100);
                lblOpt1.Text = "Back";
                lblOpt2.Visible = false;
                lblOpt3.Visible = false;
                lblOpt4.Visible = false;
            }
            else if (interfaceStage == "BalanceWithdrawl")
            {

            }
        }

        //Method for replacing at index of string 
        //Found from stackoverflow
        static string replaceAtIndex(int i, char value, string word)
        {
            char[] letters = word.ToCharArray();
            letters[i] = value;
            return string.Join("", letters);
        }

        private void btnOpt1_Click(object sender, EventArgs e)
        {
            //Withdrawl
            if(interfaceStage == "AccountOptions")
            {
                interfaceStage = "Withdrawl";
                displayInterface();
            }
            //Back to menu from withdrawl
            if (interfaceStage == "Balance")
            {
                interfaceStage = "AccountOptions";
                displayInterface();
            }
        }

        private void btnOpt2_Click(object sender, EventArgs e)
        {
            //Balance
            if (interfaceStage == "AccountOptions")
            {
                interfaceStage = "Balance";
                displayInterface();
            }
        }

        private void btnOpt3_Click(object sender, EventArgs e)
        {
            //Balance and Withdrawl
            if (interfaceStage == "AccountOptions")
            {
                interfaceStage = "BalanceWithdrawl";
                displayInterface();
            }
        }

        private void btnOpt4_Click(object sender, EventArgs e)
        {
            //Exit
            if (interfaceStage == "AccountOptions")
            {

            }
        }
    }
}
