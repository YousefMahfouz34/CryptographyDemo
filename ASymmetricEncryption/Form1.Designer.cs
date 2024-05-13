namespace ASymmetricEncryption
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
            Encrypt = new Button();
            Deycrept = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // Encrypt
            // 
            Encrypt.Location = new Point(815, 125);
            Encrypt.Name = "Encrypt";
            Encrypt.Size = new Size(75, 23);
            Encrypt.TabIndex = 0;
            Encrypt.Text = "Encrypt";
            Encrypt.UseVisualStyleBackColor = true;
            Encrypt.Click += Encrypt_Click;
            // 
            // Deycrept
            // 
            Deycrept.Location = new Point(815, 315);
            Deycrept.Name = "Deycrept";
            Deycrept.Size = new Size(75, 23);
            Deycrept.TabIndex = 1;
            Deycrept.Text = "Deycrept";
            Deycrept.UseVisualStyleBackColor = true;
            Deycrept.Click += Deycrept_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(72, 36);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(330, 132);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(72, 218);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(330, 132);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(72, 451);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(330, 132);
            textBox3.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 627);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Deycrept);
            Controls.Add(Encrypt);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Encrypt;
        private Button Deycrept;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
