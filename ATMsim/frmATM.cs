using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMsim
{
    public partial class frmATM : Form
    {
        int accountInputStage = -1;
        private bool semaphore = true;
        private Thread atm_T;
        //Account access
        private Account[] accounts;
        private Account demoAccount;
        int accountAccessed = 0;
        int accountCode;

        public void setDemoAccount(Account account)
        {
            this.demoAccount = account;
        }

        public Account getDemoAccount()
        {
            return this.demoAccount;
        }

        public void setSemaphore(bool sem)
        {
            this.semaphore = sem;
        }

        public bool getSemaphore()
        {
            return this.semaphore;
        }

        private void updateAccounts()
        {
            form1.updateAccount(accounts);            
        }

        private void updateLocalAccount()
        {
            
            accounts = form1.getAccounts();
            
            
        }

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
            else if (interfaceStage == "VerifyPin" && accountInputStage != 3)
            {
                accountInputStage++;
                string pinNum = lblAccountInput.Text;
                pinNum = replaceAtIndex(accountInputStage, '3', pinNum);
                lblAccountInput.Text = pinNum;
            }
            //User is inputting a custom withdrawl amount
            else if (interfaceStage == "CustomWithdrawl" && accountInputStage != 3)
            {
                accountInputStage++;
                string pinNum = lblOpt1.Text;
                pinNum = replaceAtIndex(accountInputStage, '3', pinNum);
                lblOpt1.Text = pinNum;
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
            //User is inputting a custom withdrawl amount
            else if (interfaceStage == "CustomWithdrawl" && accountInputStage != 3)
            {
                accountInputStage++;
                string pinNum = lblOpt1.Text;
                pinNum = replaceAtIndex(accountInputStage, '4', pinNum);
                lblOpt1.Text = pinNum;
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
            //User is inputting a custom withdrawl amount
            else if (interfaceStage == "CustomWithdrawl" && accountInputStage != 3)
            {
                accountInputStage++;
                string pinNum = lblOpt1.Text;
                pinNum = replaceAtIndex(accountInputStage, '5', pinNum);
                lblOpt1.Text = pinNum;
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
            //User is inputting a custom withdrawl amount
            else if (interfaceStage == "CustomWithdrawl" && accountInputStage != 3)
            {
                accountInputStage++;
                string pinNum = lblOpt1.Text;
                pinNum = replaceAtIndex(accountInputStage, '6', pinNum);
                lblOpt1.Text = pinNum;
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
            //User is inputting a custom withdrawl amount
            else if (interfaceStage == "CustomWithdrawl" && accountInputStage != 3)
            {
                accountInputStage++;
                string pinNum = lblOpt1.Text;
                pinNum = replaceAtIndex(accountInputStage, '7', pinNum);
                lblOpt1.Text = pinNum;
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
            //User is inputting a custom withdrawl amount
            else if (interfaceStage == "CustomWithdrawl" && accountInputStage != 3)
            {
                accountInputStage++;
                string pinNum = lblOpt1.Text;
                pinNum = replaceAtIndex(accountInputStage, '8', pinNum);
                lblOpt1.Text = pinNum;
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
            //User is inputting a custom withdrawl amount
            else if (interfaceStage == "CustomWithdrawl" && accountInputStage != 3)
            {
                accountInputStage++;
                string pinNum = lblOpt1.Text;
                pinNum = replaceAtIndex(accountInputStage, '9', pinNum);
                lblOpt1.Text = pinNum;
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
            //User is inputting a custom withdrawl amount
            else if (interfaceStage == "CustomWithdrawl" && accountInputStage != 3)
            {
                accountInputStage++;
                string pinNum = lblOpt1.Text;
                pinNum = replaceAtIndex(accountInputStage, '2', pinNum);
                lblOpt1.Text = pinNum;
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
            //User is inputting a custom withdrawl amount
            else if (interfaceStage == "CustomWithdrawl" && accountInputStage != 3)
            {
                accountInputStage++;
                string pinNum = lblOpt1.Text;
                pinNum = replaceAtIndex(accountInputStage, '1', pinNum);
                lblOpt1.Text = pinNum;
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
            //user is at custom withdraawl stage
            if (interfaceStage == "CustomWithdrawl")
            {
                accountInputStage = -1;
                lblOpt1.Text = "____";
            }
        }

        private void btnPinCancel_Click(object sender, EventArgs e)
        {
            //user is at account input stage
            if (interfaceStage == "Start")
            {
                this.Close();
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

        Form1 form1;
        public frmATM(Account[] val, Form1 f)
        {
            InitializeComponent();
            accounts = val;
            form1 = f;
        }

        void displayInterface()
        {
            //Update local account for updated balances
            updateLocalAccount();
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
                lblOpt1.Location = new Point(30, 190);
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
                lblOptions.Text = "Select deposit amount:";
                lblOptions.Location = new Point(150, 100);
                lblOpt1.Text = "10";
                lblOpt2.Text = "50";
                lblOpt3.Text = "100";
                lblOpt3.Location = new Point(460, 190);
                lblOpt4.Text = "Custom";
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
                string balance = (accounts[accountAccessed].getBalance()).ToString();
                lblOptions.Text = "Your balance is : " + balance + ", select withdrawl amount:";
                lblOptions.Location = new Point(50, 100);
                lblOpt1.Text = "10";
                lblOpt2.Text = "50";
                lblOpt3.Text = "100";
                lblOpt3.Location = new Point(460, 190);
                lblOpt4.Text = "Custom";
            }
            else if (interfaceStage == "SuccesfullTransaction")
            {
                lblOptions.Text = "Succesfull Transaction";
                lblOpt1.Visible = false;
                lblOpt3.Visible = false;
                lblOpt2.Text = "Back";
                lblOpt4.Text = "Exit";
            }
            else if (interfaceStage == "CustomWithdrawl")
            {
                accountInputStage = -1;

                lblOptions.Text = "Input amount to withdrawl:";
                lblOptions.Location = new Point(130, 60);
                lblOpt1.Text = "____";
                lblOpt1.Location = new Point(240, 90);

                lblOpt3.Visible = false;
                lblOpt2.Text = "Back";
                lblOpt4.Text = "Confirm";
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
            else if (interfaceStage == "Balance")
            {
                interfaceStage = "AccountOptions";
                displayInterface();
            }
            //Withdrawl 10 pounds from Withdrawl interface
            else if (interfaceStage == "Withdrawl" || interfaceStage == "BalanceWithdrawl")
            {
               
                if (accounts[accountAccessed].decrementBalance(10) == true)
                {
                    updateAccounts();
                    interfaceStage = "SuccesfullTransaction";
                    displayInterface();
                }
                
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
            //Back to options display
            else if (interfaceStage == "SuccesfullTransaction" || interfaceStage == "CustomWithdrawl")
            {
                interfaceStage = "AccountOptions";
                displayInterface();
            }
            //Withdrawl 50 pounds from Withdrawl interface
            else if (interfaceStage == "Withdrawl" || interfaceStage == "BalanceWithdrawl")
            {
                if (accounts[accountAccessed].decrementBalance(50) == true)
                {
                    updateAccounts();
                    interfaceStage = "SuccesfullTransaction";
                    displayInterface();
                }
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
            //Withdrawl 100 pound from Withdrawl interface
            else if (interfaceStage == "Withdrawl" || interfaceStage == "BalanceWithdrawl")
            {
                if (accounts[accountAccessed].decrementBalance(100) == true)
                {
                    updateAccounts();
                    interfaceStage = "SuccesfullTransaction";
                    displayInterface();
                }
            }
        }

        private void btnOpt4_Click(object sender, EventArgs e)
        {
            //Exit
            if (interfaceStage == "AccountOptions" || interfaceStage == "SuccesfullTransaction")
            {
                this.Close();
            }
            //Custom withdrawl option
            else if (interfaceStage == "Withdrawl" || interfaceStage == "BalanceWithdrawl")
            {
                interfaceStage = "CustomWithdrawl";
                displayInterface();
            }
            //Custom withdrawl confirm
            else if (interfaceStage == "CustomWithdrawl")
            {
                string amount = lblOpt1.Text;
                string amountFormatted = "";
                for (int i = 0; i < amount.Length; i++)
                {
                    if (Char.IsDigit(amount[i]))
                    {
                        amountFormatted = amountFormatted + amount[i];
                    }
                }
                if (accountInputStage > 0)
                {
                    int amountVal = int.Parse(amountFormatted);
                    if (accounts[accountAccessed].decrementBalance(amountVal) == true)
                    {
                        updateAccounts();
                        interfaceStage = "SuccesfullTransaction";
                        displayInterface();
                    }
                }

            }
        }

        private void lblAccountInput_Click(object sender, EventArgs e)
        {

        }
    }
}
