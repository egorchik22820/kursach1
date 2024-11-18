namespace kursach
{
    partial class AddProj
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
            EndDate_textBox = new TextBox();
            AddButton = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            StartDate_textBox = new TextBox();
            Name_textBox = new TextBox();
            label4 = new Label();
            Status_textBox = new TextBox();
            SuspendLayout();
            // 
            // EndDate_textBox
            // 
            EndDate_textBox.Location = new Point(276, 181);
            EndDate_textBox.Name = "EndDate_textBox";
            EndDate_textBox.Size = new Size(125, 27);
            EndDate_textBox.TabIndex = 22;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(223, 214);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 21;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(276, 158);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 20;
            label3.Text = "Дата завершения";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 158);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 19;
            label2.Text = "Дата начала";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 103);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 18;
            label1.Text = "Название";
            // 
            // StartDate_textBox
            // 
            StartDate_textBox.Location = new Point(145, 181);
            StartDate_textBox.Name = "StartDate_textBox";
            StartDate_textBox.Size = new Size(125, 27);
            StartDate_textBox.TabIndex = 17;
            // 
            // Name_textBox
            // 
            Name_textBox.Location = new Point(145, 126);
            Name_textBox.Name = "Name_textBox";
            Name_textBox.Size = new Size(125, 27);
            Name_textBox.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(276, 103);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 24;
            label4.Text = "Статус";
            // 
            // Status_textBox
            // 
            Status_textBox.Location = new Point(276, 126);
            Status_textBox.Name = "Status_textBox";
            Status_textBox.Size = new Size(125, 27);
            Status_textBox.TabIndex = 23;
            // 
            // AddProj
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 359);
            Controls.Add(label4);
            Controls.Add(Status_textBox);
            Controls.Add(EndDate_textBox);
            Controls.Add(AddButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(StartDate_textBox);
            Controls.Add(Name_textBox);
            Name = "AddProj";
            Text = "AddProj";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private TextBox Phone_textBox;
        private TextBox Position_textBox;
        private Label label_11;
        private Label label5;
        private TextBox LastName_textBox;
        private TextBox EndDate_textBox;
        private Button AddButton;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox StartDate_textBox;
        private TextBox Name_textBox;
        private Label label4;
        private TextBox Status_textBox;
        private ComboBox UserType_ComboBox;
    }
}