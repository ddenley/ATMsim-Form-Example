namespace ATMsim
{
    partial class frmATM
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAccountInput = new System.Windows.Forms.Label();
            this.lblInitialnput = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOpt4 = new System.Windows.Forms.Button();
            this.btnOpt3 = new System.Windows.Forms.Button();
            this.btnOpt2 = new System.Windows.Forms.Button();
            this.btnOpt1 = new System.Windows.Forms.Button();
            this.btnPin1 = new System.Windows.Forms.Button();
            this.btnPin2 = new System.Windows.Forms.Button();
            this.btnPin3 = new System.Windows.Forms.Button();
            this.btnPin4 = new System.Windows.Forms.Button();
            this.btnPin5 = new System.Windows.Forms.Button();
            this.btnPin6 = new System.Windows.Forms.Button();
            this.btnPin7 = new System.Windows.Forms.Button();
            this.btnPin8 = new System.Windows.Forms.Button();
            this.btnPin9 = new System.Windows.Forms.Button();
            this.btnPinEnter = new System.Windows.Forms.Button();
            this.btnPinClear = new System.Windows.Forms.Button();
            this.btnPinCancel = new System.Windows.Forms.Button();
            this.lblOpt1 = new System.Windows.Forms.Label();
            this.lblOpt3 = new System.Windows.Forms.Label();
            this.lblOpt2 = new System.Windows.Forms.Label();
            this.lblOpt4 = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.lblOptions);
            this.panel1.Controls.Add(this.lblOpt4);
            this.panel1.Controls.Add(this.lblOpt2);
            this.panel1.Controls.Add(this.lblOpt3);
            this.panel1.Controls.Add(this.lblOpt1);
            this.panel1.Controls.Add(this.lblAccountInput);
            this.panel1.Controls.Add(this.lblInitialnput);
            this.panel1.Location = new System.Drawing.Point(78, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 386);
            this.panel1.TabIndex = 0;
            // 
            // lblAccountInput
            // 
            this.lblAccountInput.AutoSize = true;
            this.lblAccountInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountInput.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAccountInput.Location = new System.Drawing.Point(202, 17);
            this.lblAccountInput.Name = "lblAccountInput";
            this.lblAccountInput.Size = new System.Drawing.Size(161, 26);
            this.lblAccountInput.TabIndex = 1;
            this.lblAccountInput.Text = "lblAccountInput";
            // 
            // lblInitialnput
            // 
            this.lblInitialnput.AutoSize = true;
            this.lblInitialnput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitialnput.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInitialnput.Location = new System.Drawing.Point(15, 17);
            this.lblInitialnput.Name = "lblInitialnput";
            this.lblInitialnput.Size = new System.Drawing.Size(133, 26);
            this.lblInitialnput.TabIndex = 0;
            this.lblInitialnput.Text = "lblInitialInput";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.btnOpt4);
            this.panel2.Controls.Add(this.btnOpt3);
            this.panel2.Controls.Add(this.btnOpt2);
            this.panel2.Controls.Add(this.btnOpt1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(25, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(681, 450);
            this.panel2.TabIndex = 1;
            // 
            // btnOpt4
            // 
            this.btnOpt4.Location = new System.Drawing.Point(617, 338);
            this.btnOpt4.Name = "btnOpt4";
            this.btnOpt4.Size = new System.Drawing.Size(51, 49);
            this.btnOpt4.TabIndex = 4;
            this.btnOpt4.Text = "4";
            this.btnOpt4.UseVisualStyleBackColor = true;
            this.btnOpt4.Click += new System.EventHandler(this.btnOpt4_Click);
            // 
            // btnOpt3
            // 
            this.btnOpt3.Location = new System.Drawing.Point(617, 219);
            this.btnOpt3.Name = "btnOpt3";
            this.btnOpt3.Size = new System.Drawing.Size(51, 49);
            this.btnOpt3.TabIndex = 3;
            this.btnOpt3.Text = "3";
            this.btnOpt3.UseVisualStyleBackColor = true;
            this.btnOpt3.Click += new System.EventHandler(this.btnOpt3_Click);
            // 
            // btnOpt2
            // 
            this.btnOpt2.Location = new System.Drawing.Point(21, 338);
            this.btnOpt2.Name = "btnOpt2";
            this.btnOpt2.Size = new System.Drawing.Size(51, 49);
            this.btnOpt2.TabIndex = 2;
            this.btnOpt2.Text = "2";
            this.btnOpt2.UseVisualStyleBackColor = true;
            this.btnOpt2.Click += new System.EventHandler(this.btnOpt2_Click);
            // 
            // btnOpt1
            // 
            this.btnOpt1.Location = new System.Drawing.Point(21, 219);
            this.btnOpt1.Name = "btnOpt1";
            this.btnOpt1.Size = new System.Drawing.Size(51, 49);
            this.btnOpt1.TabIndex = 1;
            this.btnOpt1.Text = "1";
            this.btnOpt1.UseVisualStyleBackColor = true;
            this.btnOpt1.Click += new System.EventHandler(this.btnOpt1_Click);
            // 
            // btnPin1
            // 
            this.btnPin1.Location = new System.Drawing.Point(733, 59);
            this.btnPin1.Name = "btnPin1";
            this.btnPin1.Size = new System.Drawing.Size(43, 43);
            this.btnPin1.TabIndex = 2;
            this.btnPin1.Text = "1";
            this.btnPin1.UseVisualStyleBackColor = true;
            this.btnPin1.Click += new System.EventHandler(this.btnPin1_Click);
            // 
            // btnPin2
            // 
            this.btnPin2.Location = new System.Drawing.Point(782, 59);
            this.btnPin2.Name = "btnPin2";
            this.btnPin2.Size = new System.Drawing.Size(43, 43);
            this.btnPin2.TabIndex = 3;
            this.btnPin2.Text = "2";
            this.btnPin2.UseVisualStyleBackColor = true;
            this.btnPin2.Click += new System.EventHandler(this.btnPin2_Click);
            // 
            // btnPin3
            // 
            this.btnPin3.Location = new System.Drawing.Point(831, 59);
            this.btnPin3.Name = "btnPin3";
            this.btnPin3.Size = new System.Drawing.Size(43, 43);
            this.btnPin3.TabIndex = 4;
            this.btnPin3.Text = "3";
            this.btnPin3.UseVisualStyleBackColor = true;
            this.btnPin3.Click += new System.EventHandler(this.btnPin3_Click);
            // 
            // btnPin4
            // 
            this.btnPin4.Location = new System.Drawing.Point(733, 117);
            this.btnPin4.Name = "btnPin4";
            this.btnPin4.Size = new System.Drawing.Size(43, 43);
            this.btnPin4.TabIndex = 5;
            this.btnPin4.Text = "4";
            this.btnPin4.UseVisualStyleBackColor = true;
            this.btnPin4.Click += new System.EventHandler(this.btnPin4_Click);
            // 
            // btnPin5
            // 
            this.btnPin5.Location = new System.Drawing.Point(782, 117);
            this.btnPin5.Name = "btnPin5";
            this.btnPin5.Size = new System.Drawing.Size(43, 43);
            this.btnPin5.TabIndex = 6;
            this.btnPin5.Text = "5";
            this.btnPin5.UseVisualStyleBackColor = true;
            this.btnPin5.Click += new System.EventHandler(this.btnPin5_Click);
            // 
            // btnPin6
            // 
            this.btnPin6.Location = new System.Drawing.Point(831, 117);
            this.btnPin6.Name = "btnPin6";
            this.btnPin6.Size = new System.Drawing.Size(43, 43);
            this.btnPin6.TabIndex = 7;
            this.btnPin6.Text = "6";
            this.btnPin6.UseVisualStyleBackColor = true;
            this.btnPin6.Click += new System.EventHandler(this.btnPin6_Click);
            // 
            // btnPin7
            // 
            this.btnPin7.Location = new System.Drawing.Point(733, 171);
            this.btnPin7.Name = "btnPin7";
            this.btnPin7.Size = new System.Drawing.Size(43, 43);
            this.btnPin7.TabIndex = 8;
            this.btnPin7.Text = "7";
            this.btnPin7.UseVisualStyleBackColor = true;
            this.btnPin7.Click += new System.EventHandler(this.btnPin7_Click);
            // 
            // btnPin8
            // 
            this.btnPin8.Location = new System.Drawing.Point(782, 171);
            this.btnPin8.Name = "btnPin8";
            this.btnPin8.Size = new System.Drawing.Size(43, 43);
            this.btnPin8.TabIndex = 9;
            this.btnPin8.Text = "8";
            this.btnPin8.UseVisualStyleBackColor = true;
            this.btnPin8.Click += new System.EventHandler(this.btnPin8_Click);
            // 
            // btnPin9
            // 
            this.btnPin9.Location = new System.Drawing.Point(831, 171);
            this.btnPin9.Name = "btnPin9";
            this.btnPin9.Size = new System.Drawing.Size(43, 43);
            this.btnPin9.TabIndex = 10;
            this.btnPin9.Text = "9";
            this.btnPin9.UseVisualStyleBackColor = true;
            this.btnPin9.Click += new System.EventHandler(this.btnPin9_Click);
            // 
            // btnPinEnter
            // 
            this.btnPinEnter.FlatAppearance.BorderSize = 0;
            this.btnPinEnter.Location = new System.Drawing.Point(948, 59);
            this.btnPinEnter.Name = "btnPinEnter";
            this.btnPinEnter.Size = new System.Drawing.Size(53, 43);
            this.btnPinEnter.TabIndex = 11;
            this.btnPinEnter.Text = "Enter";
            this.btnPinEnter.UseVisualStyleBackColor = true;
            this.btnPinEnter.Click += new System.EventHandler(this.btnPinEnter_Click);
            // 
            // btnPinClear
            // 
            this.btnPinClear.Location = new System.Drawing.Point(948, 117);
            this.btnPinClear.Name = "btnPinClear";
            this.btnPinClear.Size = new System.Drawing.Size(53, 43);
            this.btnPinClear.TabIndex = 12;
            this.btnPinClear.Text = "Clear";
            this.btnPinClear.UseVisualStyleBackColor = true;
            this.btnPinClear.Click += new System.EventHandler(this.btnPinClear_Click);
            // 
            // btnPinCancel
            // 
            this.btnPinCancel.Location = new System.Drawing.Point(948, 171);
            this.btnPinCancel.Name = "btnPinCancel";
            this.btnPinCancel.Size = new System.Drawing.Size(53, 43);
            this.btnPinCancel.TabIndex = 13;
            this.btnPinCancel.Text = "Cancel";
            this.btnPinCancel.UseVisualStyleBackColor = true;
            this.btnPinCancel.Click += new System.EventHandler(this.btnPinCancel_Click);
            // 
            // lblOpt1
            // 
            this.lblOpt1.AutoSize = true;
            this.lblOpt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpt1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOpt1.Location = new System.Drawing.Point(26, 190);
            this.lblOpt1.Name = "lblOpt1";
            this.lblOpt1.Size = new System.Drawing.Size(81, 26);
            this.lblOpt1.TabIndex = 2;
            this.lblOpt1.Text = "lblOpt1";
            // 
            // lblOpt3
            // 
            this.lblOpt3.AutoSize = true;
            this.lblOpt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpt3.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOpt3.Location = new System.Drawing.Point(431, 190);
            this.lblOpt3.Name = "lblOpt3";
            this.lblOpt3.Size = new System.Drawing.Size(81, 26);
            this.lblOpt3.TabIndex = 3;
            this.lblOpt3.Text = "lblOpt3";
            // 
            // lblOpt2
            // 
            this.lblOpt2.AutoSize = true;
            this.lblOpt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpt2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOpt2.Location = new System.Drawing.Point(26, 309);
            this.lblOpt2.Name = "lblOpt2";
            this.lblOpt2.Size = new System.Drawing.Size(81, 26);
            this.lblOpt2.TabIndex = 4;
            this.lblOpt2.Text = "lblOpt2";
            // 
            // lblOpt4
            // 
            this.lblOpt4.AutoSize = true;
            this.lblOpt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpt4.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOpt4.Location = new System.Drawing.Point(431, 309);
            this.lblOpt4.Name = "lblOpt4";
            this.lblOpt4.Size = new System.Drawing.Size(81, 26);
            this.lblOpt4.TabIndex = 5;
            this.lblOpt4.Text = "lblOpt4";
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptions.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOptions.Location = new System.Drawing.Point(202, 102);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(109, 26);
            this.lblOptions.TabIndex = 6;
            this.lblOptions.Text = "lblOptions";
            // 
            // frmATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1041, 496);
            this.Controls.Add(this.btnPinCancel);
            this.Controls.Add(this.btnPinClear);
            this.Controls.Add(this.btnPinEnter);
            this.Controls.Add(this.btnPin9);
            this.Controls.Add(this.btnPin8);
            this.Controls.Add(this.btnPin7);
            this.Controls.Add(this.btnPin6);
            this.Controls.Add(this.btnPin5);
            this.Controls.Add(this.btnPin4);
            this.Controls.Add(this.btnPin3);
            this.Controls.Add(this.btnPin2);
            this.Controls.Add(this.btnPin1);
            this.Controls.Add(this.panel2);
            this.Name = "frmATM";
            this.Text = "frmATM";
            this.Load += new System.EventHandler(this.frmATM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOpt4;
        private System.Windows.Forms.Button btnOpt3;
        private System.Windows.Forms.Button btnOpt2;
        private System.Windows.Forms.Button btnOpt1;
        private System.Windows.Forms.Button btnPin1;
        private System.Windows.Forms.Button btnPin2;
        private System.Windows.Forms.Button btnPin3;
        private System.Windows.Forms.Button btnPin4;
        private System.Windows.Forms.Button btnPin5;
        private System.Windows.Forms.Button btnPin6;
        private System.Windows.Forms.Button btnPin7;
        private System.Windows.Forms.Button btnPin8;
        private System.Windows.Forms.Button btnPin9;
        private System.Windows.Forms.Button btnPinEnter;
        private System.Windows.Forms.Button btnPinClear;
        private System.Windows.Forms.Button btnPinCancel;
        private System.Windows.Forms.Label lblInitialnput;
        private System.Windows.Forms.Label lblAccountInput;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Label lblOpt4;
        private System.Windows.Forms.Label lblOpt2;
        private System.Windows.Forms.Label lblOpt3;
        private System.Windows.Forms.Label lblOpt1;
    }
}