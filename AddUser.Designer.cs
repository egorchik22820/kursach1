namespace kursach
{
    partial class AddUser
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
            UserType_ComboBox = new ComboBox();
            Login_textBox = new TextBox();
            Password_textBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            AddButton = new Button();
            label_11 = new Label();
            label5 = new Label();
            LastName_textBox = new TextBox();
            Name_textBox = new TextBox();
            label4 = new Label();
            label6 = new Label();
            Phone_textBox = new TextBox();
            Position_textBox = new TextBox();
            SuspendLayout();
            // 
            // UserType_ComboBox
            // 
            UserType_ComboBox.FormattingEnabled = true;
            UserType_ComboBox.Location = new Point(376, 141);
            UserType_ComboBox.Name = "UserType_ComboBox";
            UserType_ComboBox.Size = new Size(125, 28);
            UserType_ComboBox.TabIndex = 0;
            // 
            // Login_textBox
            // 
            Login_textBox.Location = new Point(114, 141);
            Login_textBox.Name = "Login_textBox";
            Login_textBox.Size = new Size(125, 27);
            Login_textBox.TabIndex = 1;
            // 
            // Password_textBox
            // 
            Password_textBox.Location = new Point(245, 141);
            Password_textBox.Name = "Password_textBox";
            Password_textBox.Size = new Size(125, 27);
            Password_textBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 118);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 3;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 118);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 4;
            label2.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(376, 118);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 5;
            label3.Text = "Права";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(256, 309);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 6;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // label_11
            // 
            label_11.AutoSize = true;
            label_11.Location = new Point(245, 180);
            label_11.Name = "label_11";
            label_11.Size = new Size(73, 20);
            label_11.TabIndex = 10;
            label_11.Text = "Фамилия";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(114, 180);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 9;
            label5.Text = "Имя";
            // 
            // LastName_textBox
            // 
            LastName_textBox.Location = new Point(245, 203);
            LastName_textBox.Name = "LastName_textBox";
            LastName_textBox.Size = new Size(125, 27);
            LastName_textBox.TabIndex = 8;
            // 
            // Name_textBox
            // 
            Name_textBox.Location = new Point(114, 203);
            Name_textBox.Name = "Name_textBox";
            Name_textBox.Size = new Size(125, 27);
            Name_textBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(245, 240);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 14;
            label4.Text = "Телефон";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(114, 240);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 13;
            label6.Text = "Должность";
            // 
            // Phone_textBox
            // 
            Phone_textBox.Location = new Point(245, 263);
            Phone_textBox.Name = "Phone_textBox";
            Phone_textBox.Size = new Size(125, 27);
            Phone_textBox.TabIndex = 12;
            // 
            // Position_textBox
            // 
            Position_textBox.Location = new Point(114, 263);
            Position_textBox.Name = "Position_textBox";
            Position_textBox.Size = new Size(125, 27);
            Position_textBox.TabIndex = 11;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 453);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(Phone_textBox);
            Controls.Add(Position_textBox);
            Controls.Add(label_11);
            Controls.Add(label5);
            Controls.Add(LastName_textBox);
            Controls.Add(Name_textBox);
            Controls.Add(AddButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Password_textBox);
            Controls.Add(Login_textBox);
            Controls.Add(UserType_ComboBox);
            Name = "AddUser";
            Text = "AddUser";
            Activated += AddUser_Activated;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox UserType_ComboBox;
        private TextBox Login_textBox;
        private TextBox Password_textBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button AddButton;
        private Label label_11;
        private Label label5;
        private TextBox LastName_textBox;
        private TextBox Name_textBox;
        private Label label4;
        private Label label6;
        private TextBox Phone_textBox;
        private TextBox Position_textBox;
    }
}