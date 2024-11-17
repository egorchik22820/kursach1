namespace kursach
{
    partial class AdminPanel
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
            users_dataGridView = new DataGridView();
            label1 = new Label();
            Add_button = new Button();
            Edit_button = new Button();
            Delete_button = new Button();
            Search_textBox = new TextBox();
            label2 = new Label();
            openProj_button = new Button();
            openProjRes_button = new Button();
            openProjFinbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)users_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // users_dataGridView
            // 
            users_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            users_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            users_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            users_dataGridView.Location = new Point(12, 42);
            users_dataGridView.Name = "users_dataGridView";
            users_dataGridView.RowHeadersWidth = 51;
            users_dataGridView.Size = new Size(740, 323);
            users_dataGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 1;
            label1.Text = "Пользователи:";
            // 
            // Add_button
            // 
            Add_button.Location = new Point(458, 12);
            Add_button.Name = "Add_button";
            Add_button.Size = new Size(94, 29);
            Add_button.TabIndex = 2;
            Add_button.Text = "Добавить";
            Add_button.UseVisualStyleBackColor = true;
            Add_button.Click += Add_button_Click;
            // 
            // Edit_button
            // 
            Edit_button.Location = new Point(558, 12);
            Edit_button.Name = "Edit_button";
            Edit_button.Size = new Size(94, 29);
            Edit_button.TabIndex = 3;
            Edit_button.Text = "Изменить";
            Edit_button.UseVisualStyleBackColor = true;
            Edit_button.Click += Edit_button_Click;
            // 
            // Delete_button
            // 
            Delete_button.Location = new Point(658, 12);
            Delete_button.Name = "Delete_button";
            Delete_button.Size = new Size(94, 29);
            Delete_button.TabIndex = 4;
            Delete_button.Text = "Удалить";
            Delete_button.UseVisualStyleBackColor = true;
            Delete_button.Click += Delete_button_Click;
            // 
            // Search_textBox
            // 
            Search_textBox.Location = new Point(12, 401);
            Search_textBox.Name = "Search_textBox";
            Search_textBox.Size = new Size(251, 27);
            Search_textBox.TabIndex = 5;
            Search_textBox.TextChanged += Search_textBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 378);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 6;
            label2.Text = "Поиск";
            // 
            // openProj_button
            // 
            openProj_button.Location = new Point(406, 378);
            openProj_button.Name = "openProj_button";
            openProj_button.Size = new Size(94, 29);
            openProj_button.TabIndex = 7;
            openProj_button.Text = "Проекты";
            openProj_button.UseVisualStyleBackColor = true;
            openProj_button.Click += openProj_button_Click;
            // 
            // openProjRes_button
            // 
            openProjRes_button.Location = new Point(506, 378);
            openProjRes_button.Name = "openProjRes_button";
            openProjRes_button.Size = new Size(146, 29);
            openProjRes_button.TabIndex = 8;
            openProjRes_button.Text = "Учет ресурсов";
            openProjRes_button.UseVisualStyleBackColor = true;
            openProjRes_button.Click += openProjRes_button_Click;
            // 
            // openProjFinbutton
            // 
            openProjFinbutton.Location = new Point(658, 378);
            openProjFinbutton.Name = "openProjFinbutton";
            openProjFinbutton.Size = new Size(94, 29);
            openProjFinbutton.TabIndex = 9;
            openProjFinbutton.Text = "Затраты";
            openProjFinbutton.UseVisualStyleBackColor = true;
            openProjFinbutton.Click += openProjFinbutton_Click;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(openProjFinbutton);
            Controls.Add(openProjRes_button);
            Controls.Add(openProj_button);
            Controls.Add(label2);
            Controls.Add(Search_textBox);
            Controls.Add(Delete_button);
            Controls.Add(Edit_button);
            Controls.Add(Add_button);
            Controls.Add(label1);
            Controls.Add(users_dataGridView);
            Name = "AdminPanel";
            Text = "AdminPanel";
            Activated += AdminPanel_Activated;
            ((System.ComponentModel.ISupportInitialize)users_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView users_dataGridView;
        private Label label1;
        private Button Add_button;
        private Button Edit_button;
        private Button Delete_button;
        private TextBox Search_textBox;
        private Label label2;
        private Button openProj_button;
        private Button openProjRes_button;
        private Button openProjFinbutton;
    }
}