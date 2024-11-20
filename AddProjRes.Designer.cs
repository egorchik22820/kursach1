namespace kursach
{
    partial class AddProjRes
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
            Add_button = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Amount_textBox = new TextBox();
            Quantity_textBox = new TextBox();
            ProjectName_comboBox = new ComboBox();
            Resource_comboBox = new ComboBox();
            SuspendLayout();
            // 
            // Add_button
            // 
            Add_button.Location = new Point(344, 200);
            Add_button.Name = "Add_button";
            Add_button.Size = new Size(94, 29);
            Add_button.TabIndex = 17;
            Add_button.Text = "Добавить";
            Add_button.UseVisualStyleBackColor = true;
            Add_button.Click += Add_button_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(622, 109);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 16;
            label4.Text = "Сумма:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(491, 109);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 15;
            label3.Text = "Кол-во:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 109);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 14;
            label2.Text = "Ресурс:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 109);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 13;
            label1.Text = "Проект:";
            // 
            // Amount_textBox
            // 
            Amount_textBox.Location = new Point(622, 133);
            Amount_textBox.Name = "Amount_textBox";
            Amount_textBox.Size = new Size(125, 27);
            Amount_textBox.TabIndex = 12;
            // 
            // Quantity_textBox
            // 
            Quantity_textBox.Location = new Point(491, 132);
            Quantity_textBox.Name = "Quantity_textBox";
            Quantity_textBox.Size = new Size(125, 27);
            Quantity_textBox.TabIndex = 11;
            // 
            // ProjectName_comboBox
            // 
            ProjectName_comboBox.FormattingEnabled = true;
            ProjectName_comboBox.Location = new Point(37, 132);
            ProjectName_comboBox.Name = "ProjectName_comboBox";
            ProjectName_comboBox.Size = new Size(245, 28);
            ProjectName_comboBox.TabIndex = 9;
            // 
            // Resource_comboBox
            // 
            Resource_comboBox.FormattingEnabled = true;
            Resource_comboBox.Location = new Point(288, 131);
            Resource_comboBox.Name = "Resource_comboBox";
            Resource_comboBox.Size = new Size(197, 28);
            Resource_comboBox.TabIndex = 18;
            // 
            // AddProjRes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 305);
            Controls.Add(Resource_comboBox);
            Controls.Add(Add_button);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Amount_textBox);
            Controls.Add(Quantity_textBox);
            Controls.Add(ProjectName_comboBox);
            Name = "AddProjRes";
            Text = "AddProjRes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Add_button;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox Amount_textBox;
        private TextBox Quantity_textBox;
        private ComboBox ProjectName_comboBox;
        private ComboBox Resource_comboBox;
    }
}