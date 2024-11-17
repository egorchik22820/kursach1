namespace kursach
{
    partial class Projects
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
            projects_dataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)projects_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // Delete_button
            // 
            Delete_button.Location = new Point(658, 15);
            Delete_button.Name = "Delete_button";
            Delete_button.Size = new Size(94, 29);
            Delete_button.TabIndex = 9;
            Delete_button.Text = "Удалить";
            Delete_button.UseVisualStyleBackColor = true;
            // 
            // Edit_button
            // 
            Edit_button.Location = new Point(558, 15);
            Edit_button.Name = "Edit_button";
            Edit_button.Size = new Size(94, 29);
            Edit_button.TabIndex = 8;
            Edit_button.Text = "Изменить";
            Edit_button.UseVisualStyleBackColor = true;
            // 
            // Add_button
            // 
            Add_button.Location = new Point(458, 15);
            Add_button.Name = "Add_button";
            Add_button.Size = new Size(94, 29);
            Add_button.TabIndex = 7;
            Add_button.Text = "Добавить";
            Add_button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 6;
            label1.Text = "Проекты:";
            // 
            // projects_dataGridView
            // 
            projects_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            projects_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            projects_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            projects_dataGridView.Location = new Point(12, 45);
            projects_dataGridView.Name = "projects_dataGridView";
            projects_dataGridView.RowHeadersWidth = 51;
            projects_dataGridView.Size = new Size(740, 323);
            projects_dataGridView.TabIndex = 5;
            // 
            // Projects
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Delete_button);
            Controls.Add(Edit_button);
            Controls.Add(Add_button);
            Controls.Add(label1);
            Controls.Add(projects_dataGridView);
            Name = "Projects";
            Text = "Projects";
            Activated += Projects_Activated;
            ((System.ComponentModel.ISupportInitialize)projects_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Delete_button;
        private Button Edit_button;
        private Button Add_button;
        private Label label1;
        private DataGridView projects_dataGridView;
    }
}