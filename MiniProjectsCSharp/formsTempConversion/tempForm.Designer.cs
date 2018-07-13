namespace formsTempConversion
{
    partial class tempForm
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
            this.converter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.convertedTemp = new System.Windows.Forms.Label();
            this.tempEntry = new System.Windows.Forms.TextBox();
            this.originalScale = new System.Windows.Forms.ComboBox();
            this.convertedScale = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // converter
            // 
            this.converter.Location = new System.Drawing.Point(260, 111);
            this.converter.Name = "converter";
            this.converter.Size = new System.Drawing.Size(91, 32);
            this.converter.TabIndex = 0;
            this.converter.Text = "Convert";
            this.converter.UseVisualStyleBackColor = true;
            this.converter.Click += new System.EventHandler(this.converter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Convert From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Convert To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Temperature Converter";
            // 
            // convertedTemp
            // 
            this.convertedTemp.AutoSize = true;
            this.convertedTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertedTemp.Location = new System.Drawing.Point(205, 173);
            this.convertedTemp.Name = "convertedTemp";
            this.convertedTemp.Size = new System.Drawing.Size(0, 20);
            this.convertedTemp.TabIndex = 4;
            // 
            // tempEntry
            // 
            this.tempEntry.Location = new System.Drawing.Point(260, 59);
            this.tempEntry.Name = "tempEntry";
            this.tempEntry.Size = new System.Drawing.Size(91, 20);
            this.tempEntry.TabIndex = 7;
            // 
            // originalScale
            // 
            this.originalScale.FormattingEnabled = true;
            this.originalScale.Items.AddRange(new object[] {
            "Centigrade",
            "Fahrenheit",
            "Kelvin"});
            this.originalScale.Location = new System.Drawing.Point(115, 62);
            this.originalScale.Name = "originalScale";
            this.originalScale.Size = new System.Drawing.Size(99, 21);
            this.originalScale.TabIndex = 8;
            // 
            // convertedScale
            // 
            this.convertedScale.FormattingEnabled = true;
            this.convertedScale.Items.AddRange(new object[] {
            "Centigrade",
            "Fahrenheit",
            "Kelvin"});
            this.convertedScale.Location = new System.Drawing.Point(116, 118);
            this.convertedScale.Name = "convertedScale";
            this.convertedScale.Size = new System.Drawing.Size(98, 21);
            this.convertedScale.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 203);
            this.Controls.Add(this.convertedScale);
            this.Controls.Add(this.originalScale);
            this.Controls.Add(this.tempEntry);
            this.Controls.Add(this.convertedTemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.converter);
            this.Name = "Form1";
            this.Text = "Temperature";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button converter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label convertedTemp;
        private System.Windows.Forms.TextBox tempEntry;
        private System.Windows.Forms.ComboBox originalScale;
        private System.Windows.Forms.ComboBox convertedScale;
    }
}

