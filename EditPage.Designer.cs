namespace kursach
{
    partial class EditPage
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
            Login_textBox = new TextBox();
            Password_textBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            EditButton = new Button();
            UserType_comboBox = new ComboBox();
            SuspendLayout();
            // 
            // Login_textBox
            // 
            Login_textBox.Location = new Point(77, 94);
            Login_textBox.Name = "Login_textBox";
            Login_textBox.Size = new Size(125, 27);
            Login_textBox.TabIndex = 0;
            // 
            // Password_textBox
            // 
            Password_textBox.Location = new Point(208, 94);
            Password_textBox.Name = "Password_textBox";
            Password_textBox.Size = new Size(125, 27);
            Password_textBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 71);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 3;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 71);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 4;
            label2.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(339, 71);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 5;
            label3.Text = "Права";
            // 
            // EditButton
            // 
            EditButton.Location = new Point(222, 127);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(94, 29);
            EditButton.TabIndex = 6;
            EditButton.Text = "Готово";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // UserType_comboBox
            // 
            UserType_comboBox.FormattingEnabled = true;
            UserType_comboBox.Location = new Point(339, 93);
            UserType_comboBox.Name = "UserType_comboBox";
            UserType_comboBox.Size = new Size(151, 28);
            UserType_comboBox.TabIndex = 7;
            // 
            // EditPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 239);
            Controls.Add(UserType_comboBox);
            Controls.Add(EditButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Password_textBox);
            Controls.Add(Login_textBox);
            Name = "EditPage";
            Text = "EditPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Login_textBox;
        private TextBox Password_textBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button EditButton;
        private ComboBox UserType_comboBox;
    }
}