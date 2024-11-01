namespace kursach
{
    partial class Autorization
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
            label2 = new Label();
            button1 = new Button();
            Login_textBox = new TextBox();
            Password_textBox = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(286, 136);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286, 209);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "Пароль";
            // 
            // button1
            // 
            button1.Location = new Point(304, 274);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login_textBox
            // 
            Login_textBox.Location = new Point(286, 159);
            Login_textBox.Name = "Login_textBox";
            Login_textBox.Size = new Size(125, 27);
            Login_textBox.TabIndex = 3;
            // 
            // Password_textBox
            // 
            Password_textBox.Location = new Point(286, 232);
            Password_textBox.Name = "Password_textBox";
            Password_textBox.Size = new Size(125, 27);
            Password_textBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(314, 76);
            label3.Name = "label3";
            label3.Size = new Size(64, 31);
            label3.TabIndex = 5;
            label3.Text = "Вход";
            // 
            // Autorization
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 449);
            Controls.Add(label3);
            Controls.Add(Password_textBox);
            Controls.Add(Login_textBox);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Autorization";
            Text = "Form1";
            Activated += Autorization_Activated;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox Login_textBox;
        private TextBox Password_textBox;
        private Label label3;
    }
}
