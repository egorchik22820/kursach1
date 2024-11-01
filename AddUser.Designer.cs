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
            Name_textBox = new TextBox();
            Password_textBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            AddButton = new Button();
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
            // Name_textBox
            // 
            Name_textBox.Location = new Point(114, 141);
            Name_textBox.Name = "Name_textBox";
            Name_textBox.Size = new Size(125, 27);
            Name_textBox.TabIndex = 1;
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
            label1.Size = new Size(39, 20);
            label1.TabIndex = 3;
            label1.Text = "Имя";
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
            AddButton.Location = new Point(257, 200);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 6;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 357);
            Controls.Add(AddButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Password_textBox);
            Controls.Add(Name_textBox);
            Controls.Add(UserType_ComboBox);
            Name = "AddUser";
            Text = "AddUser";
            Activated += AddUser_Activated;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox UserType_ComboBox;
        private TextBox Name_textBox;
        private TextBox Password_textBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button AddButton;
    }
}