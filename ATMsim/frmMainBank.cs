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
    public partial class frmMainBank : Form
    {

        int accNumInput;
        int accSelectedBal;
        int accSelectedPin;
        bool accFound;
        int accIndex;

        Form1 frm1;
        public frmMainBank(Form1 f)
        {
            InitializeComponent();
            frm1 = f;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmMainBank_Load(object sender, EventArgs e)
        {
            txtEditBal.Enabled = false;
            txtEditPin.Enabled = false;
            btnEditUpdate.Enabled = false;
        }

        private void txtEditAccNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEditBal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtEditPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnEditSearchAcc_Click(object sender, EventArgs e)
        {
            accNumInput = Int32.Parse(txtEditAccNum.Text);
            accFound = false;
            for (int i = 0; i < frm1.ac.Length; i++)
            {
                if (accNumInput == frm1.ac[i].getAccountNum())
                {
                    accSelectedBal = frm1.ac[i].getBalance();
                    accSelectedPin = frm1.ac[i].getPin();
                    txtEditBal.Text = (accSelectedBal).ToString();
                    txtEditPin.Text = (accSelectedPin).ToString();
                    txtEditBal.Enabled = true;
                    txtEditPin.Enabled = true;
                    btnEditUpdate.Enabled = true;
                    accFound = true;
                    accIndex = i;
                }
                if (accFound == false)
                {
                    txtEditBal.Text = "";
                    txtEditPin.Text = "";
                    txtEditBal.Enabled = false;
                    txtEditPin.Enabled = false;
                    btnEditUpdate.Enabled = false;
                }
            }
        }

        private void btnEditUpdate_Click(object sender, EventArgs e)
        {
            accNumInput = Int32.Parse(txtEditAccNum.Text);
            int bal = Int32.Parse(txtEditBal.Text);
            int pin = Int32.Parse(txtEditPin.Text);
            if (txtEditAccNum.TextLength == 6 && txtEditPin.TextLength == 4)
            {
                frm1.ac[accIndex].setBalance(bal);
                frm1.ac[accIndex].setPin(pin);
                accSelectedBal = frm1.ac[accIndex].getBalance();
                accSelectedPin = frm1.ac[accIndex].getPin();
                txtEditBal.Text = (accSelectedBal).ToString();
                txtEditPin.Text = (accSelectedPin).ToString();
            }
            else
            {
                MessageBox.Show("Input Error", "Please input viable pin and/or account number.");
            }
        }

        private void txtAddAccNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAddBal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAddPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAddAcc_Click(object sender, EventArgs e)
        {
            int bal = 0;
            if (txtAddPin.TextLength == 4 && txtAddAccNum.TextLength == 6)
            {
                accNumInput = Int32.Parse(txtAddAccNum.Text);
                bal = Int32.Parse(txtAddBal.Text);
                int pin = Int32.Parse(txtAddPin.Text);
                int newIndex = 0;
                bool accExists = false;
                for (int i = 0; i < frm1.ac.Length; i++)
                {
                    if (accNumInput == frm1.ac[i].getAccountNum())
                    {
                        accExists = true;
                        newIndex = i;
                    }
                }
                if (accExists == false)
                {

                    frm1.ac[newIndex + 1] = new Account(bal, pin, accNumInput);
                }
                else
                {
                    MessageBox.Show("Please input unique account number.", "Input error");
                }
            }
            else
            {
                MessageBox.Show("Please input valid pin and/or account number.", "Input error");
            }
        }

        private void btnDelAcc_Click(object sender, EventArgs e)
        {
            bool accExists = false;
            int newIndex = 0;
            if (txtAccDel.TextLength == 6)
            {
                accNumInput = Int32.Parse(txtAccDel.Text);
                for (int i = 0; i < frm1.ac.Length; i++)
                {
                    if (accNumInput == frm1.ac[i].getAccountNum())
                    {
                        accExists = true;
                        newIndex = i;
                    }
                }
                if (accExists == true)
                {
                    frm1.ac[newIndex].setPin(0);
                    frm1.ac[newIndex].setBalance(0);
                    frm1.ac[newIndex].setAccNum(0);
                }
                else
                {
                    MessageBox.Show("Please input valid account number", "Input Error");
                }
            }
            else
            {
                MessageBox.Show("Please input valid pin account number.", "Input error");
            }
        }

        private void txtAccDel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
