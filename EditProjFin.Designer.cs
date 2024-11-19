namespace kursach
{
    partial class EditProjFin
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
            Edit_button = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Amount_textBox = new TextBox();
            Date_textBox = new TextBox();
            Describtion_textBox = new TextBox();
            ProjectName_comboBox = new ComboBox();
            SuspendLayout();
            // 
            // Edit_button
            // 
            Edit_button.Location = new Point(331, 160);
            Edit_button.Name = "Edit_button";
            Edit_button.Size = new Size(94, 29);
            Edit_button.TabIndex = 17;
            Edit_button.Text = "Добавить";
            Edit_button.UseVisualStyleBackColor = true;
            Edit_button.Click += Edit_button_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(609, 69);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 16;
            label4.Text = "Сумма:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(478, 69);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 15;
            label3.Text = "Датада:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(275, 69);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 14;
            label2.Text = "Описание:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 69);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 13;
            label1.Text = "Проект:";
            // 
            // Amount_textBox
            // 
            Amount_textBox.Location = new Point(609, 93);
            Amount_textBox.Name = "Amount_textBox";
            Amount_textBox.Size = new Size(125, 27);
            Amount_textBox.TabIndex = 12;
            // 
            // Date_textBox
            // 
            Date_textBox.Location = new Point(478, 92);
            Date_textBox.Name = "Date_textBox";
            Date_textBox.Size = new Size(125, 27);
            Date_textBox.TabIndex = 11;
            // 
            // Describtion_textBox
            // 
            Describtion_textBox.Location = new Point(275, 92);
            Describtion_textBox.Name = "Describtion_textBox";
            Describtion_textBox.Size = new Size(197, 27);
            Describtion_textBox.TabIndex = 10;
            // 
            // ProjectName_comboBox
            // 
            ProjectName_comboBox.FormattingEnabled = true;
            ProjectName_comboBox.Location = new Point(24, 92);
            ProjectName_comboBox.Name = "ProjectName_comboBox";
            ProjectName_comboBox.Size = new Size(245, 28);
            ProjectName_comboBox.TabIndex = 9;
            // 
            // EditProjFin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 258);
            Controls.Add(Edit_button);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Amount_textBox);
            Controls.Add(Date_textBox);
            Controls.Add(Describtion_textBox);
            Controls.Add(ProjectName_comboBox);
            Name = "EditProjFin";
            Text = "EditProjFin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Edit_button;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox Amount_textBox;
        private TextBox Date_textBox;
        private TextBox Describtion_textBox;
        private ComboBox ProjectName_comboBox;
    }
}