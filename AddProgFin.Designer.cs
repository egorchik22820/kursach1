namespace kursach
{
    partial class AddProgFin
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
            ProjectName_comboBox = new ComboBox();
            Describtion_textBox = new TextBox();
            Date_textBox = new TextBox();
            Amount_textBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Add_button = new Button();
            SuspendLayout();
            // 
            // ProjectName_comboBox
            // 
            ProjectName_comboBox.FormattingEnabled = true;
            ProjectName_comboBox.Location = new Point(37, 111);
            ProjectName_comboBox.Name = "ProjectName_comboBox";
            ProjectName_comboBox.Size = new Size(245, 28);
            ProjectName_comboBox.TabIndex = 0;
            // 
            // Describtion_textBox
            // 
            Describtion_textBox.Location = new Point(288, 111);
            Describtion_textBox.Name = "Describtion_textBox";
            Describtion_textBox.Size = new Size(197, 27);
            Describtion_textBox.TabIndex = 1;
            //Describtion_textBox.TextChanged += this.Describtion_textBox_TextChanged;
            // 
            // Date_textBox
            // 
            Date_textBox.Location = new Point(491, 111);
            Date_textBox.Name = "Date_textBox";
            Date_textBox.Size = new Size(125, 27);
            Date_textBox.TabIndex = 2;
            //Date_textBox.TextChanged += this.Date_textBox_TextChanged;
            // 
            // Amount_textBox
            // 
            Amount_textBox.Location = new Point(622, 112);
            Amount_textBox.Name = "Amount_textBox";
            Amount_textBox.Size = new Size(125, 27);
            Amount_textBox.TabIndex = 3;
            //Amount_textBox.TextChanged += this.Amount_textBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 88);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 4;
            label1.Text = "Проект:";
            //label1.Click += this.label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 88);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 5;
            label2.Text = "Описание:";
            //label2.Click += this.label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(491, 88);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 6;
            label3.Text = "Датада:";
            //label3.Click += this.label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(622, 88);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 7;
            label4.Text = "Сумма:";
            //label4.Click += this.label4_Click;
            // 
            // Add_button
            // 
            Add_button.Location = new Point(344, 179);
            Add_button.Name = "Add_button";
            Add_button.Size = new Size(94, 29);
            Add_button.TabIndex = 8;
            Add_button.Text = "Добавить";
            Add_button.UseVisualStyleBackColor = true;
            Add_button.Click += Add_button_Click;
            // 
            // AddProgFin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 299);
            Controls.Add(Add_button);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Amount_textBox);
            Controls.Add(Date_textBox);
            Controls.Add(Describtion_textBox);
            Controls.Add(ProjectName_comboBox);
            Name = "AddProgFin";
            Text = "AddProgFin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ProjectName_comboBox;
        private TextBox Describtion_textBox;
        private TextBox Date_textBox;
        private TextBox Amount_textBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Add_button;
    }
}