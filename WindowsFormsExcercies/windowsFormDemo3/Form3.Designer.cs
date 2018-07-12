namespace windowsFormDemo3
{
    partial class Demo3
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
            this.backgroundChange = new System.Windows.Forms.TableLayoutPanel();
            this.textButton = new System.Windows.Forms.Button();
            this.bgButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.displayBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.backgroundChange.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundChange
            // 
            this.backgroundChange.ColumnCount = 2;
            this.backgroundChange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.backgroundChange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.backgroundChange.Controls.Add(this.panel1, 0, 2);
            this.backgroundChange.Controls.Add(this.panel2, 0, 1);
            this.backgroundChange.Controls.Add(this.panel3, 0, 0);
            this.backgroundChange.Controls.Add(this.panel4, 1, 0);
            this.backgroundChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundChange.Location = new System.Drawing.Point(0, 0);
            this.backgroundChange.Name = "backgroundChange";
            this.backgroundChange.RowCount = 3;
            this.backgroundChange.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.backgroundChange.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.backgroundChange.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.backgroundChange.Size = new System.Drawing.Size(505, 320);
            this.backgroundChange.TabIndex = 0;
            // 
            // textButton
            // 
            this.textButton.Location = new System.Drawing.Point(21, 26);
            this.textButton.Name = "textButton";
            this.textButton.Size = new System.Drawing.Size(111, 46);
            this.textButton.TabIndex = 0;
            this.textButton.Text = "Open a Text File";
            this.textButton.UseVisualStyleBackColor = true;
            this.textButton.Click += new System.EventHandler(this.textButton_Click);
            // 
            // bgButton
            // 
            this.bgButton.Location = new System.Drawing.Point(21, 27);
            this.bgButton.Name = "bgButton";
            this.bgButton.Size = new System.Drawing.Size(111, 46);
            this.bgButton.TabIndex = 1;
            this.bgButton.Text = "Change Background Color";
            this.bgButton.UseVisualStyleBackColor = true;
            this.bgButton.Click += new System.EventHandler(this.bgButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(21, 26);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(111, 46);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Go to Next Form";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // displayBox
            // 
            this.displayBox.Location = new System.Drawing.Point(18, 26);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(293, 153);
            this.displayBox.TabIndex = 0;
            this.displayBox.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nextButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 102);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bgButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 100);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(162, 100);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.displayBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(171, 3);
            this.panel4.Name = "panel4";
            this.backgroundChange.SetRowSpan(this.panel4, 2);
            this.panel4.Size = new System.Drawing.Size(331, 206);
            this.panel4.TabIndex = 7;
            // 
            // Demo3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 320);
            this.Controls.Add(this.backgroundChange);
            this.Name = "Demo3";
            this.Text = "Demo3";
            this.backgroundChange.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel backgroundChange;
        private System.Windows.Forms.Button textButton;
        private System.Windows.Forms.Button bgButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.RichTextBox displayBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

