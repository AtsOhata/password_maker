
namespace PasswordMaker
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.privateSeed1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.privateSeed2 = new System.Windows.Forms.TextBox();
            this.privateSeed3 = new System.Windows.Forms.TextBox();
            this.privateSeed4 = new System.Windows.Forms.TextBox();
            this.publicSeedTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordDigitComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Make";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // privateSeed1
            // 
            this.privateSeed1.Location = new System.Drawing.Point(108, 12);
            this.privateSeed1.Name = "privateSeed1";
            this.privateSeed1.ReadOnly = true;
            this.privateSeed1.Size = new System.Drawing.Size(269, 23);
            this.privateSeed1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Private Seed 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Private Seed 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Private Seed 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Private Seed 4";
            // 
            // privateSeed2
            // 
            this.privateSeed2.Location = new System.Drawing.Point(108, 41);
            this.privateSeed2.Name = "privateSeed2";
            this.privateSeed2.ReadOnly = true;
            this.privateSeed2.Size = new System.Drawing.Size(269, 23);
            this.privateSeed2.TabIndex = 6;
            // 
            // privateSeed3
            // 
            this.privateSeed3.Location = new System.Drawing.Point(108, 70);
            this.privateSeed3.Name = "privateSeed3";
            this.privateSeed3.ReadOnly = true;
            this.privateSeed3.Size = new System.Drawing.Size(269, 23);
            this.privateSeed3.TabIndex = 7;
            // 
            // privateSeed4
            // 
            this.privateSeed4.Location = new System.Drawing.Point(108, 102);
            this.privateSeed4.Name = "privateSeed4";
            this.privateSeed4.ReadOnly = true;
            this.privateSeed4.Size = new System.Drawing.Size(269, 23);
            this.privateSeed4.TabIndex = 8;
            // 
            // publicSeedTextBox
            // 
            this.publicSeedTextBox.Location = new System.Drawing.Point(108, 131);
            this.publicSeedTextBox.Name = "publicSeedTextBox";
            this.publicSeedTextBox.Size = new System.Drawing.Size(269, 23);
            this.publicSeedTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Public Seed";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(108, 249);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(269, 23);
            this.resultTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Password Digit";
            // 
            // passwordDigitComboBox
            // 
            this.passwordDigitComboBox.FormattingEnabled = true;
            this.passwordDigitComboBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.passwordDigitComboBox.Location = new System.Drawing.Point(108, 182);
            this.passwordDigitComboBox.Name = "passwordDigitComboBox";
            this.passwordDigitComboBox.Size = new System.Drawing.Size(99, 23);
            this.passwordDigitComboBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Password";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Copy Password";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 353);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.passwordDigitComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.publicSeedTextBox);
            this.Controls.Add(this.privateSeed4);
            this.Controls.Add(this.privateSeed3);
            this.Controls.Add(this.privateSeed2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.privateSeed1);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "Password Maker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox publicSeedTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox privateSeed1;
        private System.Windows.Forms.TextBox privateSeed2;
        private System.Windows.Forms.TextBox privateSeed3;
        private System.Windows.Forms.TextBox privateSeed4;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox passwordDigitComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
    }
}

