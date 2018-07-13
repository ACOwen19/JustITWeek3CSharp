namespace creditCardCheckerWLuhn
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
            this.label1 = new System.Windows.Forms.Label();
            this.showBalance = new System.Windows.Forms.Label();
            this.cardEntry = new System.Windows.Forms.TextBox();
            this.balButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card No:";
            // 
            // showBalance
            // 
            this.showBalance.AutoSize = true;
            this.showBalance.Location = new System.Drawing.Point(191, 179);
            this.showBalance.Name = "showBalance";
            this.showBalance.Size = new System.Drawing.Size(0, 13);
            this.showBalance.TabIndex = 1;
            // 
            // cardEntry
            // 
            this.cardEntry.Location = new System.Drawing.Point(132, 89);
            this.cardEntry.Name = "cardEntry";
            this.cardEntry.Size = new System.Drawing.Size(160, 20);
            this.cardEntry.TabIndex = 2;
            // 
            // balButton
            // 
            this.balButton.Location = new System.Drawing.Point(155, 131);
            this.balButton.Name = "balButton";
            this.balButton.Size = new System.Drawing.Size(109, 22);
            this.balButton.TabIndex = 3;
            this.balButton.Text = "Get Balance";
            this.balButton.UseVisualStyleBackColor = true;
            this.balButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter your 10 digit card number to check your balcance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 280);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.balButton);
            this.Controls.Add(this.cardEntry);
            this.Controls.Add(this.showBalance);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label showBalance;
        private System.Windows.Forms.TextBox cardEntry;
        private System.Windows.Forms.Button balButton;
        private System.Windows.Forms.Label label3;
    }
}

