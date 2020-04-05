namespace ATMsim
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnMainBank = new System.Windows.Forms.Button();
            this.btnDataRace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "New ATM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMainBank
            // 
            this.btnMainBank.Location = new System.Drawing.Point(268, 74);
            this.btnMainBank.Name = "btnMainBank";
            this.btnMainBank.Size = new System.Drawing.Size(99, 38);
            this.btnMainBank.TabIndex = 1;
            this.btnMainBank.Text = "Main Bank";
            this.btnMainBank.UseVisualStyleBackColor = true;
            this.btnMainBank.Click += new System.EventHandler(this.btnMainBank_Click);
            // 
            // btnDataRace
            // 
            this.btnDataRace.Location = new System.Drawing.Point(574, 74);
            this.btnDataRace.Name = "btnDataRace";
            this.btnDataRace.Size = new System.Drawing.Size(150, 38);
            this.btnDataRace.TabIndex = 2;
            this.btnDataRace.Text = "Data Race: On";
            this.btnDataRace.UseVisualStyleBackColor = true;
            this.btnDataRace.Click += new System.EventHandler(this.btnDataRace_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDataRace);
            this.Controls.Add(this.btnMainBank);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMainBank;
        private System.Windows.Forms.Button btnDataRace;
    }
}

