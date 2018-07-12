namespace windowsFormDemo
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.dateSelectorLabel = new System.Windows.Forms.Label();
            this.displayMessage = new System.Windows.Forms.Label();
            this.nameEntry = new System.Windows.Forms.TextBox();
            this.birthdayDateSelector = new System.Windows.Forms.DateTimePicker();
            this.getMessage = new System.Windows.Forms.Button();
            this.closeForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(51, 47);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(91, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Enter Your Name:";
            // 
            // dateSelectorLabel
            // 
            this.dateSelectorLabel.AutoSize = true;
            this.dateSelectorLabel.Location = new System.Drawing.Point(51, 83);
            this.dateSelectorLabel.Name = "dateSelectorLabel";
            this.dateSelectorLabel.Size = new System.Drawing.Size(101, 13);
            this.dateSelectorLabel.TabIndex = 1;
            this.dateSelectorLabel.Text = "Enter Your Birthday:";
            // 
            // displayMessage
            // 
            this.displayMessage.AutoSize = true;
            this.displayMessage.Location = new System.Drawing.Point(92, 156);
            this.displayMessage.Name = "displayMessage";
            this.displayMessage.Size = new System.Drawing.Size(50, 13);
            this.displayMessage.TabIndex = 2;
            this.displayMessage.Text = "Message";
            this.displayMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameEntry
            // 
            this.nameEntry.Location = new System.Drawing.Point(163, 44);
            this.nameEntry.Name = "nameEntry";
            this.nameEntry.Size = new System.Drawing.Size(100, 20);
            this.nameEntry.TabIndex = 3;
            // 
            // birthdayDateSelector
            // 
            this.birthdayDateSelector.Location = new System.Drawing.Point(163, 77);
            this.birthdayDateSelector.Name = "birthdayDateSelector";
            this.birthdayDateSelector.Size = new System.Drawing.Size(200, 20);
            this.birthdayDateSelector.TabIndex = 4;
            // 
            // getMessage
            // 
            this.getMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.getMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.getMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getMessage.ForeColor = System.Drawing.Color.Fuchsia;
            this.getMessage.Location = new System.Drawing.Point(142, 115);
            this.getMessage.Name = "getMessage";
            this.getMessage.Size = new System.Drawing.Size(156, 23);
            this.getMessage.TabIndex = 5;
            this.getMessage.Text = "Click to get a message!";
            this.getMessage.UseVisualStyleBackColor = false;
            this.getMessage.Click += new System.EventHandler(this.getMessage_Click);
            // 
            // closeForm
            // 
            this.closeForm.Location = new System.Drawing.Point(188, 186);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(75, 23);
            this.closeForm.TabIndex = 6;
            this.closeForm.Text = "CLOSE";
            this.closeForm.UseVisualStyleBackColor = true;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 221);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.getMessage);
            this.Controls.Add(this.birthdayDateSelector);
            this.Controls.Add(this.nameEntry);
            this.Controls.Add(this.displayMessage);
            this.Controls.Add(this.dateSelectorLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form1";
            this.Text = "BirthdayMessageDemo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label dateSelectorLabel;
        private System.Windows.Forms.Label displayMessage;
        private System.Windows.Forms.TextBox nameEntry;
        private System.Windows.Forms.DateTimePicker birthdayDateSelector;
        private System.Windows.Forms.Button getMessage;
        private System.Windows.Forms.Button closeForm;
    }
}

