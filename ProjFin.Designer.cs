﻿namespace kursach
{
    partial class ProjFin
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
            Delete_button = new Button();
            Edit_button = new Button();
            Add_button = new Button();
            label1 = new Label();
            projectsFin_dataGridView = new DataGridView();
            label2 = new Label();
            Search_textBox = new TextBox();
            Export_button = new Button();
            ((System.ComponentModel.ISupportInitialize)projectsFin_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // Delete_button
            // 
            Delete_button.Location = new Point(658, 16);
            Delete_button.Name = "Delete_button";
            Delete_button.Size = new Size(94, 29);
            Delete_button.TabIndex = 19;
            Delete_button.Text = "Удалить";
            Delete_button.UseVisualStyleBackColor = true;
            Delete_button.Click += Delete_button_Click;
            // 
            // Edit_button
            // 
            Edit_button.Location = new Point(558, 16);
            Edit_button.Name = "Edit_button";
            Edit_button.Size = new Size(94, 29);
            Edit_button.TabIndex = 18;
            Edit_button.Text = "Изменить";
            Edit_button.UseVisualStyleBackColor = true;
            Edit_button.Click += Edit_button_Click;
            // 
            // Add_button
            // 
            Add_button.Location = new Point(458, 16);
            Add_button.Name = "Add_button";
            Add_button.Size = new Size(94, 29);
            Add_button.TabIndex = 17;
            Add_button.Text = "Добавить";
            Add_button.UseVisualStyleBackColor = true;
            Add_button.Click += Add_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 16;
            label1.Text = "Учет финансов:";
            // 
            // projectsFin_dataGridView
            // 
            projectsFin_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            projectsFin_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            projectsFin_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            projectsFin_dataGridView.Location = new Point(12, 46);
            projectsFin_dataGridView.Name = "projectsFin_dataGridView";
            projectsFin_dataGridView.RowHeadersWidth = 51;
            projectsFin_dataGridView.Size = new Size(740, 323);
            projectsFin_dataGridView.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 388);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 21;
            label2.Text = "Поиск:";
            // 
            // Search_textBox
            // 
            Search_textBox.Location = new Point(12, 411);
            Search_textBox.Name = "Search_textBox";
            Search_textBox.Size = new Size(217, 27);
            Search_textBox.TabIndex = 20;
            Search_textBox.TextChanged += Search_textBox_TextChanged;
            // 
            // Export_button
            // 
            Export_button.Location = new Point(658, 375);
            Export_button.Name = "Export_button";
            Export_button.Size = new Size(94, 29);
            Export_button.TabIndex = 22;
            Export_button.Text = "Экспорт";
            Export_button.UseVisualStyleBackColor = true;
            // 
            // ProjFin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 458);
            Controls.Add(Export_button);
            Controls.Add(label2);
            Controls.Add(Search_textBox);
            Controls.Add(Delete_button);
            Controls.Add(Edit_button);
            Controls.Add(Add_button);
            Controls.Add(label1);
            Controls.Add(projectsFin_dataGridView);
            Name = "ProjFin";
            Text = "ProjFin";
            Activated += ProjFin_Activated;
            ((System.ComponentModel.ISupportInitialize)projectsFin_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Delete_button;
        private Button Edit_button;
        private Button Add_button;
        private Label label1;
        private DataGridView projectsFin_dataGridView;
        private Label label2;
        private TextBox Search_textBox;
        private Button Export_button;
    }
}