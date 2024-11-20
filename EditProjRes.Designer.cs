namespace kursach
{
    partial class EditProjRes
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
            Resource_comboBox = new ComboBox();
            Edit_button = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Amount_textBox = new TextBox();
            Quantity_textBox = new TextBox();
            ProjectName_comboBox = new ComboBox();
            SuspendLayout();
            // 
            // Resource_comboBox
            // 
            Resource_comboBox.FormattingEnabled = true;
            Resource_comboBox.Location = new Point(286, 112);
            Resource_comboBox.Name = "Resource_comboBox";
            Resource_comboBox.Size = new Size(197, 28);
            Resource_comboBox.TabIndex = 27;
            // 
            // Edit_button
            // 
            Edit_button.Location = new Point(342, 181);
            Edit_button.Name = "Edit_button";
            Edit_button.Size = new Size(94, 29);
            Edit_button.TabIndex = 26;
            Edit_button.Text = "Сохранить";
            Edit_button.UseVisualStyleBackColor = true;
            Edit_button.Click += Edit_button_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(620, 90);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 25;
            label4.Text = "Сумма:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(489, 90);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 24;
            label3.Text = "Кол-во:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286, 90);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 23;
            label2.Text = "Ресурс:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 90);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 22;
            label1.Text = "Проект:";
            // 
            // Amount_textBox
            // 
            Amount_textBox.Location = new Point(620, 114);
            Amount_textBox.Name = "Amount_textBox";
            Amount_textBox.Size = new Size(125, 27);
            Amount_textBox.TabIndex = 21;
            // 
            // Quantity_textBox
            // 
            Quantity_textBox.Location = new Point(489, 113);
            Quantity_textBox.Name = "Quantity_textBox";
            Quantity_textBox.Size = new Size(125, 27);
            Quantity_textBox.TabIndex = 20;
            // 
            // ProjectName_comboBox
            // 
            ProjectName_comboBox.FormattingEnabled = true;
            ProjectName_comboBox.Location = new Point(35, 113);
            ProjectName_comboBox.Name = "ProjectName_comboBox";
            ProjectName_comboBox.Size = new Size(245, 28);
            ProjectName_comboBox.TabIndex = 19;
            // 
            // EditProjRes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 266);
            Controls.Add(Resource_comboBox);
            Controls.Add(Edit_button);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Amount_textBox);
            Controls.Add(Quantity_textBox);
            Controls.Add(ProjectName_comboBox);
            Name = "EditProjRes";
            Text = "EditProjRes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Resource_comboBox;
        private Button Edit_button;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox Amount_textBox;
        private TextBox Quantity_textBox;
        private ComboBox ProjectName_comboBox;
    }
}