namespace TestNewEncryption
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            passwordTextBox = new TextBox();
            oldGroupBox = new GroupBox();
            label4 = new Label();
            label13 = new Label();
            label3 = new Label();
            label2 = new Label();
            decryOldTextBox = new TextBox();
            decryKeyOldTextBox = new TextBox();
            encryOldTextBox = new TextBox();
            KeyEncrOldTextBox = new TextBox();
            keyOldTextBox = new TextBox();
            twoGroupBox = new GroupBox();
            label16 = new Label();
            decryKeyTwoTextBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            decryTwoTextBox = new TextBox();
            encryTwoTextBox = new TextBox();
            KeyEncrTwoTextBox = new TextBox();
            keyTwoTextBox = new TextBox();
            threeGroupBox = new GroupBox();
            label19 = new Label();
            decryKeyThreeTextBox = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            decryThreeTextBox = new TextBox();
            encryThreeTextBox = new TextBox();
            KeyEncrThreeTextBox = new TextBox();
            keyThreeTextBox = new TextBox();
            generateButton = new Button();
            falsifyButton = new Button();
            falsePasswordTextBox = new TextBox();
            oldGroupBox.SuspendLayout();
            twoGroupBox.SuspendLayout();
            threeGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 37);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Password";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(95, 33);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(521, 23);
            passwordTextBox.TabIndex = 1;
            // 
            // oldGroupBox
            // 
            oldGroupBox.Controls.Add(label4);
            oldGroupBox.Controls.Add(label13);
            oldGroupBox.Controls.Add(label3);
            oldGroupBox.Controls.Add(label2);
            oldGroupBox.Controls.Add(decryOldTextBox);
            oldGroupBox.Controls.Add(decryKeyOldTextBox);
            oldGroupBox.Controls.Add(encryOldTextBox);
            oldGroupBox.Controls.Add(KeyEncrOldTextBox);
            oldGroupBox.Controls.Add(keyOldTextBox);
            oldGroupBox.Location = new Point(12, 92);
            oldGroupBox.Name = "oldGroupBox";
            oldGroupBox.Size = new Size(374, 433);
            oldGroupBox.TabIndex = 2;
            oldGroupBox.TabStop = false;
            oldGroupBox.Text = "Old Method";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 81);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 6;
            label4.Text = "Key";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(25, 247);
            label13.Name = "label13";
            label13.Size = new Size(48, 15);
            label13.TabIndex = 11;
            label13.Text = "Decrypt";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 165);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Encrypted";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 331);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 4;
            label2.Text = "Decrypt";
            // 
            // decryOldTextBox
            // 
            decryOldTextBox.Location = new Point(20, 350);
            decryOldTextBox.Multiline = true;
            decryOldTextBox.Name = "decryOldTextBox";
            decryOldTextBox.ReadOnly = true;
            decryOldTextBox.Size = new Size(348, 59);
            decryOldTextBox.TabIndex = 3;
            // 
            // decryKeyOldTextBox
            // 
            decryKeyOldTextBox.Location = new Point(20, 266);
            decryKeyOldTextBox.Multiline = true;
            decryKeyOldTextBox.Name = "decryKeyOldTextBox";
            decryKeyOldTextBox.ReadOnly = true;
            decryKeyOldTextBox.Size = new Size(348, 59);
            decryKeyOldTextBox.TabIndex = 8;
            // 
            // encryOldTextBox
            // 
            encryOldTextBox.Location = new Point(20, 184);
            encryOldTextBox.Multiline = true;
            encryOldTextBox.Name = "encryOldTextBox";
            encryOldTextBox.ReadOnly = true;
            encryOldTextBox.Size = new Size(348, 59);
            encryOldTextBox.TabIndex = 2;
            // 
            // KeyEncrOldTextBox
            // 
            KeyEncrOldTextBox.Location = new Point(20, 100);
            KeyEncrOldTextBox.Multiline = true;
            KeyEncrOldTextBox.Name = "KeyEncrOldTextBox";
            KeyEncrOldTextBox.ReadOnly = true;
            KeyEncrOldTextBox.Size = new Size(348, 59);
            KeyEncrOldTextBox.TabIndex = 1;
            // 
            // keyOldTextBox
            // 
            keyOldTextBox.Location = new Point(20, 17);
            keyOldTextBox.Multiline = true;
            keyOldTextBox.Name = "keyOldTextBox";
            keyOldTextBox.ReadOnly = true;
            keyOldTextBox.Size = new Size(348, 59);
            keyOldTextBox.TabIndex = 0;
            // 
            // twoGroupBox
            // 
            twoGroupBox.Controls.Add(label16);
            twoGroupBox.Controls.Add(decryKeyTwoTextBox);
            twoGroupBox.Controls.Add(label5);
            twoGroupBox.Controls.Add(label6);
            twoGroupBox.Controls.Add(label7);
            twoGroupBox.Controls.Add(decryTwoTextBox);
            twoGroupBox.Controls.Add(encryTwoTextBox);
            twoGroupBox.Controls.Add(KeyEncrTwoTextBox);
            twoGroupBox.Controls.Add(keyTwoTextBox);
            twoGroupBox.Location = new Point(415, 92);
            twoGroupBox.Name = "twoGroupBox";
            twoGroupBox.Size = new Size(374, 433);
            twoGroupBox.TabIndex = 3;
            twoGroupBox.TabStop = false;
            twoGroupBox.Text = "Two (New Method 1)";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(25, 246);
            label16.Name = "label16";
            label16.Size = new Size(48, 15);
            label16.TabIndex = 12;
            label16.Text = "Decrypt";
            // 
            // decryKeyTwoTextBox
            // 
            decryKeyTwoTextBox.Location = new Point(20, 265);
            decryKeyTwoTextBox.Multiline = true;
            decryKeyTwoTextBox.Name = "decryKeyTwoTextBox";
            decryKeyTwoTextBox.ReadOnly = true;
            decryKeyTwoTextBox.Size = new Size(348, 59);
            decryKeyTwoTextBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 81);
            label5.Name = "label5";
            label5.Size = new Size(26, 15);
            label5.TabIndex = 6;
            label5.Text = "Key";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 165);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 5;
            label6.Text = "Encrypted";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 329);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 4;
            label7.Text = "Decrypt";
            // 
            // decryTwoTextBox
            // 
            decryTwoTextBox.Location = new Point(20, 348);
            decryTwoTextBox.Multiline = true;
            decryTwoTextBox.Name = "decryTwoTextBox";
            decryTwoTextBox.ReadOnly = true;
            decryTwoTextBox.Size = new Size(348, 59);
            decryTwoTextBox.TabIndex = 3;
            // 
            // encryTwoTextBox
            // 
            encryTwoTextBox.Location = new Point(20, 184);
            encryTwoTextBox.Multiline = true;
            encryTwoTextBox.Name = "encryTwoTextBox";
            encryTwoTextBox.ReadOnly = true;
            encryTwoTextBox.Size = new Size(348, 59);
            encryTwoTextBox.TabIndex = 2;
            // 
            // KeyEncrTwoTextBox
            // 
            KeyEncrTwoTextBox.Location = new Point(20, 100);
            KeyEncrTwoTextBox.Multiline = true;
            KeyEncrTwoTextBox.Name = "KeyEncrTwoTextBox";
            KeyEncrTwoTextBox.ReadOnly = true;
            KeyEncrTwoTextBox.Size = new Size(348, 59);
            KeyEncrTwoTextBox.TabIndex = 1;
            // 
            // keyTwoTextBox
            // 
            keyTwoTextBox.Location = new Point(20, 17);
            keyTwoTextBox.Multiline = true;
            keyTwoTextBox.Name = "keyTwoTextBox";
            keyTwoTextBox.ReadOnly = true;
            keyTwoTextBox.Size = new Size(348, 59);
            keyTwoTextBox.TabIndex = 0;
            // 
            // threeGroupBox
            // 
            threeGroupBox.Controls.Add(label19);
            threeGroupBox.Controls.Add(decryKeyThreeTextBox);
            threeGroupBox.Controls.Add(label8);
            threeGroupBox.Controls.Add(label9);
            threeGroupBox.Controls.Add(label10);
            threeGroupBox.Controls.Add(decryThreeTextBox);
            threeGroupBox.Controls.Add(encryThreeTextBox);
            threeGroupBox.Controls.Add(KeyEncrThreeTextBox);
            threeGroupBox.Controls.Add(keyThreeTextBox);
            threeGroupBox.Location = new Point(804, 92);
            threeGroupBox.Name = "threeGroupBox";
            threeGroupBox.Size = new Size(374, 433);
            threeGroupBox.TabIndex = 4;
            threeGroupBox.TabStop = false;
            threeGroupBox.Text = "Three (New Method 2)";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(25, 248);
            label19.Name = "label19";
            label19.Size = new Size(48, 15);
            label19.TabIndex = 12;
            label19.Text = "Decrypt";
            // 
            // decryKeyThreeTextBox
            // 
            decryKeyThreeTextBox.Location = new Point(20, 267);
            decryKeyThreeTextBox.Multiline = true;
            decryKeyThreeTextBox.Name = "decryKeyThreeTextBox";
            decryKeyThreeTextBox.ReadOnly = true;
            decryKeyThreeTextBox.Size = new Size(348, 59);
            decryKeyThreeTextBox.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 81);
            label8.Name = "label8";
            label8.Size = new Size(26, 15);
            label8.TabIndex = 6;
            label8.Text = "Key";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 165);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 5;
            label9.Text = "Encrypted";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(25, 331);
            label10.Name = "label10";
            label10.Size = new Size(48, 15);
            label10.TabIndex = 4;
            label10.Text = "Decrypt";
            // 
            // decryThreeTextBox
            // 
            decryThreeTextBox.Location = new Point(20, 350);
            decryThreeTextBox.Multiline = true;
            decryThreeTextBox.Name = "decryThreeTextBox";
            decryThreeTextBox.ReadOnly = true;
            decryThreeTextBox.Size = new Size(348, 59);
            decryThreeTextBox.TabIndex = 3;
            // 
            // encryThreeTextBox
            // 
            encryThreeTextBox.Location = new Point(20, 184);
            encryThreeTextBox.Multiline = true;
            encryThreeTextBox.Name = "encryThreeTextBox";
            encryThreeTextBox.ReadOnly = true;
            encryThreeTextBox.Size = new Size(348, 59);
            encryThreeTextBox.TabIndex = 2;
            // 
            // KeyEncrThreeTextBox
            // 
            KeyEncrThreeTextBox.Location = new Point(20, 100);
            KeyEncrThreeTextBox.Multiline = true;
            KeyEncrThreeTextBox.Name = "KeyEncrThreeTextBox";
            KeyEncrThreeTextBox.ReadOnly = true;
            KeyEncrThreeTextBox.Size = new Size(348, 59);
            KeyEncrThreeTextBox.TabIndex = 1;
            // 
            // keyThreeTextBox
            // 
            keyThreeTextBox.Location = new Point(20, 17);
            keyThreeTextBox.Multiline = true;
            keyThreeTextBox.Name = "keyThreeTextBox";
            keyThreeTextBox.ReadOnly = true;
            keyThreeTextBox.Size = new Size(348, 59);
            keyThreeTextBox.TabIndex = 0;
            // 
            // generateButton
            // 
            generateButton.Location = new Point(93, 63);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(203, 23);
            generateButton.TabIndex = 5;
            generateButton.Text = "Generate";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += GenerateButton_Click;
            // 
            // falsifyButton
            // 
            falsifyButton.Location = new Point(632, 63);
            falsifyButton.Name = "falsifyButton";
            falsifyButton.Size = new Size(203, 23);
            falsifyButton.TabIndex = 7;
            falsifyButton.Text = "Falsify";
            falsifyButton.UseVisualStyleBackColor = true;
            falsifyButton.Click += FalsifyButton_Click;
            // 
            // falsePasswordTextBox
            // 
            falsePasswordTextBox.Location = new Point(634, 33);
            falsePasswordTextBox.Name = "falsePasswordTextBox";
            falsePasswordTextBox.Size = new Size(538, 23);
            falsePasswordTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 553);
            Controls.Add(falsifyButton);
            Controls.Add(falsePasswordTextBox);
            Controls.Add(generateButton);
            Controls.Add(threeGroupBox);
            Controls.Add(twoGroupBox);
            Controls.Add(oldGroupBox);
            Controls.Add(passwordTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Test Encryption";
            oldGroupBox.ResumeLayout(false);
            oldGroupBox.PerformLayout();
            twoGroupBox.ResumeLayout(false);
            twoGroupBox.PerformLayout();
            threeGroupBox.ResumeLayout(false);
            threeGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox passwordTextBox;
        private GroupBox oldGroupBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox decryOldTextBox;
        private TextBox encryOldTextBox;
        private TextBox KeyEncrOldTextBox;
        private TextBox keyOldTextBox;
        private GroupBox twoGroupBox;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox decryTwoTextBox;
        private TextBox encryTwoTextBox;
        private TextBox KeyEncrTwoTextBox;
        private TextBox keyTwoTextBox;
        private GroupBox threeGroupBox;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox decryThreeTextBox;
        private TextBox encryThreeTextBox;
        private TextBox KeyEncrThreeTextBox;
        private TextBox keyThreeTextBox;
        private Button generateButton;
        private Label label13;
        private TextBox decryKeyOldTextBox;
        private Label label16;
        private TextBox decryKeyTwoTextBox;
        private Label label19;
        private TextBox decryKeyThreeTextBox;
        private Button falsifyButton;
        private TextBox falsePasswordTextBox;
    }
}
