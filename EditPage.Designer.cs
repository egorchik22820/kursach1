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
            label4 = new Label();
            label5 = new Label();
            LastName_textBox = new TextBox();
            Name_textBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            Telephone_textBox = new TextBox();
            Position_textBox = new TextBox();
            SuspendLayout();
            // 
            // Login_textBox
            // 
            Login_textBox.Location = new Point(79, 80);
            Login_textBox.Name = "Login_textBox";
            Login_textBox.Size = new Size(125, 27);
            Login_textBox.TabIndex = 0;
            // 
            // Password_textBox
            // 
            Password_textBox.Location = new Point(210, 80);
            Password_textBox.Name = "Password_textBox";
            Password_textBox.Size = new Size(125, 27);
            Password_textBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 57);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 3;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 57);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 4;
            label2.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(341, 57);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 5;
            label3.Text = "Права";
            // 
            // EditButton
            // 
            EditButton.Location = new Point(222, 219);
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
            UserType_comboBox.Location = new Point(341, 79);
            UserType_comboBox.Name = "UserType_comboBox";
            UserType_comboBox.Size = new Size(151, 28);
            UserType_comboBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(210, 110);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 11;
            label4.Text = "Фамилия";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 110);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 10;
            label5.Text = "Имя";
            // 
            // LastName_textBox
            // 
            LastName_textBox.Location = new Point(210, 133);
            LastName_textBox.Name = "LastName_textBox";
            LastName_textBox.Size = new Size(125, 27);
            LastName_textBox.TabIndex = 9;
            // 
            // Name_textBox
            // 
            Name_textBox.Location = new Point(79, 133);
            Name_textBox.Name = "Name_textBox";
            Name_textBox.Size = new Size(125, 27);
            Name_textBox.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(210, 163);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 15;
            label6.Text = "Телефон";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(79, 163);
            label7.Name = "label7";
            label7.Size = new Size(86, 20);
            label7.TabIndex = 14;
            label7.Text = "Должность";
            // 
            // Telephone_textBox
            // 
            Telephone_textBox.Location = new Point(210, 186);
            Telephone_textBox.Name = "Telephone_textBox";
            Telephone_textBox.Size = new Size(125, 27);
            Telephone_textBox.TabIndex = 13;
            // 
            // Position_textBox
            // 
            Position_textBox.Location = new Point(79, 186);
            Position_textBox.Name = "Position_textBox";
            Position_textBox.Size = new Size(125, 27);
            Position_textBox.TabIndex = 12;
            // 
            // EditPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 293);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(Telephone_textBox);
            Controls.Add(Position_textBox);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(LastName_textBox);
            Controls.Add(Name_textBox);
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
        private Label label4;
        private Label label5;
        private TextBox LastName_textBox;
        private TextBox Name_textBox;
        private Label label6;
        private Label label7;
        private TextBox Telephone_textBox;
        private TextBox Position_textBox;
    }
}