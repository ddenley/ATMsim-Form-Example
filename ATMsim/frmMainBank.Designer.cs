namespace ATMsim
{
    partial class frmMainBank
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEditHeader = new System.Windows.Forms.Label();
            this.lblAddHeader = new System.Windows.Forms.Label();
            this.lblDeleteHeader = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblEditAccNum = new System.Windows.Forms.Label();
            this.lblEditBal = new System.Windows.Forms.Label();
            this.lblEditPin = new System.Windows.Forms.Label();
            this.txtEditAccNum = new System.Windows.Forms.TextBox();
            this.txtEditBal = new System.Windows.Forms.TextBox();
            this.txtEditPin = new System.Windows.Forms.TextBox();
            this.btnEditSearchAcc = new System.Windows.Forms.Button();
            this.btnEditUpdate = new System.Windows.Forms.Button();
            this.lblAddAccNum = new System.Windows.Forms.Label();
            this.lblAddAccBal = new System.Windows.Forms.Label();
            this.lblAddPin = new System.Windows.Forms.Label();
            this.txtAddAccNum = new System.Windows.Forms.TextBox();
            this.txtAddBal = new System.Windows.Forms.TextBox();
            this.txtAddPin = new System.Windows.Forms.TextBox();
            this.btnAddAcc = new System.Windows.Forms.Button();
            this.txtAccDel = new System.Windows.Forms.TextBox();
            this.btnDelAcc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEditHeader
            // 
            this.lblEditHeader.AutoSize = true;
            this.lblEditHeader.Location = new System.Drawing.Point(74, 29);
            this.lblEditHeader.Name = "lblEditHeader";
            this.lblEditHeader.Size = new System.Drawing.Size(106, 13);
            this.lblEditHeader.TabIndex = 0;
            this.lblEditHeader.Text = "Edit Account Details:";
            // 
            // lblAddHeader
            // 
            this.lblAddHeader.AutoSize = true;
            this.lblAddHeader.Location = new System.Drawing.Point(74, 175);
            this.lblAddHeader.Name = "lblAddHeader";
            this.lblAddHeader.Size = new System.Drawing.Size(72, 13);
            this.lblAddHeader.TabIndex = 1;
            this.lblAddHeader.Text = "Add Account:";
            // 
            // lblDeleteHeader
            // 
            this.lblDeleteHeader.AutoSize = true;
            this.lblDeleteHeader.Location = new System.Drawing.Point(59, 334);
            this.lblDeleteHeader.Name = "lblDeleteHeader";
            this.lblDeleteHeader.Size = new System.Drawing.Size(84, 13);
            this.lblDeleteHeader.TabIndex = 2;
            this.lblDeleteHeader.Text = "Delete Account:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(672, 404);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 34);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Back";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblEditAccNum
            // 
            this.lblEditAccNum.AutoSize = true;
            this.lblEditAccNum.Location = new System.Drawing.Point(74, 66);
            this.lblEditAccNum.Name = "lblEditAccNum";
            this.lblEditAccNum.Size = new System.Drawing.Size(90, 13);
            this.lblEditAccNum.TabIndex = 4;
            this.lblEditAccNum.Text = "Account Number:";
            // 
            // lblEditBal
            // 
            this.lblEditBal.AutoSize = true;
            this.lblEditBal.Location = new System.Drawing.Point(74, 102);
            this.lblEditBal.Name = "lblEditBal";
            this.lblEditBal.Size = new System.Drawing.Size(49, 13);
            this.lblEditBal.TabIndex = 5;
            this.lblEditBal.Text = "Balance:";
            // 
            // lblEditPin
            // 
            this.lblEditPin.AutoSize = true;
            this.lblEditPin.Location = new System.Drawing.Point(74, 134);
            this.lblEditPin.Name = "lblEditPin";
            this.lblEditPin.Size = new System.Drawing.Size(25, 13);
            this.lblEditPin.TabIndex = 6;
            this.lblEditPin.Text = "Pin:";
            // 
            // txtEditAccNum
            // 
            this.txtEditAccNum.Location = new System.Drawing.Point(211, 63);
            this.txtEditAccNum.MaxLength = 6;
            this.txtEditAccNum.Name = "txtEditAccNum";
            this.txtEditAccNum.Size = new System.Drawing.Size(100, 20);
            this.txtEditAccNum.TabIndex = 7;
            this.txtEditAccNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEditAccNum_KeyPress);
            // 
            // txtEditBal
            // 
            this.txtEditBal.Location = new System.Drawing.Point(211, 95);
            this.txtEditBal.Name = "txtEditBal";
            this.txtEditBal.Size = new System.Drawing.Size(100, 20);
            this.txtEditBal.TabIndex = 8;
            this.txtEditBal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEditBal_KeyPress);
            // 
            // txtEditPin
            // 
            this.txtEditPin.Location = new System.Drawing.Point(211, 131);
            this.txtEditPin.MaxLength = 4;
            this.txtEditPin.Name = "txtEditPin";
            this.txtEditPin.Size = new System.Drawing.Size(100, 20);
            this.txtEditPin.TabIndex = 9;
            this.txtEditPin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEditPin_KeyPress);
            // 
            // btnEditSearchAcc
            // 
            this.btnEditSearchAcc.Location = new System.Drawing.Point(328, 61);
            this.btnEditSearchAcc.Name = "btnEditSearchAcc";
            this.btnEditSearchAcc.Size = new System.Drawing.Size(105, 23);
            this.btnEditSearchAcc.TabIndex = 10;
            this.btnEditSearchAcc.Text = "Find Account";
            this.btnEditSearchAcc.UseVisualStyleBackColor = true;
            this.btnEditSearchAcc.Click += new System.EventHandler(this.btnEditSearchAcc_Click);
            // 
            // btnEditUpdate
            // 
            this.btnEditUpdate.Location = new System.Drawing.Point(328, 129);
            this.btnEditUpdate.Name = "btnEditUpdate";
            this.btnEditUpdate.Size = new System.Drawing.Size(105, 23);
            this.btnEditUpdate.TabIndex = 11;
            this.btnEditUpdate.Text = "Update Account";
            this.btnEditUpdate.UseVisualStyleBackColor = true;
            this.btnEditUpdate.Click += new System.EventHandler(this.btnEditUpdate_Click);
            // 
            // lblAddAccNum
            // 
            this.lblAddAccNum.AutoSize = true;
            this.lblAddAccNum.Location = new System.Drawing.Point(74, 215);
            this.lblAddAccNum.Name = "lblAddAccNum";
            this.lblAddAccNum.Size = new System.Drawing.Size(90, 13);
            this.lblAddAccNum.TabIndex = 12;
            this.lblAddAccNum.Text = "Account Number:";
            // 
            // lblAddAccBal
            // 
            this.lblAddAccBal.AutoSize = true;
            this.lblAddAccBal.Location = new System.Drawing.Point(74, 255);
            this.lblAddAccBal.Name = "lblAddAccBal";
            this.lblAddAccBal.Size = new System.Drawing.Size(49, 13);
            this.lblAddAccBal.TabIndex = 13;
            this.lblAddAccBal.Text = "Balance:";
            // 
            // lblAddPin
            // 
            this.lblAddPin.AutoSize = true;
            this.lblAddPin.Location = new System.Drawing.Point(74, 292);
            this.lblAddPin.Name = "lblAddPin";
            this.lblAddPin.Size = new System.Drawing.Size(25, 13);
            this.lblAddPin.TabIndex = 14;
            this.lblAddPin.Text = "Pin:";
            // 
            // txtAddAccNum
            // 
            this.txtAddAccNum.Location = new System.Drawing.Point(211, 212);
            this.txtAddAccNum.MaxLength = 6;
            this.txtAddAccNum.Name = "txtAddAccNum";
            this.txtAddAccNum.Size = new System.Drawing.Size(100, 20);
            this.txtAddAccNum.TabIndex = 15;
            this.txtAddAccNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddAccNum_KeyPress);
            // 
            // txtAddBal
            // 
            this.txtAddBal.Location = new System.Drawing.Point(211, 255);
            this.txtAddBal.Name = "txtAddBal";
            this.txtAddBal.Size = new System.Drawing.Size(100, 20);
            this.txtAddBal.TabIndex = 16;
            this.txtAddBal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddBal_KeyPress);
            // 
            // txtAddPin
            // 
            this.txtAddPin.Location = new System.Drawing.Point(211, 292);
            this.txtAddPin.MaxLength = 4;
            this.txtAddPin.Name = "txtAddPin";
            this.txtAddPin.Size = new System.Drawing.Size(100, 20);
            this.txtAddPin.TabIndex = 17;
            this.txtAddPin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddPin_KeyPress);
            // 
            // btnAddAcc
            // 
            this.btnAddAcc.Location = new System.Drawing.Point(328, 289);
            this.btnAddAcc.Name = "btnAddAcc";
            this.btnAddAcc.Size = new System.Drawing.Size(105, 23);
            this.btnAddAcc.TabIndex = 18;
            this.btnAddAcc.Text = "Add Account";
            this.btnAddAcc.UseVisualStyleBackColor = true;
            this.btnAddAcc.Click += new System.EventHandler(this.btnAddAcc_Click);
            // 
            // txtAccDel
            // 
            this.txtAccDel.Location = new System.Drawing.Point(211, 331);
            this.txtAccDel.MaxLength = 6;
            this.txtAccDel.Name = "txtAccDel";
            this.txtAccDel.Size = new System.Drawing.Size(100, 20);
            this.txtAccDel.TabIndex = 19;
            this.txtAccDel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccDel_KeyPress);
            // 
            // btnDelAcc
            // 
            this.btnDelAcc.Location = new System.Drawing.Point(328, 329);
            this.btnDelAcc.Name = "btnDelAcc";
            this.btnDelAcc.Size = new System.Drawing.Size(105, 23);
            this.btnDelAcc.TabIndex = 20;
            this.btnDelAcc.Text = "Delete Account";
            this.btnDelAcc.UseVisualStyleBackColor = true;
            this.btnDelAcc.Click += new System.EventHandler(this.btnDelAcc_Click);
            // 
            // frmMainBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelAcc);
            this.Controls.Add(this.txtAccDel);
            this.Controls.Add(this.btnAddAcc);
            this.Controls.Add(this.txtAddPin);
            this.Controls.Add(this.txtAddBal);
            this.Controls.Add(this.txtAddAccNum);
            this.Controls.Add(this.lblAddPin);
            this.Controls.Add(this.lblAddAccBal);
            this.Controls.Add(this.lblAddAccNum);
            this.Controls.Add(this.btnEditUpdate);
            this.Controls.Add(this.btnEditSearchAcc);
            this.Controls.Add(this.txtEditPin);
            this.Controls.Add(this.txtEditBal);
            this.Controls.Add(this.txtEditAccNum);
            this.Controls.Add(this.lblEditPin);
            this.Controls.Add(this.lblEditBal);
            this.Controls.Add(this.lblEditAccNum);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblDeleteHeader);
            this.Controls.Add(this.lblAddHeader);
            this.Controls.Add(this.lblEditHeader);
            this.Name = "frmMainBank";
            this.Text = "frmMainBank";
            this.Load += new System.EventHandler(this.frmMainBank_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditHeader;
        private System.Windows.Forms.Label lblAddHeader;
        private System.Windows.Forms.Label lblDeleteHeader;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblEditAccNum;
        private System.Windows.Forms.Label lblEditBal;
        private System.Windows.Forms.Label lblEditPin;
        private System.Windows.Forms.TextBox txtEditAccNum;
        private System.Windows.Forms.TextBox txtEditBal;
        private System.Windows.Forms.TextBox txtEditPin;
        private System.Windows.Forms.Button btnEditSearchAcc;
        private System.Windows.Forms.Button btnEditUpdate;
        private System.Windows.Forms.Label lblAddAccNum;
        private System.Windows.Forms.Label lblAddAccBal;
        private System.Windows.Forms.Label lblAddPin;
        private System.Windows.Forms.TextBox txtAddAccNum;
        private System.Windows.Forms.TextBox txtAddBal;
        private System.Windows.Forms.TextBox txtAddPin;
        private System.Windows.Forms.Button btnAddAcc;
        private System.Windows.Forms.TextBox txtAccDel;
        private System.Windows.Forms.Button btnDelAcc;
    }
}