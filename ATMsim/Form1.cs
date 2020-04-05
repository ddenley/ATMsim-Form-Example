using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ATMsim
{
    public partial class Form1 : Form
    {
        public Account[] ac = new Account[3];
        frmMainBank mainBank;

        bool dataRace = false;


        public void updateAccount(Account[] valAC)
        {
            ac = valAC;
        }

        public Account[] getAccounts()
        {
            return ac;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmATM atm = new frmATM(ac, this);
            atm.setSemaphore(dataRace);
            atm.Show();
        }

        /*
         * This function initilises the 3 accounts 
         * and instanciates the ATM class passing a referance to the account information
         * 
         */
        public void Program()
        {
            ac[0] = new Account(300, 1111, 111111);
            ac[1] = new Account(750, 2222, 222222);
            ac[2] = new Account(3000, 3333, 333333);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Program();
        }

        private void btnMainBank_Click(object sender, EventArgs e)
        {
            mainBank = new frmMainBank(this);
            mainBank.Show();
        }

        private void btnDataRace_Click(object sender, EventArgs e)
        {
            if (dataRace == true)
            {
                dataRace = false;
                btnDataRace.Text = "Data Race: Off";
            }
            else if (dataRace == false)
            {
                dataRace = true;
                btnDataRace.Text = "Data Race: On";
            }
        }
    }

    /*
     *   The Account class encapusulates all features of a simple bank account
     */
    public class Account
    {
        //the attributes for the account
        private int balance;
        private int pin;
        private int accountNum;

        // a constructor that takes initial values for each of the attributes (balance, pin, accountNumber)
        public Account(int balance, int pin, int accountNum)
        {
            this.balance = balance;
            this.pin = pin;
            this.accountNum = accountNum;
        }

        //getter and setter functions for balance
        public int getBalance()
        {
            return balance;
        }
        public void setBalance(int newBalance)
        {
            this.balance = newBalance;
        }
        //getter and setter for pin
        public int getPin()
        {
            return pin;
        }
        public void setPin(int newBalance)
        {
            this.pin = newBalance;
        }

        /*
         *   This funciton allows us to decrement the balance of an account
         *   it perfomes a simple check to ensure the balance is greater tha
         *   the amount being debeted
         *   
         *   reurns:
         *   true if the transactions if possible
         *   false if there are insufficent funds in the account
         */
        public Boolean decrementBalance(int amount)
        {
            if (this.balance >= amount)
            {
                balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        /*
         * This funciton check the account pin against the argument passed to it
         *
         * returns:
         * true if they match
         * false if they do not
         */
        public Boolean checkPin(int pinEntered)
        {
            if (pinEntered == pin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int getAccountNum()
        {
            return accountNum;
        }

    }
}
