namespace hangManForm
{
    partial class Hangman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hangman));
            this.startButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.letterSix = new System.Windows.Forms.Label();
            this.letterFive = new System.Windows.Forms.Label();
            this.letterFour = new System.Windows.Forms.Label();
            this.letterThree = new System.Windows.Forms.Label();
            this.letterTwo = new System.Windows.Forms.Label();
            this.letterOne = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.feedback = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guess = new System.Windows.Forms.TextBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.armTwo = new System.Windows.Forms.PictureBox();
            this.armOne = new System.Windows.Forms.PictureBox();
            this.legs = new System.Windows.Forms.PictureBox();
            this.body = new System.Windows.Forms.PictureBox();
            this.head = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.armTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.legs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.body)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.head)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(139, 34);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(84, 28);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Lets Play Hangman!";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.letterSix);
            this.panel2.Controls.Add(this.letterFive);
            this.panel2.Controls.Add(this.letterFour);
            this.panel2.Controls.Add(this.letterThree);
            this.panel2.Controls.Add(this.letterTwo);
            this.panel2.Controls.Add(this.letterOne);
            this.panel2.Location = new System.Drawing.Point(47, 317);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 21);
            this.panel2.TabIndex = 43;
            // 
            // letterSix
            // 
            this.letterSix.AutoSize = true;
            this.letterSix.Location = new System.Drawing.Point(234, 4);
            this.letterSix.Name = "letterSix";
            this.letterSix.Size = new System.Drawing.Size(13, 13);
            this.letterSix.TabIndex = 14;
            this.letterSix.Tag = "6";
            this.letterSix.Text = "_";
            // 
            // letterFive
            // 
            this.letterFive.AutoSize = true;
            this.letterFive.Location = new System.Drawing.Point(193, 4);
            this.letterFive.Name = "letterFive";
            this.letterFive.Size = new System.Drawing.Size(13, 13);
            this.letterFive.TabIndex = 13;
            this.letterFive.Tag = "5";
            this.letterFive.Text = "_";
            // 
            // letterFour
            // 
            this.letterFour.AutoSize = true;
            this.letterFour.Location = new System.Drawing.Point(152, 4);
            this.letterFour.Name = "letterFour";
            this.letterFour.Size = new System.Drawing.Size(13, 13);
            this.letterFour.TabIndex = 12;
            this.letterFour.Tag = "4";
            this.letterFour.Text = "_";
            // 
            // letterThree
            // 
            this.letterThree.AutoSize = true;
            this.letterThree.Location = new System.Drawing.Point(111, 4);
            this.letterThree.Name = "letterThree";
            this.letterThree.Size = new System.Drawing.Size(13, 13);
            this.letterThree.TabIndex = 11;
            this.letterThree.Tag = "3";
            this.letterThree.Text = "_";
            // 
            // letterTwo
            // 
            this.letterTwo.AutoSize = true;
            this.letterTwo.Location = new System.Drawing.Point(70, 4);
            this.letterTwo.Name = "letterTwo";
            this.letterTwo.Size = new System.Drawing.Size(13, 13);
            this.letterTwo.TabIndex = 10;
            this.letterTwo.Tag = "2";
            this.letterTwo.Text = "_";
            // 
            // letterOne
            // 
            this.letterOne.AutoSize = true;
            this.letterOne.Location = new System.Drawing.Point(29, 4);
            this.letterOne.Name = "letterOne";
            this.letterOne.Size = new System.Drawing.Size(13, 13);
            this.letterOne.TabIndex = 9;
            this.letterOne.Tag = "1";
            this.letterOne.Text = "_";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.feedback);
            this.panel1.Controls.Add(this.Result);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.guess);
            this.panel1.Controls.Add(this.guessButton);
            this.panel1.Location = new System.Drawing.Point(51, 344);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 99);
            this.panel1.TabIndex = 44;
            this.panel1.Visible = false;
            // 
            // feedback
            // 
            this.feedback.AutoSize = true;
            this.feedback.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.feedback.Location = new System.Drawing.Point(224, 7);
            this.feedback.Name = "feedback";
            this.feedback.Size = new System.Drawing.Size(0, 17);
            this.feedback.TabIndex = 42;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(86, 81);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 13);
            this.Result.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Guess a letter:";
            // 
            // guess
            // 
            this.guess.Location = new System.Drawing.Point(130, 4);
            this.guess.Name = "guess";
            this.guess.Size = new System.Drawing.Size(57, 20);
            this.guess.TabIndex = 39;
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(95, 39);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(84, 28);
            this.guessButton.TabIndex = 38;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.armTwo);
            this.panel3.Controls.Add(this.armOne);
            this.panel3.Controls.Add(this.legs);
            this.panel3.Controls.Add(this.body);
            this.panel3.Controls.Add(this.head);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(22, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(332, 249);
            this.panel3.TabIndex = 45;
            this.panel3.Visible = false;
            // 
            // armTwo
            // 
            this.armTwo.Image = ((System.Drawing.Image)(resources.GetObject("armTwo.Image")));
            this.armTwo.Location = new System.Drawing.Point(232, 88);
            this.armTwo.Name = "armTwo";
            this.armTwo.Size = new System.Drawing.Size(53, 20);
            this.armTwo.TabIndex = 48;
            this.armTwo.TabStop = false;
            this.armTwo.Visible = false;
            // 
            // armOne
            // 
            this.armOne.Image = ((System.Drawing.Image)(resources.GetObject("armOne.Image")));
            this.armOne.Location = new System.Drawing.Point(152, 89);
            this.armOne.Name = "armOne";
            this.armOne.Size = new System.Drawing.Size(50, 17);
            this.armOne.TabIndex = 47;
            this.armOne.TabStop = false;
            this.armOne.Visible = false;
            // 
            // legs
            // 
            this.legs.Image = ((System.Drawing.Image)(resources.GetObject("legs.Image")));
            this.legs.Location = new System.Drawing.Point(175, 163);
            this.legs.Name = "legs";
            this.legs.Size = new System.Drawing.Size(87, 55);
            this.legs.TabIndex = 46;
            this.legs.TabStop = false;
            this.legs.Visible = false;
            // 
            // body
            // 
            this.body.Image = ((System.Drawing.Image)(resources.GetObject("body.Image")));
            this.body.Location = new System.Drawing.Point(203, 87);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(28, 78);
            this.body.TabIndex = 45;
            this.body.TabStop = false;
            this.body.Visible = false;
            // 
            // head
            // 
            this.head.Image = ((System.Drawing.Image)(resources.GetObject("head.Image")));
            this.head.Location = new System.Drawing.Point(189, 30);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(55, 55);
            this.head.TabIndex = 44;
            this.head.TabStop = false;
            this.head.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 240);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // Hangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 455);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startButton);
            this.Name = "Hangman";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.armTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.legs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.body)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.head)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label letterSix;
        private System.Windows.Forms.Label letterFive;
        private System.Windows.Forms.Label letterFour;
        private System.Windows.Forms.Label letterThree;
        private System.Windows.Forms.Label letterTwo;
        private System.Windows.Forms.Label letterOne;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label feedback;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox guess;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox armTwo;
        private System.Windows.Forms.PictureBox armOne;
        private System.Windows.Forms.PictureBox legs;
        private System.Windows.Forms.PictureBox body;
        private System.Windows.Forms.PictureBox head;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

